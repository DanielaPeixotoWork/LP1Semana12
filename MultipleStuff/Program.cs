using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleStuff
{
    class SuperList : List<double>
    {
        public void GetMinMax1(out double min, out double max)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            min = this.Min();
            max = this.Max();
        }

        public class MinMax
        {
            public double Min { get; set; }
            public double Max { get; set; }
        }

        public MinMax GetMinMax2()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            return new MinMax { Min = this.Min(), Max = this.Max() };
        }

        public (double Min, double Max) GetMinMax3()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            return (this.Min(), this.Max());
        }

        public (double minimum, double maximum) GetMinMax4()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            return (minimum: this.Min(), maximum: this.Max());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SuperList numbers = new SuperList { 3.5, 2.1, 7.4, 1.9, 6.3 };

            numbers.GetMinMax1(out double min1, out double max1);
            Console.WriteLine($"GetMinMax1 -> Min: {min1}, Max: {max1}");

            var minMax2 = numbers.GetMinMax2();
            Console.WriteLine($"GetMinMax2 -> Min: {minMax2.Min}, Max: {minMax2.Max}");

            var (min3, max3) = numbers.GetMinMax3();
            Console.WriteLine($"GetMinMax3 -> Min: {min3}, Max: {max3}");

            var (minimum4, maximum4) = numbers.GetMinMax4();
            Console.WriteLine($"GetMinMax4 -> Min: {minimum4}, Max: {maximum4}");
        }
    }
}