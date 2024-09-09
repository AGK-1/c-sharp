using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ref_and__value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////value type
            {
                int a = 5;
                int b = a; // Копируем значение переменной a в переменную b

                Console.WriteLine("Before modification:");
                Console.WriteLine("a: " + a); // Выводим значение переменной a
                Console.WriteLine("b: " + b); // Выводим значение переменной b

                // Модифицируем переменную b
                b = 10;

                Console.WriteLine("\nAfter modification:");
                Console.WriteLine("a: " + a); // Значение переменной a осталось неизменным (5)
                Console.WriteLine("b: " + b); // Значение переменной b изменено на 10
            }
            //////////////////////////////////////referans typr
            ///
            MyClass a = new MyClass();
            a.Value = 5;
            MyClass b = a; // Копируем ссылку на объект a в переменную b

            Console.WriteLine("Before modification:");
            Console.WriteLine("a.Value: " + a.Value); // Выводим значение объекта, на который ссылается переменная a
            Console.WriteLine("b.Value: " + b.Value); // Выводим значение объекта, на который ссылается переменная b

            // Модифицируем значение объекта, на который ссылается переменная b
            b.Value = 10;

            Console.WriteLine("\nAfter modification:");
            Console.WriteLine("a.Value: " + a.Value); // Значение объекта, на который ссылается переменная a, изменено на 10
            Console.WriteLine("b.Value: " + b.Value); // Значение объекта, 

        }
        class MyClass
        {
            public int Value { get; set; }
        }
    }
}
