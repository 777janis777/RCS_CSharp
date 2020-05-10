using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_objects
{
    class Trijsturis
    {
        public int mala1;
        public int mala2;
        public int mala3;


        public Trijsturis(int mala1, int mala2, int mala3)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
            
        }

        public void Print()
        {
            Console.WriteLine(mala1 + " " + mala2 + " " + mala3);

        }
    }
}
