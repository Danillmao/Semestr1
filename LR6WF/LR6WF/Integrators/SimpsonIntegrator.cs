using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6WF.Интеграторы
{
    public class SimpsonIntegrator : IntegratorBase
    {
        private readonly Equation equation;

        public SimpsonIntegrator(Equation equation)
        {
            if (equation == null)
            {
                throw new ArgumentNullException();
            }
            this.equation = equation;
        }

        public SimpsonIntegrator() { }

        public override double Integrate(Equation equation, double x1, double x2, int N = 100)
        {
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница интегрирования должны быть больше левой!");
            }

          
            double h = (x2 - x1) / N;
            double sum = equation.GetValue(x1) + equation.GetValue(x2);

            for (int i = 1; i < N; i += 2)
            {
                double xi = x1 + i * h;
                sum += 4 * equation.GetValue(xi);
            }

            for (int i = 2; i < N; i += 2)
            {
                double xi = x1 + i * h;
                sum += 2 * equation.GetValue(xi);
            }

            return sum * h / 3.0;
        }

        public override string MethodName
        {
            get { return "Метод парабол (метод Симпсона)"; }
        }
    }

}
