// See https://aka.ms/new-console-template for more information
//using System;
class Program {
    static void Main(String[] args)
    {
        Console.WriteLine("请输入第一个参数。");
        int num1 = int.Parse(Console.ReadLine());
        //String number1=Console.ReadLine();
        //int num1 = int.Parse(number1);
        Console.WriteLine("请输入第二个参数。");
        String number2 = Console.ReadLine();
        int num2 = int.Parse(number2);
        Console.WriteLine("请输入“+”或“-”或“*”或“/”。");
        String symbol = Console.ReadLine();
        int result = 0;
        if (symbol == "+") result = num1 + num2;
        else if (symbol == "-") result = num1 - num2;
        else if (symbol == "*") result = num1 * num2;
        else if (symbol == "/") result = num1 / num2;
        Console.WriteLine("结果是：");
        Console.WriteLine(result);
        Console.ReadKey();
    }
 }

