using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace RecursiveAlgorithmsForm.Fractals
{
    public class FractalTree
    {
        public static bool Paint = false;

        public static void DrawFractal(int x, int y, int len, double angle,double newAngle,int thickness, PaintEventArgs e,Panel panel1)
        {
            Graphics g = e.Graphics;
            double x1, y1;
            x1 = x + len * Math.Sin(angle * Math.PI * 2 / 360.0);
            y1 = y + len * Math.Cos(angle * Math.PI * 2 / 360.0);

            //new Pen(Color.Black,len/10) толщина линии деревьев
            g.DrawLine(new Pen(Color.Black, len/thickness), x, panel1.Height - y, (int)x1, panel1.Height - (int)y1);
            if (len > 2)
            {
                //Менять угол, количество вызовов, len
                DrawFractal((int)x1, (int)y1, (int)(len / 1.5), angle + newAngle,newAngle, thickness, e,panel1);
                DrawFractal((int)x1, (int)y1, (int)(len / 1.5), angle - newAngle, newAngle, thickness,e, panel1);
            }

        }

        public static void ExtendedDrawFractal(int x, int y, int len, double angle, PaintEventArgs e, Panel panel1)
        {
            Graphics g = e.Graphics;
            double x1, y1;
            x1 = x + len * Math.Sin(angle * Math.PI * 2 / 360.0);
            y1 = y + len * Math.Cos(angle * Math.PI * 2 / 360.0);

            //new Pen(Color.Black,len/10) толщина линии деревьев
            g.DrawLine(new Pen(Color.Black), x, panel1.Height - y, (int)x1, panel1.Height - (int)y1);
            if (len > 2)
            {
                //Менять угол, количество вызовов, len
                ExtendedDrawFractal((int)x1, (int)y1, (int)(len / 1.5), angle + 30, e, panel1);
                ExtendedDrawFractal((int)x1, (int)y1, (int)(len / 1.5), angle - 30, e, panel1);
               // ExtendedDrawFractal((int)x1, (int)y1, (int)(len / 1.5), angle + 15, e, panel1);
                ExtendedDrawFractal((int)x1, (int)y1, (int)(len / 1.5), angle - 15, e, panel1);
            }

        }
    }
}
