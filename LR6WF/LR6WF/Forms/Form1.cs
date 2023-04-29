using LR6WF.Интеграторы;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR6WF
{
    public partial class Form1 : Form
    {

        public delegate double EquationDelegate(double x);
    
        public Form1()
        {
            InitializeComponent();
            equtaionCB.SelectedIndex = 0;
            methodCB.SelectedIndex = 0;
            textBox1.Text = "1";
            textBox2.Text = "10";
            textBox3.Text = "100";
            
            
        }
        void DrawFunction(EquationDelegate equation, IntegratorBase baze)
        {
           
            Series mySeriesOfPoint = new Series("1st func");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            double x1 = int.Parse(textBox1.Text);
            double x2 = int.Parse(textBox2.Text);
            int N = int.Parse(textBox3.Text);
            double h = (x2 - x1) / N;
            Global.GoblalPropx1 = x1;
            Global.GoblalPropx2 = x2;
            Global.GoblalPropxN = N;

            for (double x = x1; x <= x2; x += h)
            {
                double y = equation(x);
                mySeriesOfPoint.Points.AddXY(x, y);
            }

     
            chart1.Series.Add(mySeriesOfPoint);


        }
        public Equation CreateEquation1()
        {
            QuadForm q1 = new QuadForm();
            if (q1.ShowDialog(this) == DialogResult.OK)
            {
                Equation equation = new QuadEquation(q1.A, q1.B, q1.C);
                return equation;
            }
            else
            {
                return null;
            }
        }
        public Equation CreateEquation2()
        {
            ThirdForm t1 = new ThirdForm();
            if (t1.ShowDialog(this) == DialogResult.OK)
            {
                Equation equation = new Becuation(t1.A);
                return equation; //создаем объект класса "кв. уравнение"
            }
            else
            {
                return null;
            }
        }

        public Equation CreateEquation3()
        {
            SecondForm f1 = new SecondForm();
            if (f1.ShowDialog(this) == DialogResult.OK)
            {
                Equation equation = new Cequation(f1.A, f1.B);
                return equation;
            }
            else
            {
                return null;
            }
        }
        public Equation CreateEquation()
        {
            Equation equation = null;
            if (equtaionCB.SelectedIndex == 0)
            {
                equation = CreateEquation1();
            }
            else if (equtaionCB.SelectedIndex == 1)
            {
                equation = CreateEquation2();
            }
            else if (equtaionCB.SelectedIndex == 2)
            {
                equation = CreateEquation3();
            }
 
                
            return equation;
        }

        public Integrator CreateIntegrator()
        {
            Integrator integrator = new Integrator();
            return integrator;
        }

        public SimpsonIntegrator CreateSimpsonIntegrator()
        {
            SimpsonIntegrator integrator = new SimpsonIntegrator();
            return integrator;
        }

        public TrapezoidalIntegrator CreateTrapezoidIntegrator()
        {
            TrapezoidalIntegrator integrator = new TrapezoidalIntegrator();
            return integrator;
        }

        public IntegratorBase CreateBaseIntegrator()
        {
            
            Integrator integrator = CreateIntegrator();
            SimpsonIntegrator simpsonintegrator = CreateSimpsonIntegrator();
            TrapezoidalIntegrator trapezoidalIntegrator = CreateTrapezoidIntegrator();
            IntegratorBase baze = null;

            if (methodCB.SelectedIndex == 0)
            {
                baze = integrator;
                label4.Text = baze.MethodName;

            }
            else if (methodCB.SelectedIndex == 1)
            {
                baze = simpsonintegrator;
                label4.Text = baze.MethodName;
            }
            else if (methodCB.SelectedIndex == 2)
            {
                baze = trapezoidalIntegrator;
                label4.Text = baze.MethodName;
            }

            return baze;
        }
        public void chartButton_Click(object sender, EventArgs e)
        {            
            chart1.Series.Clear();
            chart1.ChartAreas[0].RecalculateAxesScale();
            IntegratorBase baze = CreateBaseIntegrator();
            Equation equation = CreateEquation();
            if (equation != null)
            {
                EquationDelegate equationDelegate = equation.GetValue;
                DrawFunction(equationDelegate, baze);
                label3.Text = baze.Integrate(equationDelegate, Global.GoblalPropx1, Global.GoblalPropx2, Global.GoblalPropxN).ToString();
            }
        }
    }
}
