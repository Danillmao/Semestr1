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
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            textBox1.Text ="1";
            textBox2.Text = "10";
            textBox3.Text = "100";

        }
        void DrawFunction(Equation equation)
        {
            Integrator i1 = new Integrator(equation); //создаем интегратор для этого уравнения
            double integrValue = i1.Integrate(10, 30); //вызываем интегрирование на интвервале 10;30
            Series mySeriesOfPoint = new Series("1st func");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            double x1 = int.Parse(textBox1.Text);
            double x2 = int.Parse(textBox2.Text);
            double N = int.Parse(textBox3.Text);
            double h = (x2 - x1) / N;
            for (double x = x1; x <= x2; x +=h)
            {
                double y = equation.GetValue(x);
                mySeriesOfPoint.Points.AddXY(x, y);
            }
            chart1.Series.Add(mySeriesOfPoint);

        }
    
        public void chartButton_Click(object sender, EventArgs e)
        {
           
            chart1.Series.Clear();
            Equation equation = null;
            if (comboBox1.SelectedIndex == 0)
            {
                QuadForm q1 = new QuadForm();               
                if (q1.ShowDialog(this) == DialogResult.OK)
                {
                    equation = new QuadEquation(q1.A, q1.B, q1.C);    //создаем объект класса "кв. уравнение"
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ThirdForm t1 = new ThirdForm();
                if (t1.ShowDialog(this) == DialogResult.OK)
                {
                    equation = new Becuation(t1.A);  //создаем объект класса "кв. уравнение"
                }
            } 
            else if (comboBox1.SelectedIndex == 2)
            {
                SecondForm f1 = new SecondForm();
                if (f1.ShowDialog(this) == DialogResult.OK)
                {
                    equation = new Cequation(f1.A, f1.B);
                }                          
            }
            DrawFunction(equation);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
    }
}
