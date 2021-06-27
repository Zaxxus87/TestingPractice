using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Practice
{
    public class ArrayFun
    {
        private int[] ray;

        public ArrayFun(int[] r)
        {
            ray = r;
        }

        public int SumEvens()
        {
            return ray.Where(x => x % 2 == 0).Sum();
          
        }

        public int SumPositive()
        {
            return ray.Where(x => x >= 0).Sum();
        }
    }
}
