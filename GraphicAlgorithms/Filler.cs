using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicAlgorithms
{
    internal class Filler
    {
        public static async Task FlowFill(PictureBox canvas, Bitmap bitmap, Point start, Color replacementColor)
        {
            if (start.X < 0 || start.X >= bitmap.Width || start.Y < 0 || start.Y >= bitmap.Height)
                return;

            Color targetColor = bitmap.GetPixel(start.X, start.Y);

            if (targetColor.ToArgb() == replacementColor.ToArgb())
                return;

            HashSet<Point> visited = new HashSet<Point>();
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(start);

            int count = 0;

            Console.WriteLine($"FLOWFILL ALGORITHM:");

            while (pixels.Count > 0)
            {
                Point p = pixels.Pop();

                if (p.X < 0 || p.X >= bitmap.Width || p.Y < 0 || p.Y >= bitmap.Height)
                    continue;

                if (visited.Contains(p))
                    continue;

                Color currentColor = bitmap.GetPixel(p.X, p.Y);
                if (currentColor.ToArgb() != targetColor.ToArgb())
                    continue;

                visited.Add(p);

                Console.WriteLine($"  Pixel: ({p.X}, {p.Y})");
                if (count++ % 100 == 0) await Task.Delay(1);

                bitmap.SetPixel(p.X, p.Y, replacementColor);
                canvas.Invalidate();


                pixels.Push(new Point(p.X - 1, p.Y));
                pixels.Push(new Point(p.X, p.Y + 1));
                pixels.Push(new Point(p.X + 1, p.Y));
                pixels.Push(new Point(p.X, p.Y - 1));
            }
        }
    }
}
