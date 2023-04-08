using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintLr3
{
    internal class Eraser : Brush
    {
        public Eraser(Color brushColor, int size)
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            try
            {
                for (int y0 = y - Size; y0 < y + Size; ++y0)
                {
                    for (int x0 = x - Size; x0 < x + Size; x0++)
                    {
                        image.SetPixel(x0, y0, Color.White);

                    }
                }
            }
            catch (Exception)
            {

                return;
            }
            
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