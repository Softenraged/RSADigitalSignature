using RSASignature.Util.Extensions;
using System.Numerics;

namespace RSASignature.Util
{
    public static class Utility
    {
        //решение уравнений вида value^exp % mod
        public static BigInteger ModularExponentiation(BigInteger value, BigInteger exp, BigInteger mod)
        {

            if (mod == 1) return 0;

            value = value.Mod(mod);

            BigInteger result = 1;

            while (exp > 0)
            {
                //если экспонента нечетная
                //младший бит равен 1 [exp = (1 mod 2)]
                if ((exp & 1) == 1)
                {
                    result = (result * value).Mod(mod);
                }

                //делить показатель на 2
                exp >>= 1;

                value = (value * value).Mod(mod);
            }

            return result;
        }

        public static BigInteger ExtendedEuclidean(BigInteger a, BigInteger b)
        {

            BigInteger d = 0;
            BigInteger newD = 1;
            BigInteger r = b;
            BigInteger newR = a;

            while (newR != 0)
            {


                var quotient = r / newR;

                var tmp = newD;

                newD = d - quotient * newD;

                d = tmp;

                tmp = newR;

                newR = r - quotient * newR;

                r = tmp;

            }


            if (d < 0) d += b;

            return d;
        }

        public static BigInteger BinaryGCD(BigInteger a, BigInteger b)
        {
            //GCD(b, 0) = b
            if (a == 0) return b;

            //GCD(0, a) = a
            if (b == 0) return a;

            int shift;

            //Найти максимальное значение shift, которое
            //характеризует степень двойки, на которую делятся
            //а и b одновременно, если a и b оба четны, то 
            //при битовом ИЛИ в младшем бите останется 0
            for(shift = 0; ((a | b) & 1) == 0; ++shift )
            {
                //делить a на 2
                a >>= 1;

                //делить b на 2
                b >>= 1;
            }

            //делить a на 2 пока 
            //а не станет нечетным
            while((a & 1) == 0)
            {
                a >>= 1;
            }


            do
            {
                //делить b на 2 пока 
                //b не станет нечетным
                while ((b & 1) == 0)
                {
                    b >>= 1;
                }

                //если a > b
                //переставить значения местами
                if (a > b)
                {
                    Swap(ref a, ref b);
                }

                //b и a оба нечетны
                //полученное число теперь четно
                b -= a;

            } while (b != 0);


            //восстановить показатель 2
            return a << shift;

        }


        private static void Swap(ref BigInteger lvalue, ref BigInteger rvalue)
        {
            var tmp = lvalue;
            lvalue = rvalue;
            rvalue = tmp;
        }

    }
}
