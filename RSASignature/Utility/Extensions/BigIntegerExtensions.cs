using System;
using System.Numerics;


namespace RSASignature.Util.Extensions
{
    public static class BigIntegerExtensions
    {

        public static BigInteger Mod(this BigInteger lvalue, BigInteger rvalue)
        {
            return (BigInteger.Abs(lvalue * rvalue) + lvalue) % rvalue;
        }  

        public static bool IsProbablyPrime(this BigInteger value, int witnesses = 10)
        {
            if (value <= 1)
            {
                return false;
            }

            if (witnesses <= 0)
            {
                witnesses = 10;
            }

            var d = value - 1;

            //степень двойки
            var pow = 0;

            //пока d четно
            while ((d & 1) == 0)
            {
                //делим на два
                d >>= 1;
                
                //увеличиваем степень двойки
                pow += 1;
            }

            var random = new Random();

            BigInteger a;

            for (var i = 0; i < witnesses; ++i)
            {
                //выбрать случайное число на отрезке [2, value - 2]
                do
                {
                    a = random.BigIntegerRandom(value);
                }
                while (a < 2 || a >= value - 2);

                //вычислить x
                var x = Utility.ModularExponentiation(a, d, value);

                //если x == 1 или x == value - 1
                if (x == 1 || x == value - 1)
                {
                    //перейти на след итерацию
                    continue;
                }


                for (var r = 1; r < pow; ++r)
                {
                    x = Utility.ModularExponentiation(x, 2, value);

                    //число составное
                    if (x == 1)
                    {
                        return false;
                    }

                    //перейти на следующую итерацию
                    if (x == value - 1)
                    {
                        break;
                    }
                }

                //вернуть составное
                if (x != value - 1)
                {
                    return false;
                }
            }

            //вернуть вероятно простое
            return true;
        }
    }
}
