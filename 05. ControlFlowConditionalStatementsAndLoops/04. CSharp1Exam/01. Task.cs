namespace CSharpOne
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double sum = 0;
            double max = 0;
            double min = 0;

            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            sum = (a + b + c) / 3;

            if (a > b)
            {
                min = b;
            }
            else
            {
                min = a;
            }

            if (c < min)
            {
                min = c;
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F2}", sum);
        }
    }
}