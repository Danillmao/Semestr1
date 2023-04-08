using LR6;
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equation e = new QuadEquation(0, 20, 0);    //создаем объект класса "кв. уравнение"
            Integrator i1 = new Integrator(e); //создаем интегратор для этого уравнения
            double integrValue = i1.Integrate(10, 30); //вызываем интегрирование на интвервале 10;30
            Console.WriteLine(integrValue);
            Console.WriteLine(integrValue);
            //создаем интегратор для другого уравнения:
            Integrator i2 = new Integrator(new QuadEquation(-3, 0, 2.3));
            integrValue = i2.Integrate(-2, 100);    //вызываем ф-ю интегрирования
            Console.WriteLine(integrValue);
        }
    }
}