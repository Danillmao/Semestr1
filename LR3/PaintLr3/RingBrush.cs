using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintLr3
{
    internal class RingBrush : Brush
    {
        public RingBrush(Color brushColor, int size) 
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            Pen pen = new Pen(BrushColor, 1);
            Graphics e = Graphics.FromImage(image);
            int width = Size*2;
            int height = Size*2;
            e.DrawEllipse(pen, x - 5, y - 5, width , height);
        }
    }
}
