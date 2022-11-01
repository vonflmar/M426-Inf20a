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

        public double Divide(double number_1, double number_2)
        {
            return number_1 / number_2;
        }
    }
}
