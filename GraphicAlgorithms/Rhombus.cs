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
    internal class Rhombus
    {
        public Point center;
        public int width;
        public int height;

        public Rhombus(Point center, int width, int height)
        {
            this.center = center;
            this.width = width;
            this.height = height;
        }

        public async Task Draw(PictureBox canvas, Bitmap bitmap)
        {
            Point point1 = new Point(center.X, center.Y - height / 2);
            Point point2 = new Point(center.X + width / 2, center.Y);
            Point point3 = new Point(center.X, center.Y + height / 2);
            Point point4 = new Point(center.X - width / 2, center.Y);

            Line line1 = new Line(point1, point2);
            Line line2 = new Line(point2, point3);
            Line line3 = new Line(point3, point4);
            Line line4 = new Line(point4, point1);

            await line1.DrawBresenham(canvas, bitmap, false, new CancellationToken());
            await line2.DrawBresenham(canvas, bitmap, false, new CancellationToken());
            await line3.DrawBresenham(canvas, bitmap, false, new CancellationToken());
            await line4.DrawBresenham(canvas, bitmap, false, new CancellationToken());
        }
    }
}
