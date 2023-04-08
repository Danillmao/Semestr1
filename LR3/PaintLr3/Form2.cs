using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintLr3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int W
        {
            get
            {
                string text = tbWidth.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        public int H
        {
            get
            {
                string text = tbHeight.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        public int N
        {
            get
            {
                string text = textBox1.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        bool _canceled = false;
        public bool Canceled
        {
            get { return _canceled; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _canceled = false;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _canceled = true;
            Close();
        }
    }
}
