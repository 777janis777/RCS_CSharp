using System;

namespace Day2_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();



        }

        static void Task2()
        {
            if (IsEven(5)) //if(IsEven(5) == true) - tas pats
            {
                Console.WriteLine("Para");
            }
            else
            {
                Console.WriteLine("Nepara");
            }
        }

        static bool IsEven(int sk)
        {
            if (sk % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Task1()
        {
            Console.WriteLine(BiggestNumber(3, 5));
            Console.WriteLine(BiggestNumber(199, 8));

            Console.WriteLine("Ievadiet skaitli!");
            String input = Console.ReadLine();
            int sk1 = Convert.ToInt32(input);

            Console.WriteLine("Ievadiet 2. skaitli!");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(BiggestNumber(sk1, sk2));
        }

        static int BiggestNumber(int a, int b)
        {

            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
    }
}