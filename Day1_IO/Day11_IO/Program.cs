using System;

namespace Day11_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izvade
            Console.WriteLine("Hello World!");
            Console.WriteLine("Mani sauc Jānis");
            //-----

            //int - vesles skaitlis
            //float, double - skaitlis ar komatu
            //char - viens simbols
            //string - simbolu virkne
            //bool - true vai false
            
            int a; //mainiga deklaracija  -daram 1x
            a = 7; //mainiga definicaja - daram cik reižu gribam
            //int c;
            //c = 5;

            int c = 5; //deklaracija + definicija

            int result = a + c;

            Console.WriteLine(c + result);

            String b;
            b = "456464sdddss";

            Console.WriteLine(b);

            a = 99;
            result = a + c;
            Console.WriteLine(result);
            
            Console.WriteLine("Ievadiet simbolu virkni");

            String ievade = Console.ReadLine();

            Console.WriteLine(ievade);
            String combined = "   " + ievade + ", hello world!";

            Console.WriteLine(combined);

            a = 3;

            b = 9;

            c = b - a;

            Console.WriteLine(a);

            Console.WriteLine("b= " + a);


        }
    }
}
