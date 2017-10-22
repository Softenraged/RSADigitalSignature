using System;
using System.Numerics;


namespace RSASignature.Util.Extensions
{
    public static class RandomExtensions
    {
        public static BigInteger BigIntegerRandom(this Random random, BigInteger N)
        {
            var bytes = N.ToByteArray();

            BigInteger R;

            do
            {
                random.NextBytes(bytes);

                bytes[bytes.Length - 1] &= (byte)0x7F; //заставить бит знака быть положительным

                R = new BigInteger(bytes);

            } while (R >= N);

            return R;
        }
    }
}
