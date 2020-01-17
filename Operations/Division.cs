using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public static class Division
    {
        public static int Quotient(int a, int b)
        {
            return a / b;



        }

        public static double Quotient(double a, double b)
        {
            return a / b;
        }
        public static double Quotient(double[] arrayA)
        {
            double c = arrayA[0];

            foreach (double a in arrayA)
            {
                c = Quotient(c, a);
            }
            double d = c * arrayA[0];
            return d;
        }

    }
}
