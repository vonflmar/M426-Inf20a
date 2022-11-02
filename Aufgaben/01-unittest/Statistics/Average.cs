using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            int sum = 0;
            double mean = 0.0;

            // if(numbers.count == 0){
            //     throw new ArgumentException;
            // }

            foreach (int number in numbers)
            {
                sum += number;
            }

            

            mean = (double)sum / numbers.Count;
            return mean;
        }
        public double Median(List<int> numbers){
            int median = 0;
            int halfAmount = numbers.Count / 2;

            for(int i = 0; i < halfAmount; i++){
                median = numbers[i];
            }

            return median;
        }
    }
}
