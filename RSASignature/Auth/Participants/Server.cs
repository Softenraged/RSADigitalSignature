using RSASignature.Auth.Sign;
using RSASignature.Hash;
using RSASignature.KeyGeneration.Keys;
using RSASignature.Util;
using System.Threading.Tasks;

namespace RSASignature.Auth.Participants
{
    public class Server
    {
        private PublicKey publicKey;

        public Server() { }

        /// <summary>
        /// Получить открытый ключ от клиента
        /// </summary>
        /// <param name="publicKey">Открытый ключ</param>
        public void AcceptKey(PublicKey publicKey)
        {
            this.publicKey = publicKey;
        }

        /// <summary>
        /// Принять цифровую подпись на верификацию
        /// </summary>
        /// <param name="signature">Цифровая подпись</param>
        /// <returns>Результат верификации</returns>
        public async Task<bool> Verify(Signature signature)
        {
            //дешифровать хеш - образ цифровой подписи
            var signHash = (await Task.Factory.StartNew(() => {

                   return Utility.ModularExponentiation(signature.RSASignature, publicKey.e, publicKey.n);

            })).ToString("X64");
          
            //если впереди есть нули
            if(signHash.Length > 64)
            {
                //убрать их, оставив 64 значения
                signHash = signHash.Remove(0, signHash.Length - 64);
            } 
              
            //вычислить хеш - образ сообщения
            var msgHash = new SHA256().GetSHA256Hash(signature.Message);
          

            //если хеш - образы совпадают
            if (signHash.Equals(msgHash))
            {
                //верификация прошла успешно
                return true;
            }

            //неудача
            return false;

        }
    }
}
