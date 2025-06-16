using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicAlgorithms
{
    internal class Circle
    {
        public Point center;
        public int radius;
        public Circle(Point center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public async Task DrawBresenham(PictureBox canvas, Bitmap bitmap, bool animationEnabled, CancellationToken token)
        {
            AnimationManager am = new AnimationManager("BRESENHAM CIRCLE", animationEnabled, canvas, bitmap);

            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;

            am.AlgorithmStart();

            while (x <= y)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Algorithm cancelled.");
                    return;
                }

                int xc = center.X;
                int yc = center.Y;

                await am.SetPixel(xc + x, yc + y, Color.Black, 1);
                await am.SetPixel(xc - x, yc + y, Color.Black, 0);
                await am.SetPixel(xc + x, yc - y, Color.Black, 0);
                await am.SetPixel(xc - x, yc - y, Color.Black, 0);
                await am.SetPixel(xc + y, yc + x, Color.Black, 0);
                await am.SetPixel(xc - y, yc + x, Color.Black, 0);
                await am.SetPixel(xc + y, yc - x, Color.Black, 0);
                await am.SetPixel(xc - y, yc - x, Color.Black, 0);

                if (d < 0)
                {
                    d += 4 * x + 6;
                }
                else
                {
                    d += 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }

            canvas.Invalidate();
            am.AlgorithmEnd();
        }
    }
}
