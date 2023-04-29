using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LR6WF.Form1;

namespace LR6WF.Интеграторы
{
    public class SimpsonIntegrator : IntegratorBase
    {
       
        public SimpsonIntegrator() { }

        public override double Integrate(EquationDelegate equation, double x1, double x2, int N = 100)
        {
           
            if (equation != null)
            {
                if (x1 >= x2)
                {
                    throw new ArgumentException("Правая граница интегрирования должны быть больше левой!");
                }
                double h = (x2 - x1) / N;
                double sum = equation(x1) + equation(x2);

                for (int i = 1; i < N; i += 2)
                {
                    double xi = x1 + i * h;
                    sum += 4 * equation(xi);
                }

                for (int i = 2; i < N; i += 2)
                {
                    double xi = x1 + i * h;
                    sum += 2 * equation(xi);
                }

                return sum * h / 3.0;
            }
            else
            {
                return 0;
            }
          
        }

        public override string MethodName
        {
            get { return "Метод парабол (метод Симпсона)"; }
        }
    }

}
