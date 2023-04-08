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
    public partial class QuadForm : Form
    {
        public QuadForm()
        {
            InitializeComponent();
            
        }
        public double A
        {
            get;set;
        }
        public double B
        {
            get; set;
        }
        public double C
        {
            get; set;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                A = Convert.ToDouble(textBoxA.Text);
                B = Convert.ToDouble(textBoxB.Text);
                C = Convert.ToDouble(textBoxC.Text);
                this.DialogResult = DialogResult.OK;
                Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Плохо", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //todo: читать с формы
           
        }

        private void buttonNEOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }
    }
}
