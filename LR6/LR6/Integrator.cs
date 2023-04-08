using LR6;

public class Integrator
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
   
    public double Integrate(double x1, double x2)
    {
     
        if (x1 >= x2)
        {
            throw new ArgumentException("Правая граница интегирования должны быть больше левой!");
        }
        
        int N = 100;    
        double h = (x2 - x1) / N;
        double sum = 0; 
        for (int i = 0; i < N; i++)
        {
            sum = sum + equation.GetValue(x1 + i * h) * h;
        }
        return sum;
    }
}