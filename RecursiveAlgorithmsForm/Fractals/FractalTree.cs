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
        public static void GetFractalPoints(Rectangle camvas,
       int x, int y, int len, double angle, List<List<Point>> lines)
        {
            double x1 = x + len * Math.Sin(angle * Math.PI * 2 / 360.0);
            double y1 = y + len * Math.Cos(angle * Math.PI * 2 / 360.0);

            var pt1 = new Point(x, camvas.Height - y);
            var pt2 = new Point((int)x1, camvas.Height - (int)y1);

            lines.Add(new List<Point> { pt1, pt2 });

            if (len > 2)
            {
                GetFractalPoints(camvas, (int)x1, (int)y1, (int)(len / 1.5), angle + 30, lines);
                GetFractalPoints(camvas, (int)x1, (int)y1, (int)(len / 1.5), angle - 15, lines);
                //GetFractalPoints(camvas, (int)x1, (int)y1, (int)(len / 1.5), angle + 15, lines);
                //GetFractalPoints(camvas, (int)x1, (int)y1, (int)(len / 1.5), angle - 15, lines);
            }
        }

        public static async Task GetFractalPointsAsync(
       Rectangle camvas, int x, int y, int len, double angle,int secondAngle,
       List<List<Point>> lines,
       CancellationToken token)
        {
            await Task.Run(async () =>
            {
                double x1 = x + len * Math.Sin(angle * Math.PI * 2 / 360.0);
                double y1 = y + len * Math.Cos(angle * Math.PI * 2 / 360.0);

                var pt1 = new Point(x, camvas.Height - y);
                var pt2 = new Point((int)x1, camvas.Height - (int)y1);

                lines.Add(new List<Point> { pt1, pt2 });

                if (len > 2)
                {
                    await GetFractalPointsAsync(camvas, (int)x1, (int)y1,
                        (int)(len / 1.5), angle + secondAngle,secondAngle, lines, token);
                    await GetFractalPointsAsync(camvas, (int)x1, (int)y1,
                        (int)(len / 1.5), angle - secondAngle,secondAngle, lines, token);
                    //await GetFractalPointsAsync(camvas, (int)x1, (int)y1, 
                    //    (int)(len / 1.5), angle - 15, lines, token);
                }
            }, token);
        }
    }
}
