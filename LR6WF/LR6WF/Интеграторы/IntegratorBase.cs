using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6WF.Интеграторы
{
    public abstract class IntegratorBase
    {
        public abstract double Integrate(double x1, double x2, int N);

        public abstract string MethodName { get; }
    }

}
