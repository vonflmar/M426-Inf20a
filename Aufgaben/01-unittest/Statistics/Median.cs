using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Median
    {
        public double calculateMedian(List<int> numbers) {
            if(numbers.Count == 0){
                throw new ArgumentException();
            }

            double medianResult = 0;
            numbers.Sort();
            if((numbers.Count % 2) == 0){
                double firstMedian = numbers[(int)((numbers.Count / 2) + 0.5)];
                double SecondMedian = numbers[(int)((numbers.Count / 2) - 0.5)];
                medianResult = (firstMedian + SecondMedian) / 2;
            } else {
                medianResult = numbers[numbers.Count / 2];
            }

            return medianResult;
        }
    }
}
