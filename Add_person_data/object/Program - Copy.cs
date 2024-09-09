using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList books = new ArrayList();
            books.Add(new { ad = "fizika", muellif = "newton", janr = "elm" });
            bool exit = true;
            while (exit)
            {



                Console.WriteLine("1-book add");
                Console.WriteLine("2-book list show");
                Console.WriteLine("3-book delete");
                Console.WriteLine("4-book search");
                Console.WriteLine("5-Update");
                Console.WriteLine("6- exit");

                Console.WriteLine("select option");
                char emeliyyyat = Convert.ToChar(Console.ReadLine());
                switch (emeliyyyat)

                {
                    case '1':
                        Console.WriteLine("Neche kitab daxil etmek isteyirsiz?");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("Add a book name: ");
                            string bookName = Console.ReadLine();
                            Console.Write("Add a book autor: ");
                            string bookAutor = Console.ReadLine();
                            Console.Write("Add a book janr: ");
                            string janr = Console.ReadLine();
                            object book = new { ad = bookName, muellif = bookAutor, janr = janr };
                            books.Add(book);
                            Console.WriteLine((i + 1) + ".book added");
                        }


                        break;

                    case '2':
                        foreach (dynamic item in books)
                        {
                            Console.WriteLine("name:" + item.ad + "\n autor:" + item.muellif + "\n janr: " + item.janr + "\n");
                        }


                        break;
                    case '3':
                        bool find = false;
                        Console.WriteLine("enter book name");
                        string name = Console.ReadLine();
                        foreach (dynamic item in books)
                        {
                            if (item.ad == name)
                            {

                                books.Remove(item);
                                find = true;
                                Console.WriteLine("Book Deleted.");
                                break;
                            }


                        }
                        if (!find)
                        {
                            Console.WriteLine("Not found");
                        }
                        break;
                    case '4':
                        bool tapildi = false;
                        Console.WriteLine("Book search");
                        string search_name = Console.ReadLine();
                        foreach (dynamic item in books)
                        {
                            if (search_name == item.ad)
                            {
                                tapildi = true;
                                Console.WriteLine("name:" + item.ad + "\n autor:" + item.muellif + "\n janr: " + item.janr + "\n");
                                break;
                            }
                        }
                        if (!tapildi)
                        {
                            Console.WriteLine("not found");
                        }

                        break;


                    //case '5':
                    //    bool boolFound = false;
                    //    Console.WriteLine("Which book do you want update");
                    //    string searchName = Console.ReadLine();
                    //    foreach (dynamic item in books)
                    //    {
                    //      if(item.ad == searchName)
                    //        {
                    //            Console.WriteLine("Please enter new name");
                    //            string newName= Console.ReadLine();
                    //            item.ad = newName;
                    //            Console.WriteLine("new name" + item.ad);
                    //            boolFound = true;
                    //            break;
                    //        }

                    //    }
                    //    if (!boolFound)
                    //    {
                    //        Console.WriteLine("not found");
                    //    }



                    //    break;
                    case '6':
                        exit = false;
                        Console.WriteLine("Exited");
                        break;




                }
            }
        }
    }
}
