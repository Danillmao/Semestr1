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
        private delegate double IntegratorDelegate(Equation equation, double x1, double x2);
        public Form1()
        {
            InitializeComponent();
            equtaionCB.SelectedIndex = 0;
            methodCB.SelectedIndex = 0;
            textBox1.Text = "1";
            textBox2.Text = "10";
            textBox3.Text = "100";


        }
        void DrawFunction(Equation equation, IntegratorBase baze)
        {

            Series mySeriesOfPoint = new Series("1st func");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            double x1 = int.Parse(textBox1.Text);
            double x2 = int.Parse(textBox2.Text);
            double N = int.Parse(textBox3.Text);
            double h = (x2 - x1) / N;

            for (double x = x1; x <= x2; x += h)
            {

                double y = equation.GetValue(x);
                mySeriesOfPoint.Points.AddXY(x, y);
            }

            //baze.MethodName.ToString();
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
        public void chartButton_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].RecalculateAxesScale();
            Equation equation = CreateEquation();
            Integrator integrator = CreateIntegrator();
            SimpsonIntegrator simpsonintegrator = CreateSimpsonIntegrator();
            TrapezoidalIntegrator trapezoidalIntegrator = CreateTrapezoidIntegrator();
            IntegratorBase baze = null;



            if (methodCB.SelectedIndex == 0)
            {
                baze = integrator;
                MessageBox.Show(baze.MethodName);

            }
            else if (methodCB.SelectedIndex == 1)
            {
                baze = simpsonintegrator;
                MessageBox.Show(baze.MethodName);
            }
            else if (methodCB.SelectedIndex == 2)
            {
                baze = trapezoidalIntegrator;
                MessageBox.Show(baze.MethodName);
            }
            DrawFunction(equation, baze);
        }

    }
}
