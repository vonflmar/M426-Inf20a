using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            int sum = 0;
            double mean = 0.0;

            if (numbers.Count == 0) throw new ArgumentException();

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }

        public double Median(int[] numbers)
        {
            if (numbers.Length == 0) throw new ArgumentException();

            Array.Sort(numbers);

            if (numbers.Length % 2 != 0)
            {
                int mid = (numbers.Length - 1) / 2;
                return numbers[mid];
            }

            int value1 = numbers.Length / 2;
            int value2 = numbers.Length / 2 - 1;
            return this.Mean(new List<int> { numbers[value1], numbers[value2] }); 
        }
    }
}
