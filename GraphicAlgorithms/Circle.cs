using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public async Task DrawBresenham(PictureBox canvas, Bitmap bitmap, bool animation)
        {
            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;

            if (animation)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"BRESENHAM CIRCLE SUBPROCESS:");
                Console.WriteLine("------------------------------");
            }

            while (x <= y)
            {
                int xc = center.X;
                int yc = center.Y;

                if (animation)
                {
                    Console.WriteLine($"  Pixel ({xc + x}, {yc + y})");
                    Console.WriteLine($"  Pixel ({xc - x}, {yc + y})");
                    Console.WriteLine($"  Pixel ({xc + x}, {yc - y})");
                    Console.WriteLine($"  Pixel ({xc - x}, {yc - y})");
                    Console.WriteLine($"  Pixel ({xc + y}, {yc + x})");
                    Console.WriteLine($"  Pixel ({xc - y}, {yc + x})");
                    Console.WriteLine($"  Pixel ({xc + y}, {yc - x})");
                    Console.WriteLine($"  Pixel ({xc - y}, {yc - x})");
                    await Task.Delay(20);
                    canvas.Invalidate();
                }

                bitmap.SetPixel(xc + x, yc + y, Color.Black);
                bitmap.SetPixel(xc - x, yc + y, Color.Black);
                bitmap.SetPixel(xc + x, yc - y, Color.Black);
                bitmap.SetPixel(xc - x, yc - y, Color.Black);
                bitmap.SetPixel(xc + y, yc + x, Color.Black);
                bitmap.SetPixel(xc - y, yc + x, Color.Black);
                bitmap.SetPixel(xc + y, yc - x, Color.Black);
                bitmap.SetPixel(xc - y, yc - x, Color.Black);

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
            if (animation) Console.WriteLine("Algorithm finished!\n");
        }
    }
}
