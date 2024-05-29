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
    }
}