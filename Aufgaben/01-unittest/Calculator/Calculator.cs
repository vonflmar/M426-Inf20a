using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }
        
        public double Multiply(double faktor_1, double faktor_2)
        {
            return faktor_1 * faktor_2;
        }

        public double Divide(double divisor_1, double divisor_2)
        {
            if (divisor_1 is 0 || divisor_2 is 0)
            {
                throw new ArgumentException();
            }

            return divisor_1 / divisor_2;
        }
    }
}
