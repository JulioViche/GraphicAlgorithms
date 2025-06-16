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
    internal class Filler
    {
        public static async Task FlowFill(PictureBox canvas, Bitmap bitmap, Point start, Color replacementColor, bool animationEnabled, CancellationToken token)
        {
            if (start.X < 0 || start.X >= bitmap.Width || start.Y < 0 || start.Y >= bitmap.Height)
                return;

            AnimationManager am = new AnimationManager("FLOWFILL ALGORITHM", animationEnabled, canvas, bitmap);

            Color targetColor = bitmap.GetPixel(start.X, start.Y);

            if (targetColor.ToArgb() == replacementColor.ToArgb())
                return;

            HashSet<Point> visited = new HashSet<Point>();
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(start);

            int count = 0;

            am.AlgorithmStart();

            while (pixels.Count > 0)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Algorithm cancelled.");
                    return;
                }

                Point p = pixels.Pop();

                if (p.X < 0 || p.X >= bitmap.Width || p.Y < 0 || p.Y >= bitmap.Height)
                    continue;

                if (visited.Contains(p))
                    continue;

                Color currentColor = bitmap.GetPixel(p.X, p.Y);
                if (currentColor.ToArgb() != targetColor.ToArgb())
                    continue;

                visited.Add(p);

                await am.SetPixel(p.X, p.Y, replacementColor, count++ % 100 == 0 ? 1 : 0);

                pixels.Push(new Point(p.X - 1, p.Y));
                pixels.Push(new Point(p.X, p.Y + 1));
                pixels.Push(new Point(p.X + 1, p.Y));
                pixels.Push(new Point(p.X, p.Y - 1));
            }

            canvas.Invalidate();
            am.AlgorithmEnd();
        }
    }
}
