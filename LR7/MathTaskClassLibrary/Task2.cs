using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Task2
    {
        public  double[] SolveQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Коэффициент не должен быть 0");
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }
            else
            {
                return new double[] { };
            }
        }

    }
}
