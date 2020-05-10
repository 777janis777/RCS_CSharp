using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Day6_Calsses
{
    class Tasks
    {

        //private static int a = 0;
        //private static int b = 0;
        //Divi lauki klasē Tasks.
        //1) Jānomaina a un b vērtības uz cilvēka ievadi, jāizvada abu skaitļu summa.
        //2) Nedrīkst mainīt to, ka mainīgie ir private.
        //3) Nedrīkst ievadi/izvadi veikt no Tasks klases.

        private static int a = 0;
        private static int b = 0;

        public static void SetA(int localA)
        {
            if (localA < 0)
            {
                localA = 0;
            }
            a = localA;
        }
        public static void SetB(int localB)
        {
            b = localB;
        }

        public static int GetA()
        {
            return a;
        }
        public static int GetB()
        {
            return b;
        }

            //1) Uztaisīt klasi Tasks.
            //2) Klasē jābūt vienai metodei ar parametru(int tipa skaitlis)
            //Piemērs metode(int a)
            //pieņemsim, ka a vērtība ir 6;
            //        tad izvadei ir jābūt
            //*
            //**
            //***
            //****
            //*****
            //******
        public static void Stars(int count)
        {
            String stars = "";
            for (int i = 0; i < count; i++)
            {
                stars = stars + "*"; // var rakstīt arī stars += "*";
                Console.WriteLine(stars);
            }

        }

    }
}
