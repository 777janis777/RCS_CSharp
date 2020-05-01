using System;

namespace Day3_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileTask();
        }
        static void Task3_2v()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 2; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Task3_3v()
        {
            for (int i = 0; i < 4; i++)
            {
                PrintStars(i);
            }

            for (int i = 2; i >= 0; i--)
            {
                PrintStars(i);
            }


            static void PrintStars(int len)
            {
                for (int j = 0; j <= len; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void WhileTask()
        {
            String choice = "";
            int biggest = Int32.MinValue;
            int smallest = Int32.MaxValue;
            while (choice != "n")
            {
                Console.WriteLine("Ievadiet skaitli!");
                int sk = Convert.ToInt32(Console.ReadLine());
                if (sk > biggest)
                {
                    biggest = sk;
                }

                if (sk < smallest)
                {
                    smallest = sk;
                }

                Console.WriteLine("Vai velatiets turpinat? Rakstat n, ja negribat");
                choice = Console.ReadLine();
                choice = choice.ToLower();

            }

            Console.WriteLine("Lielakais: " + biggest);
            Console.WriteLine("Mazakais: " + smallest);
        }

        static void WhileOption2()
        {

            int biggest = Int32.MinValue;
            int smallest = Int32.MaxValue;
            while (true)
            {
                Console.WriteLine("Ievadiet skaitli!");
                int sk = Convert.ToInt32(Console.ReadLine());
                if (sk > biggest)
                {
                    biggest = sk;
                }

                if (sk < smallest)
                {
                    smallest = sk;
                }

                Console.WriteLine("Vai velatiets turpinat? Rakstat n, ja negribat");
                String choice = Console.ReadLine();

                if (choice == "n")
                {
                    break;
                }

            }

            Console.WriteLine("Lielakais: " + biggest);
            Console.WriteLine("Mazakais: " + smallest);
        }

        static void Test()
        {
            String a = "12";
            String b = "aa";

            int number = 0;

            bool success = Int32.TryParse(b, out number);

            if (success == true)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Parse neizdevas");
            }
        }


    }
}