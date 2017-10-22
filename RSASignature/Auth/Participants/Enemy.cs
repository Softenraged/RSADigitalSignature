using RSASignature.Auth.Sign;
using RSASignature.Util.Extensions;
using System;
using System.Numerics;
using System.Threading.Tasks;

namespace RSASignature.Auth.Participants
{
    class Enemy
    {
        private string message;

        public void CatchMessage(string message)
        {
            this.message = message;
        }

        public async Task<Signature> Attack()
        {
            var fabricatedSignature = FabricateSignature();

            //вернуть пару [сообщение, подпись]
            return new Signature(message, await fabricatedSignature);
        }


        private async Task<BigInteger> FabricateSignature()
        {
            return await Task.Factory.StartNew(() => {

                return new Random().BigIntegerRandom(BigInteger.One << 2048);

            });
        }
    }
}
