using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Xml.Linq;


namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Vida" };
            string terim = (cars[0].Substring(0, 1));
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Substring(0, 1) == "V")
                {
                    Console.WriteLine("for loop - " + cars[i]);
                };

            }
            ///////////////////////////////////////////////////////////////
            foreach (string car in cars)
            {
                if (car.StartsWith("V"))
                {
                    Console.WriteLine(car + " V -ile balayir (foreach)");
                }
                else
                {
                    Console.WriteLine(car + " V -ile baslamir (foreach)");
                }
            }

            ///////////Yuxaridaki arrayda 5 reqeminin nece defe tekrarlandigini tapin

            int[] arr = { 99, 2, 55, 8, 55, 3, 5, 20, 20, 21, 21, 211, 21, 3, 5 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    count++;
                };

            }
            Console.WriteLine("5 tekrarlanir - " + Convert.ToString(count) + " defe");

            //////Yuxaridaki arraydaki butun reqemlerin cemini tapin
            ///
            int summ = 0;
            foreach (int Summa in arr)
            {
                summ += Summa;
            }
            Console.WriteLine("Arraylarin cemi " + Convert.ToString(summ));

            ////////////////////3.arrayda tekrar olunan reqemleri artan sira ile duzun
           
            var set = new HashSet<int>();

            HashSet<int> distinctNumbers = new HashSet<int>();
            HashSet<int> duplicateNumbers = new HashSet<int>();
            ArrayList integerKeys = new ArrayList();
            int []arba = { };
            foreach (int number in arr)
            {
                if (!distinctNumbers.Add(number))
                    duplicateNumbers.Add(number);
            }

            foreach (var key in duplicateNumbers)
            {
                if (key is int)
                {
                    integerKeys.Add((int)key);
                }
               
            }

            foreach (var item in duplicateNumbers)
            {        
                arba = (int[])integerKeys.ToArray(typeof(int));           
                Console.WriteLine("tekrarlananlar " + item);
            }


            // Sortirovka
            int temp;
            for (int i = 0; i < arba.Length - 1; i++)
            {
                for (int j = i + 1; j <arba.Length; j++)
                {
                    if (arba[i] < arba[j])
                    {
                        temp = arba[i];
                        arba[i] = arba[j];
                        arba[j] = temp;
                    }
                }
            }

            // Sortirovka
            Console.WriteLine("Sort olunmus coxalandan azalana");
            for (int i = 0; i < arba.Length; i++)
            {
                Console.WriteLine(arba[i]);
            }



            ////////////////////4.arraydaki en boyuk reqemi tapin ve nece defe tekrarlandigini gosterin
            int n =0;
            int m = 0;
            for ( int i=0; i < arr.Length; i++)
            {           
                    if (arr[i] > n)
                    {
                        n = arr[i];                        
                    };
            }
            for (int i=0; i < arr.Length; i++)
            {
                if (n == arr[i])
                {
                    m++;
                }
            }
            Console.WriteLine("En boyuk reqem " + n +" ve "+m+" defe tekrarlanir");

            //////////////5.Random 1 den 10 a qeder reqem generate edin ve sonra arrayda hemin reqemin olub olmamasini yoxlayin
            Random rnd = new Random();
            int value = rnd.Next(1, 10);
            bool exists = false;
            foreach (int ter in arr)
            {
                if (ter == value)
                {
                    exists = true;
                    break;
                }

            }
            if (exists)
            {
                Console.WriteLine(Convert.ToString(value)+" Var");
            }
            else
            {
                Console.WriteLine(Convert.ToString(value) + " Yoxdur");
            }

            /////////////6.Adinizdaki herflerin sayini tapin ve hemin sayin arrayda olub olmamasini yoxlayin Meselen Murad adinda 5 herf var ve 5 arrayda var
            string myname= "Agalar";
            int my = myname.Length;
            bool existname = false;
            foreach (int item in arr)
            {
                if (my == item)
                {
                    existname = true;
                    break;                
                }
            }
            if (existname)
            {
                Console.WriteLine("Adim " + Convert.ToString(myname.Length) + " heriflidir ve arrayda var");
            }
            else
            {
                Console.WriteLine("Adim " + Convert.ToString(myname.Length) + " heriflidir ve arrayda yoxdur");
            }

            ////////////7.arraydaki ilk 3 e bolunende qaliqda 2 alinan reqemi ve hemin reqemin arraydaki indexini tapin
            int a = 0; 
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    a = arr[i];
                    index = i+1;
                    break;
                }
            }
            Console.WriteLine(a + " indexi:" + index);

            ////////////8.rraydaki en boyuk reqemin ilk indexini tapin
            int most_big = 0;
            int most_big_index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > most_big)
                {
                   most_big= arr[i];
                   most_big_index = i+1;
                }
            }
            Console.WriteLine(Convert.ToString(most_big)+" indeksi "+ most_big_index);

            ///////////9.4 reqeminin arrayin hansi indexlerinde oldugunu gosterin
            int four_index = 0;
            int[] newArr = { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                   // four_index = i;
                   // newArr = new int[] { four_index };
                    Console.Write(i+" ");
                }
            }

            foreach (int inde in newArr)
            {
                Console.WriteLine(inde);
            }
            //Console.WriteLine(Convert.ToString(four_index));

            Console.ReadLine();
        }
    }
}
