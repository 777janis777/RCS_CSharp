using System;

namespace Day4_LoopsExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGuessing();
        }

        static void WhileExample()
        {
            String choice = "n";

            while (choice != "n")
            {
                Console.WriteLine("ievadiet tekstu!");
                choice = Console.ReadLine();

                Console.WriteLine("yay");
            }


            do
            {
                Console.WriteLine("ievadiet tekstu!");
                choice = Console.ReadLine();

                Console.WriteLine("yay");
            } while (choice != "n");
        }

        static void TestParse()
        {
            int sk;

            try
            {
                Console.WriteLine("Ievadiet skaitli");
                sk = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Success " + sk);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("ievadijat simbolu, ir jaievada skaitlis!");

                TestParse();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                sk = Int32.MaxValue;
            }
        }
        //  šeit sākas mājas darbs
        //  3) Izvadīt šādu piramīdu, izmantojot for ciklu.
        //  1
        //  2 3
        //  4 5 6
        //  7 8 9 10

        static void PrintNumber()
        {

            int i, j, rows = 4, k = 1;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", k++);
                Console.Write("\n");
            }
        }
        //  2) Izveidot metodi, kas padod divus int tipa skaitļus kā parametrus- bāzi un pakāpi.Metode atgriež kāpinājumu.
        //  Piemērs, padod 2 un 3, tātad 2^3 = 2* *2 * 2 = 8

        static void Cube()
        {
            //Console.WriteLine(a + b);
        }

        static void Param(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        //Patstāvīgi atrast kā ģenerēt random skaitli.Lietotājs cenšas uzminēt skaitli piecas reizes, ja neizdodas, tad zaudē, ja izdodas, tad uzvar.
        static void NumberGuessing()
        {
            Random r = new Random();

            int winNum = r.Next(0, 10);

            bool win = false;

            do
            {
                Console.WriteLine("Uzminiet skaitli no 0 līdz 10");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Par lielu! Mini mazāku...");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Par mazu! Mini lielāku...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("Tu uzminēji!");
                    win = true;
                }

            } while (win == false);

           
        }
    }
}