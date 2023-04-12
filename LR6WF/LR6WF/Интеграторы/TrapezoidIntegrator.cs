using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6WF.Интеграторы
{
    internal class TrapezoidIntegrator
    {
        private readonly Equation equation;
        public TrapezoidIntegrator(Equation equation)
        {

            if (equation == null)
            {
                throw new ArgumentNullException();
            }
            this.equation = equation;
        }

        public static double Integrate(Func<double, double> f, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = 0;
            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                sum += f(x);
            }
            return h * ((f(a) + f(b)) / 2 + sum);
        }
    }
}
