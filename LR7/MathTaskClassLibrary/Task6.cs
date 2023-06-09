﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public abstract class Equation
    {
        public abstract double GetValue(double x);
    }
    public class QuadEquation : Equation
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public QuadEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetValue(double x)
        {
            return a * x * x + b * x + c;
        }
    }
    public class Integrator

    {

        private readonly Equation equation;

        /// <summary>

        /// Конструктор класса "интегратор"

        /// </summary>

        /// <param name="equation">интегрируемое уравнение</param>

        public Integrator(Equation equation)

        {

            //проверяем допустимость параметров:

            if (equation == null)
            {

                throw new ArgumentNullException();

            }

            this.equation = equation;

        }

        /// <summary>

        /// Функция интегрирования

        /// </summary>

        /// <param name="x1">левая граница интегрирования</param>

        /// <param name="x2">правая граница интегрирования</param>

        public double Integrate(double x1, double x2)

        {

            //проверяем допустимость параметров:

            if (x1 >= x2)
            {

                throw new ArgumentException("Правая граница интегирования должны быть больше левой!");

            }

            /* для интегирования разобъем исходный отрезок на 100 точек.

            * Считаем значение функции в точке, умножаем на ширину интервала.

            * Площадь полученного прямоугольника приблизительно равна значению интеграла на этом отрезке

            * суммируем значения площадей, получаем значение интеграла на отрезке [X1;X2]*/

            int N = 100000; //количество интервалов разбиения

            //определяем ширину интервала:

            double h = (x2 - x1) / N;

            double sum = 0; //"накопитель" для значения интеграла

            for (int i = 0; i < N; i++)
            {

                sum = sum + equation.GetValue(x1 + i * h) * h;

            }

            return sum;

        }

    }
}
