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
			int a = 5;
			int b = a; // Копируем значение переменной a в переменную b
			Console.WriteLine("Value type------------------------------------");

			Console.WriteLine("Before modification:");
			Console.WriteLine("a: " + a); // 5
			Console.WriteLine("b: " + b); // 5

			// Модифицируем переменную b
			b = 15;

			Console.WriteLine("\nAfter modification:");
			Console.WriteLine("a: " + a); // Значение переменной a осталось неизменным (5)
			Console.WriteLine("b: " + b); // Значение переменной b изменено на 10

			Console.WriteLine("Referance type------------------------------------");

			MyClass aa = new MyClass();
			aa.Value = 5;
			MyClass bb = aa; // Копируем ссылку на объект a в переменную b

			Console.WriteLine("Before modification:");
			Console.WriteLine("a.Value: " + aa.Value); // 5
			Console.WriteLine("b.Value: " + bb.Value); // 5

			// Модифицируем значение объекта, на который ссылается переменная b
			bb.Value = 55;
				//Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nAfter modification:");
			Console.WriteLine("a.Value: " + aa.Value); // Значение объекта изменено на 10
			Console.WriteLine("b.Value: " + bb.Value); // Значение объекта изменено на 10
		}

        class MyClass
        {
            public int Value { get; set; }
        }
    }
}
