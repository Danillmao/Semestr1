using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Task5
    {
        public int SumOfNubers(string input)
        {
           
            int sum = 0;
            foreach (char c in input)
            {
                sum += (int)Char.GetNumericValue(c);
            }
            return sum;
        }
    }
}
