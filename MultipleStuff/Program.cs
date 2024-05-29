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

}
