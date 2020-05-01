using System;

namespace Day5_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            FiveNumbers();
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

            for (int i=0; i < num.Length; i++)
            {
                num[i] = int.Parse (Console.ReadLine());

                sum += num[i];
            }
            Console.WriteLine(sum);
            
        }
    }
}
