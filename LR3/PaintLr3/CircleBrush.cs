using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintLr3
{
    internal class CircleBrush : Brush
    {
        public CircleBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            SolidBrush brush = new SolidBrush(BrushColor);
            Graphics e = Graphics.FromImage(image);
            int width = Size*2;
            int height = Size*2;
            e.FillEllipse(brush, x - 5, y - 5, width, height);
            
        }
    }
}
/*
 Pen pen = new Pen(BrushColor, 1);
            Graphics e = Graphics.FromImage(image);
            int width = Size;
            int height = Size;
            e.DrawEllipse(pen, x - 5, y - 5, width, height);

 */