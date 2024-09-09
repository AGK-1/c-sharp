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




            ArrayList personslist = new ArrayList();
           
           
            while (true) {
               

                Console.WriteLine(" SECIM EDIN \n a. yeni person daxil et \n s. ada gore axtar \n d. Silin \n w.butun listdeki adlari goster");

                char select = Convert.ToChar(Console.ReadLine());
                if (select == 'a')
            {
                   
                    Console.WriteLine("ad daxil edin");
                string ad = Console.ReadLine();
                Console.WriteLine("soyad daxil edin");
                string soyad = Console.ReadLine();
                Console.WriteLine("ve yas");
                byte yas = Convert.ToByte(Console.ReadLine());
                    object persons = new { name = ad, surname = soyad, age = yas };
                    personslist.Add(persons);

                    //Console.WriteLine(persons.name);
                    //Console.WriteLine($"elave edildi: {persons.name}");
                }
            else if (select == 's')
            {
                Console.WriteLine("axtardiginiz adamin adini daxil edin");
                    string searchh = Console.ReadLine();
                    foreach (dynamic it in personslist)
                {
                    
                    if (it.name == searchh)
                    {
                        Console.WriteLine(it.name + " " + it.surname + " " + it.age);
                           
                    }

                        
                    }
            }
            else if (select == 'd')
            {
                    int idx = 0;
                    string searchh = Console.ReadLine();
                    foreach (dynamic it in personslist)
                {
                   
                  
                    if (searchh== it.name)
                        {
                            idx = it.Count;
                            Console.WriteLine(it.name+" "+it.surname+" "+Convert.ToString(it.IndexOf) );
                           // personslist.Remove(it);
                           // Console.WriteLine("silindi");
                            
                            // Console.WriteLine(index);
                            //personslist.Remove(it[indek]);
                        }
                       
                    }
            }
            else if (select == 'w')
            {
                foreach (dynamic it in personslist)
                {
                    Console.WriteLine(it.name);
                }

            }

        }


            
        }
    }
}
