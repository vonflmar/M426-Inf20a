﻿using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB) {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend) {
            return minuend - subtrahend;
        }

        public int multiply(int factorA, int factorB) {
            return factorA * factorB;
        }

        public int divide(int dividend, int divisor) {
            int result = 0;
            try{
                result = dividend / divisor;
            } catch(DivideByZeroException e) {
                throw new ArgumentException();
            }
            return result;
        }
    }
}
