// See https://aka.ms/new-console-template for more information
//编写程序输出用户指定数据的所有素数因子。
using System.Numerics;
using System;
namespace PrimeFactor
{
    class PrimeFactor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个正整数。");
            String num = Console.ReadLine();
            double n = double.Parse(num);
            //double m = Math.Pow(n, 0.5);
            Console.WriteLine("其素数因数如下:");
            for (int i = 2; i <= n; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
