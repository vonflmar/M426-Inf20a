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
            double median = 0;
            int halfAmount = numbers.Count / 2;

            if(numbers.Count == 0){
                throw new ArgumentException();
            }
            else if(halfAmount % 2 == 0){
                for(int i = 0; i < halfAmount; i++){
                    double first = numbers[i];
                    double second = numbers[i + 1];
                    median = (first + second) / 2;
                }
                return median;
            }
            else{
                for(int i = 0; i < halfAmount; i++){
                    median = numbers[i];
                }
                return median;
            }
        }
    }
}
