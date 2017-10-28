using RSASignature.KeyGeneration.Keys;
using RSASignature.Util;
using RSASignature.Util.Extensions;
using System;
using System.Numerics;
using System.Threading.Tasks;

namespace RSASignature.KeyGeneration.Generation
{
    class RSAKeysGeneration
    {
        public PublicKey  PublicKey;
        public PrivateKey PrivateKey;


        public static async Task<RSAKeysGeneration> Create(BigInteger p, BigInteger q, BigInteger exp)
        {
            var RSAKeyGeneration = new RSAKeysGeneration();

            await RSAKeyGeneration.Initialize(p, q, exp);

            return RSAKeyGeneration;
        }

        private RSAKeysGeneration()
        {

        }

        private async Task Initialize(BigInteger p, BigInteger q, BigInteger exp)
        {

            var isPrime = await Task.WhenAll(Task.Run(() => p.IsProbablyPrime()), 
                                             Task.Run(() => q.IsProbablyPrime())
                                            );

            if (!isPrime[0] || !isPrime[1])
            {
                throw new ArithmeticException("Число p или q не является простым.");
            }

            //получить значения открытого ключа
            PublicKey.n = p * q;
            PublicKey.e = exp;

            //получить значение закрытого ключа
            PrivateKey.n = PublicKey.n;

            //если открытая экспонента взаимно простая
            //с значением функции эйлера
            if (Utility.BinaryGCD(PublicKey.e, Euler(p, q)) == 1)
            {
                //применить расширенный алгоритм евклида
                //для нахождения мультипликативной инверсии,
                //к уравнению ex = 1 (mod phi(p, q)) 
                //получить значение d закрытого ключа
                PrivateKey.d = Utility.ExtendedEuclidean(PublicKey.e, Euler(p, q));

            }
            else
            {
                throw new ArithmeticException("Открытая экспонента и φ(p, q) не взаимно просты.");
            }
        }


        private BigInteger Euler(BigInteger p, BigInteger q)
        {
            return (p - 1) * (q - 1);
        }
    }
}
