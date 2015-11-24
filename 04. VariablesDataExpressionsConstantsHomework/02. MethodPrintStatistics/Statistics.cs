namespace MethodPrintStatistics
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] collection)
        {
            double maxValue = collection[0];
            double minValue = collection[0];
            double elementsSum = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] > maxValue)
                {
                    maxValue = collection[i];
                }

                if (collection[i] < maxValue)
                {
                    maxValue = collection[i];
                }

                elementsSum += collection[i];
            }

            PrintMax(maxValue);
            PrintMin(minValue);
            PrintAvg(elementsSum / collection.Length);
        }

        private void PrintMax(double max)
        {
            Console.WriteLine("The greatest number from the array is {0}.", max);
        }

        private void PrintMin(double min)
        {
            Console.WriteLine("The smallest number from the array is {0}", min);
        }

        private void PrintAvg(double average)
        {
            Console.WriteLine("The average of the numbers in the array is {0} ", average);
        }
    }
}
