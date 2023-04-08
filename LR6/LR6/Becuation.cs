using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    internal class Becuation : Equation
    {
        private readonly double a;

        public Becuation(double a)
        {
            this.a = a;
         
        }
        public override double GetValue(double x)
        {
            return System.Math.Sin(a*x)/x;
        }
    }
}
