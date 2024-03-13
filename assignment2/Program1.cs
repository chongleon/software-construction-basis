// See https://aka.ms/new-console-template for more information
//用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，
//先去掉2的倍数，再去掉3的倍数，再去掉4的倍数，
//以此类推...最后剩下的就是素数

namespace PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            for(int i = 2; i <= 100; i++)
            {
                bool flag = true;
                for(int j = 2; i > j; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }                
                }
                if (flag)
                {
                    Console.WriteLine(i + "是素数");
                }
            }
        }
    }
}