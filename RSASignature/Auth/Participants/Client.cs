using RSASignature.Auth.Sign;
using RSASignature.Hash;
using RSASignature.KeyGeneration.Generation;
using RSASignature.KeyGeneration.Keys;
using RSASignature.Util;
using System.Globalization;
using System.Numerics;
using System.Threading.Tasks;

namespace RSASignature.Auth.Participants
{
    class Client
    {
        public string Message { get; set; }
        private RSAKeysGeneration keys;

        private Client()
        {

        }

        public static async Task<Client> Create()
        {
            var client = new Client();

            await client.Initialize();

            return client;
        }

        private async Task Initialize()
        {
            // f(p, q, exp), где p, q, exp простые числа размерностью  >= 2048 бит, 
            //представлены в х16 системе счисления

            keys = await RSAKeysGeneration.Create(

                //p
                BigInteger.Parse("1000000000000000000000000000000000000000000000000" + 
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" + 
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" + 
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000400000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "00000000000000000000647", NumberStyles.HexNumber),
                //q
                BigInteger.Parse("4000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000059B", NumberStyles.HexNumber),
                //exp
                BigInteger.Parse("2000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "0000000000000000000000000000000000000000000000000" +
                                 "000000000000000000000E3", NumberStyles.HexNumber)

                );

        }

        /// <summary>
        /// Передать открытый ключ на сервер
        /// </summary>
        /// <returns>Открытый ключ</returns>
        public PublicKey PassPublicKey()
        {
            return keys.PublicKey;
        }


        /// <summary>
        /// Отправить запрос на сервер
        /// </summary>
        /// <returns> Пара [сообщение, цифровая подпись]</returns>
        public async Task<Signature> Send()
        {
            //получить хеш - образ сообщения
            //перевести из х16 системы в десятичную
            var msgHash = BigInteger.Parse(new SHA256().GetSHA256Hash(Message), NumberStyles.HexNumber);

            //если полученное значение меньше нуля
            if (msgHash < 0)
            {
                //скорректировать его
                msgHash = (BigInteger.One << 256) + msgHash;
            }

            //выработать цифровую подпись, используя закрытый ключ
            var signature = await Task.Factory.StartNew(() => {

                     return Utility.ModularExponentiation(msgHash, keys.PrivateKey.d, keys.PublicKey.n); 

               });

            //вернуть пару [сообщение, цифровая подпись]
            return new Signature(Message, signature);
        }
    }
}
