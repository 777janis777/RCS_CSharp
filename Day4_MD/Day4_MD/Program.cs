using System;

namespace Day4_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGuessing();
        }
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
       
        //Patstāvīgi atrast kā ģenerēt random skaitli.Lietotājs cenšas uzminēt skaitli piecas reizes, ja neizdodas, tad zaudē, ja izdodas, tad uzvar.
        static void NumberGuessing()
        {
            Random r = new Random();

            int winNum = r.Next(1, 101);

            bool win = false;

            do
            {
                Console.WriteLine("Uzminiet skaitli no 1 līdz 100");
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

