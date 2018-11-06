using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           while(true)
            {
                double x;
                double y;
                string _operator;
                Console.WriteLine("Введите N для нового расчета или Q для выхода: ");
                string s1 = Console.ReadLine();
                if(s1 == "Q")
                { Console.WriteLine("Выйти?"); }
                if (s1 == "N")
                { Console.WriteLine("Введите первое число"); }
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите арифметическое действие: ");
                _operator = Console.ReadLine();
                Console.WriteLine("Введите второе число: ");
                y = Convert.ToDouble(Console.ReadLine());
                switch (_operator)
                {
                    case "Q":
                        return;
                    case "N":
                        continue;
                    case "+":
                        Console.WriteLine(x + y);
                        break;
                    case "-":
                        Console.WriteLine(x - y);
                        break;
                    case "/":
                        Console.WriteLine(x / y);
                        break;
                    case "*":
                        Console.WriteLine(x * y);
                        break;
                }
            }
        }
    }
}
