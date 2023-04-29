using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LR6WF.Form1;

namespace LR6WF.Интеграторы
{
    public abstract class IntegratorBase
    {
        public abstract double Integrate(EquationDelegate equation, double x1, double x2, int N);

        public abstract string MethodName { get; }
    }

}
