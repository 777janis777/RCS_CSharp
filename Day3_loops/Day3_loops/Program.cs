using System;

namespace Day3_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskMD();
        }

        static void ForExample()
        {
            for (int i = 0; i < 10; i++)//i++ , i = i + 1
            {
                Console.WriteLine(i);
                Console.WriteLine(1);
                Console.WriteLine("-------");
            }

            Console.WriteLine("-------Ejam atpakal--------");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
                Console.WriteLine(1);
                Console.WriteLine("-------");
            }

        }

        static void Task1()
        {
            int biggest = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                int nr = Convert.ToInt32(Console.ReadLine());

                if (biggest < nr)
                {
                    biggest = nr;
                }
            }

            Console.WriteLine("Lielakais skaitlis ir " + biggest);
        }

        static void Task2()
        {
            int pos = 0;
            int neg = 0;
            int zero = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                int nr = Convert.ToInt32(Console.ReadLine());

                if (nr > 0)
                {
                    pos++;
                    //pos = pos + 1
                }
                else if (nr < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine("Pozitivas: " + pos);
            Console.WriteLine("Negativas: " + neg);
            Console.WriteLine("Nulles: " + zero);

        }

        static void Task3()
        {
            String zvaigznes = "";
            //String zvaigznes1 = "*****";

            for (int i = 0; i < 4; i++)
            {
                zvaigznes = zvaigznes + "*";
                Console.WriteLine(zvaigznes);
            }
            //for (int i = 2; i >= 3; i++)
            //{
            //    zvaigznes = zvaigznes + "*";
            //    Console.WriteLine(zvaigznes);
               
            //}
           

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
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 2; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void TaskMD() 
        {
            int biggest = 0;
            int smallest = int.MinValue;

            int i = 2;
            while (i < 5) 
            {
                Console.WriteLine("Ievadiet skaitli!");
                i++;
                int nr = Convert.ToInt32(Console.ReadLine());

                if (biggest < nr) 
                {
                    biggest = nr;
                }
                else if (smallest == nr)
                {
                    smallest = nr;
                }
            }
            Console.WriteLine("Lielākais skaitlis ir " + biggest);
            Console.WriteLine("Mazākais skaitlis ir " + smallest);

        }

    }
}