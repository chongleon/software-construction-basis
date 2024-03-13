using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfArray
{
    class CalculationOfArray
    {
        static void Main(string[] args)
        {
            int[] a1 = {12,16,45,12,75,54,62,30,38,30,

                        29,17,30,54,69,24,12,13,14,15,

                        18,46,23,54,12,36,30,31,32,33,

                        28,36,12,12,12,43,38,12,65,23,

                        14,25,45,68,26,31,12,16,56,65};
            int Max = 0;        //最大值
            int Min = 0;        //最小值
            int Sum = 0;        //元素总和
            double Average = 0; //平均数
            program1 L1 = new program1();
            Max = L1._Max(a1);
            Min = L1._Min(a1, Max);
            Sum = L1._Sum(a1.Length, a1);
            Average = (double)Sum / a1.Length;
            //L1._Mode(a1, out _modeNum, out _mode);
            Console.WriteLine("==========内部实现方法===========\n\n" +
                              "此数组的最大值为：{0}\n" +
                              "此数组的最小值为：{1}\n" +
                              "此数组元素的总和为：{2}\n" +
                              "此数组元素的平均值为：{3}\n\n" +
                              "==========Array自身方法==========\n\n" +
                              "此数组的最大值为：{4}\n" +
                              "此数组的最小值为：{5}\n" +
                              "此数组元素的总和为：{6}\n" +
                              "此数组元素的平均值为：{7}\n\n",
                              Max, Min, Sum, Average, a1.Max(), a1.Min(), a1.Sum(), a1.Average());
        }
    }
    class program1
    {
        public int _Max(int[] array)
        {   //最大值计算
            int x = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (x < array[i]) x = array[i];
                else continue;
            }
            return x;
        }
        public int _Min(int[] array, int x)
        {   //最小值计算
            for (int i = 0; i < array.Length; i++)
            {
                if (x > array[i]) x = array[i];
                else continue;
            }
            return x;
        }
        public int _Sum(int k, int[] array)
        {   //总和计算
            if (k <= 1) return array[0];
            else return array[k - 1] + _Sum(k - 1, array);
        }
    }
}
