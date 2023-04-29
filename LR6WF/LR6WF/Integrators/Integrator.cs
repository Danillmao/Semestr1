using LR6WF.Интеграторы;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LR6WF.Form1;

namespace LR6WF
{
    public class Integrator : IntegratorBase
    {
      
        public Integrator() { }

        public override double Integrate(EquationDelegate equation, double x1, double x2, int N = 100)
        {
            
            if (equation != null)
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

                    sum = sum + equation(x1 + i * h) * h;
                }
                return sum;
            }
            else
            {
                return 0;
            }
        }

        public override string MethodName
        {
            get { return "Метод прямоугольников"; }
        }

    }

}

