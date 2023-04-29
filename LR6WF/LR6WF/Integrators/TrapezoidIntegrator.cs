using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6WF.Интеграторы
{
    public class TrapezoidalIntegrator : IntegratorBase
    {
        private readonly Equation equation;

        public TrapezoidalIntegrator(Equation equation)
        {
            if (equation == null)
            {
                throw new ArgumentNullException();
            }
            this.equation = equation;
        }

        public TrapezoidalIntegrator() { }

        public override double Integrate(Equation equation, double x1, double x2, int N = 100)
        {
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница интегрирования должны быть больше левой!");
            }

           
            double h = (x2 - x1) / N;
            double sum = 0;
            for (int i = 1; i < N; i++)
            {
                double xi = x1 + i * h;
                sum += equation.GetValue(xi);
            }
            sum += 0.5 * (equation.GetValue(x1) + equation.GetValue(x2));
            return sum * h;
        }

        public override string MethodName
        {
            get { return "Метод трапеций"; }
        }
    }

}
