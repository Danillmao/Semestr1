using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LR6WF.Form1;

namespace LR6WF.Интеграторы
{
    public class TrapezoidalIntegrator : IntegratorBase
    {
        public override double Integrate(EquationDelegate equation, double x1, double x2, int N = 100)
        {
            if(equation != null)
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
                    sum += equation(xi);
                }
                sum += 0.5 * (equation(x1) + equation(x2));
                return sum * h;
            }
            else
            {
                return 0;
            }
        }

        public override string MethodName
        {
            get { return "Метод Симпсона"; }
        }
    }

}
