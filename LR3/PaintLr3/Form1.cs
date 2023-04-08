using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PaintLr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width = 2000, pictureBox1.Height = 1000);
            colorDialog1.FullOpen = true;
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);

        }

        Color DefaultColor
        {
            get { return Color.White; }
        }

        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;

            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;

            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }
        // Ïåðåìåííûå 
        int _x;
        int _y;
       private bool _mouseclicked = false;
            
            Color SelectedColor
            {
                get{ return colorDialog1.Color; }
            }

            int SelectedSize
            {
                get{ return brushSizeBar.Value; }   
                set { brushSizeBar.Value = value;}
           
            }

        Brush _selectedBrush;

       
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {
                return;
            }

            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseclicked= true;
        }
        
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseclicked= false;  
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if(_mouseclicked )
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void brushSizeBar_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("Ðàçìåð: {0}", brushSizeBar.Value.ToString());

            try
            {
                
                _selectedBrush.Size = brushSizeBar.Value;
            }
            catch (Exception)
            {

               return;
            }
            
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 form= new Form2();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _selectedBrush = new RingBrush(SelectedColor, SelectedSize);
        }

        private void î÷èñòèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Eraser(SelectedColor, SelectedSize);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _selectedBrush.BrushColor = colorDialog1.Color;
                button5.BackColor = colorDialog1.Color;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            _selectedBrush.BrushColor = button.BackColor;

        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
                _selectedBrush.BrushColor = button.BackColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _selectedBrush = new KrestKist(SelectedColor, SelectedSize);
        }
    }
}