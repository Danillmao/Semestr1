using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6WF
{
    internal class Cequation : Equation
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;
        public Cequation(double a, double b)
        {
            this.a = a;
            this.b = b;
            
        }
        public override double GetValue(double x)
        {
            return x * x * Math.Cos(x - a) / b;
        }
    }
}
