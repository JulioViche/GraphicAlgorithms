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
    internal class Line
    {
        public Point start;
        public Point end;
        public int dx => end.X - start.X;
        public int dy => end.Y - start.Y;
        public float slope
        {
            get
            {
                if (end.X - start.X == 0)
                    throw new DivideByZeroException("Slope is undefined for vertical lines.");
                return (float)dy / (float)dx;
            }
        }

        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        public async Task DrawDDA(PictureBox canvas, Bitmap bitmap, bool animationEnabled, CancellationToken token)
        {
            AnimationManager am = new AnimationManager("DDA LINE", animationEnabled, canvas, bitmap);

            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xInc = (float)dx / steps;
            float yInc = (float)dy / steps;

            float xk = start.X;
            float yk = start.Y;

            am.AlgorithmStart();

            for (int i = 0; i <= steps; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Algorithm cancelled.");
                    return;
                }

                await am.SetPixel((int)Math.Round(xk), (int)Math.Round(yk), Color.Black, 2);

                xk += xInc;
                yk += yInc;
            }

            canvas.Invalidate();
            am.AlgorithmEnd();
        }

        public async Task DrawBresenham(PictureBox canvas, Bitmap bitmap, bool animationEnabled, CancellationToken token)
        {
            AnimationManager am = new AnimationManager("BRESENHAM LINE", animationEnabled, canvas, bitmap);

            int x0 = start.X;
            int y0 = start.Y;
            int x1 = end.X;
            int y1 = end.Y;

            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);

            if (steep)
            {
                (x0, y0) = (y0, x0);
                (x1, y1) = (y1, x1);
            }

            if (x0 > x1)
            {
                (x0, x1) = (x1, x0);
                (y0, y1) = (y1, y0);
            }

            int dx = x1 - x0;
            int dy = Math.Abs(y1 - y0);
            int error = dx / 2;
            int ystep = y0 < y1 ? 1 : -1;
            int y = y0;

            am.AlgorithmStart();

            for (int x = x0; x <= x1; x++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Algorithm cancelled.");
                    return;
                }

                int drawX = steep ? y : x;
                int drawY = steep ? x : y;

                await am.SetPixel(drawX, drawY, Color.Black, 2);

                error -= dy;
                if (error < 0)
                {
                    y += ystep;
                    error += dx;
                }
            }

            canvas.Invalidate();
            am.AlgorithmEnd();
        }
    }
}
