using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace memory_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num =0;
            List<int> myNum = new List<int>();
            List<int> myNum2 = new List<int>();
            //int[] myNum = { 0, 0, 0, 0 };
            //int[] myNum2 = { 0, 0, 0, 0 };
            char f ;
            while (true)
            {
                myNum.Clear();
                myNum2.Clear();
                Console.WriteLine("baslamaq ucun y ");
                f = Convert.ToChar(Console.ReadLine());
                if (f == 'y')
                {

                    for (int i = 0; i < 3; i++)
                    {
                        num = rnd.Next(1000);                     
                        //myNum[i] = num;
                        myNum.Add(num);
                    }

                    for (int i = 0; i < myNum.Count; i++)
                    {
                        Console.WriteLine(myNum[i]);
                    }

                    for(int i = 10;i>0; i--)
                    {
                        Thread.Sleep(1000);
                        Console.Write("\r{0}  saniye qaldi ", i);                       
                    }
                    Console.Clear();


                    //Thread.Sleep(10000);



                    for (int i = 0; i < myNum.Count; i++) {
                        myNum2.Add(Convert.ToInt32(Console.ReadLine()));
                    };

                    bool isEqual = Enumerable.SequenceEqual(myNum, myNum2);
                    if (isEqual)
                    {
                        Console.WriteLine("Duzdur...");
                       
                    }
                    else
                    {
                        Console.WriteLine("Sehvdir!");

                    }
                }
                else { Console.WriteLine("duz deyil"); }
            }
        }

    }

}
