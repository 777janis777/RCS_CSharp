using System;

namespace Day5_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3();
        }

        static void ArraySample()
        {
            int[] a = new int[5];

            a[0] = 1;
            a[1] = 5;
            a[2] = 8;
            a[3] = 7;
            a[4] = 99;

            Console.WriteLine(a[0]);

            int sum = a[0] + a[4];
            Console.WriteLine(sum);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i] + "");
            }
        }

        static void FiveNumbers()
        {
            int[] num = new int[5];
            int sum = 0;

            Console.WriteLine("Ievadiet piecus skaitļus");

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

                sum += num[i];
            }
            Console.WriteLine("Šo skaitļu summa ir " + sum);
        }

        static void FiveNumbers1()
        {
            int[] num = new int[5];
            int sum = 0;

            // 1. punkts
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            // 2. punkts
            //for (int i = 0; i < a.Length; i++)
            //{
            //    sum = sum + a[i];
            //}

            Console.WriteLine("Summa: " + sum);
        }

        static void Task2()
        {
            int[] a = { 1, 6, 7, 12, 14, 9 };
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }

            Console.WriteLine(sum / a.Length);
        }

        static void Task3()
        {
            int[] num = new int[10];
            int Min = 1;
            int Max = 11;

            Random randnum = new Random();

            for (int i = 1; i < num.Length; i++)
            {
                num[i] = randnum.Next(Min, Max);
            }

            foreach (int j in randnum)
            {
                Console.WriteLine("")
            }


        }
    }
}


