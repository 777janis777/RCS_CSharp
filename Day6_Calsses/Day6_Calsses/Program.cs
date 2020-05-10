using System;
using System.Threading.Tasks;

namespace Day6_Calsses
{
    class Program
    {
        static void Main(string[] args)
        {
            //skaitļu ievade....
            Tasks.SetA(8);
            Tasks.SetB(12);

            Console.WriteLine(Tasks.GetA() + Tasks.GetB());
        }

        static void sample()
        {
            //klases nosaukums un metodes nosaukums
            Example.Test();

            int a = Example.ReturnPublic();
            Console.WriteLine(a);

            Example.ParamPublic(5, 99);
        }
        static void task1()
        {
            Console.WriteLine("Ievadiet skaitli!");
            int c = Convert.ToInt32(Console.ReadLine());
            Tasks.Stars(c);
        }
    }
}
