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
    }
}