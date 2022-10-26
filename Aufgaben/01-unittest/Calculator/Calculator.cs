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

        public int Multiply(int factorA, int factorB)
        {
            return factorA * factorB;
        }

        public double Division(double valueA, double valueB)
        {
            return valueA / valueB;
        }
    }
}
