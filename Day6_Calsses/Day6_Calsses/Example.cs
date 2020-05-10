using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Calsses
{
    class Example
    {
        private static int a = 0; //globālie mainīgie
        private static int b = 0; //globālie mainīgie

        public static void Test()
        {
            Console.WriteLine("Šī ir testa metode");
            PrivateTest();
            a = 3;
            b = a + 8;
        }

        private static void PrivateTest()
        {
            Console.WriteLine("Šī ir privāta testa metode");
        }

        public static int ReturnPublic()
        {
            return 3 + 2;
        }

        public static void ParamPublic(int a, int b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a + Example.a); //ar Example.a tiek norādīts, kad piekļūsatm globālam mainīgam private static int a = 0;
            //šajā piemērā sanāk 5 + 3
        }
           
    }
}
