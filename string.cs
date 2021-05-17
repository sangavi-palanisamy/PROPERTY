using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class example
    {
        public int a = 10, b = 30, c;
         public void run()
           {
               string names = "Suresh Dasari";
               string location = "Hyderabad";

               Console.WriteLine("Name: {0}, Location: {1}", names, location);
               string name = "Suresh Dasari";
               for (int i = 0; i < name.Length; i++)
               {
                   Console.Write(name[i]);
               }

           }
        public  void main()
        {
            c = a - b;
            Console.WriteLine(c);
        }
        public  void load()
        {
            string msg = "Suresh.Rohini.Trishika";
            string[] strarr = msg.Split('.');
            for (int i = 0; i < strarr.Length; i++)
            {
                Console.WriteLine(strarr[i]);
            }
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();

        }


    }
     class Program
    {

        static void Main(string[] args)
        {
            example ex = new example();
            ex.load();
            ex.main();
            Console.ReadKey();
        }
    }
}
