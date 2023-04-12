using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR6WF
{
    public partial class HomeDialog : Form
    {
        public HomeDialog()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Квадратное уравнение";
       
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == "Квадратное уравнение")
            {
                
                Form1 form1 = new Form1();
                form1.Show();
                
                
            }
        }
    }
}
