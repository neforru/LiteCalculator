using System;
using System.Reflection;

namespace Name

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число1 - ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак(+,-,*,/) - ");
            char znak = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите число2 - ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;


            if (znak == '+') 
            {
                result = num1 + num2;
            }
            else if (znak == '-')
            {
                result = num1 - num2;
            }
            else if (znak == '*')
            {
                result = num1 * num2;
            }
            else if (znak == '/')
            {
                result = num1 / num2;
            }
            Console.WriteLine($"У вас получилось : {num1} {znak} {num2} = {result}");

            Console.ReadKey();
        }
    }
}
