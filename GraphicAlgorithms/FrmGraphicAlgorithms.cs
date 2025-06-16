using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicAlgorithms
{
    public partial class FrmGraphicAlgorithms : Form
    {
        private Bitmap bitmap;

        public FrmGraphicAlgorithms()
        {
            InitializeComponent();
        }

        private async void btnDrawDDA_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if (!int.TryParse(txtX0.Text, out int x0) || x0 < 0 || x0 >= 400) valid = false;
            if (!int.TryParse(txtY0.Text, out int y0) || y0 < 0 || y0 >= 400) valid = false;
            if (!int.TryParse(txtX1.Text, out int x1) || x1 < 0 || x1 >= 400) valid = false;
            if (!int.TryParse(txtY1.Text, out int y1) || y1 < 0 || y1 >= 400) valid = false;

            if (!valid)
            {
                MessageBox.Show("Todos los valores deben ser números enteros entre 0 y 399.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bitmap;

            Line line = new Line(new Point(x0, picCanvas.Height - 1 - y0), new Point(x1, picCanvas.Height - 1 - y1));
            await line.DrawDDA(picCanvas, bitmap, true);
        }

        private async void btnDrawBresenham_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if (!int.TryParse(txtX0.Text, out int x0) || x0 < 0 || x0 >= 400) valid = false;
            if (!int.TryParse(txtY0.Text, out int y0) || y0 < 0 || y0 >= 400) valid = false;
            if (!int.TryParse(txtX1.Text, out int x1) || x1 < 0 || x1 >= 400) valid = false;
            if (!int.TryParse(txtY1.Text, out int y1) || y1 < 0 || y1 >= 400) valid = false;

            if (!valid)
            {
                MessageBox.Show("Todos los valores deben ser números enteros entre 0 y 399.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bitmap;

            Line line = new Line(new Point(x0, picCanvas.Height - 1 - y0), new Point(x1, picCanvas.Height - 1 - y1));
            await line.DrawBresenham(picCanvas, bitmap, true);
        }

        private async void btnCircleBresenham_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if (!int.TryParse(txtCX.Text, out int cx) || cx < 0 || cx >= 400) valid = false;
            if (!int.TryParse(txtCY.Text, out int cy) || cy < 0 || cy >= 400) valid = false;
            if (!int.TryParse(txtCR.Text, out int cr) || cr == 0) valid = false;

            if (!valid)
            {
                MessageBox.Show("Todos los valores deben ser números enteros entre 0 y 399.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cx - cr < 0 || cx + cr >= 400 || cy - cr < 0 || cy + cr >= 400)
            {
                MessageBox.Show("El círculo se sale del rango permitido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int xc = txtCX.Text == "" ? 0 : int.Parse(txtCX.Text);
            int yc = txtCY.Text == "" ? 0 : int.Parse(txtCY.Text);
            int radius = txtCR.Text == "" ? 0 : int.Parse(txtCR.Text);

            bitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bitmap;

            Circle circle = new Circle(new Point(xc, picCanvas.Height - 1 - yc), radius);
            await circle.DrawBresenham(picCanvas, bitmap, true);
        }

        private async void btnFlowFill_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bitmap;

            Rhombus rhombus = new Rhombus(new Point(picCanvas.Width / 2, picCanvas.Height / 2), 200, 350);
            await rhombus.Draw(picCanvas, bitmap);
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Mouse clicked at: {e.X}, {e.Y}");
            await Filler.FlowFill(picCanvas, bitmap, new Point(e.X, e.Y), Color.Black);
        }
    }
}
