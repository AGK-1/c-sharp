using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_calculator_and_class_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char chr;

            while (true)
            {

                Console.WriteLine("Enter first number:");
                double first = Convert.ToDouble(Console.ReadLine());
                chr = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                double second = Convert.ToDouble(Console.ReadLine());
                switch (chr)
                {
                    case '+':
                        Console.WriteLine("Cavab: " + Convert.ToDouble(first + second));
                        break;
                    case '-':
                        Console.WriteLine("Cavab: " + Convert.ToDouble(first - second));
                        break;
                    case '*':
                        Console.WriteLine("Cavab: " + Convert.ToDouble(first * second));
                        break;
                    case '/':
                        Console.WriteLine("Cavab: " + Convert.ToDouble(first / second));
                        break;

                }
            }


        }

    }
}
