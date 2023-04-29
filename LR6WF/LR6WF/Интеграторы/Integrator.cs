using LR6WF.Интеграторы;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6WF
{
    public class Integrator : IntegratorBase
    {
        private readonly Equation equation;

        public Integrator(Equation equation)
        {
            if (equation == null)
            {
                throw new ArgumentNullException();
            }
            this.equation = equation;
        }

        public Integrator() { }

        public override double Integrate(double x1, double x2, int N = 100)
        {
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница интегрирования должны быть больше левой!");
            }

            ;
            double h = (x2 - x1) / N;
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum = sum + equation.GetValue(x1 + i * h) * h;
            }
            return sum;
        }

        public override string MethodName
        {
            get { return "Метод прямоугольников"; }
        }

    }

}

