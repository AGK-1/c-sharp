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
                Console.WriteLine("Calculating ...");
                int num1 = Convert.ToInt32(Console.ReadLine());
                char oper = Convert.ToChar(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                caculator(num1, num2, oper);

            }

        }
        /////////////method////////////////////

        public static void caculator(int a, int b, char chr)
        {
            switch (chr)
            {
                case '+':
                    Console.WriteLine("Cavab: " + Convert.ToInt32(a + b));
                    break;
                case '-':
                    Console.WriteLine("Cavab: " + Convert.ToInt32(a - b));
                    break;
                case '*':
                    Console.WriteLine("Cavab: " + Convert.ToInt32(a * b));
                    break;
                case '/':
                    Console.WriteLine("Cavab: " + Convert.ToInt32(a / b));
                    break;

            }


        }

    }
}
