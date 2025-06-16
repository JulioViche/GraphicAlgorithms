using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicAlgorithms
{
    public partial class FrmGraphicAlgorithms : Form
    {
        private Bitmap bitmap;
        private CancellationTokenSource cts;
        private bool fillEnabled = true;

        public FrmGraphicAlgorithms()
        {
            InitializeComponent();
            resetBitmap();
        }

        private void resetBitmap()
        {
            bitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.BackColor = Color.White;
            picCanvas.Image = bitmap;
        }

        private void disableButtons()
        {
            btnDrawDDA.Enabled = false;
            btnDrawBresenham.Enabled = false;
            btnDrawRhombus.Enabled = false;
            btnCircleBresenham.Enabled = false;
            btnClearCanvas.Enabled = false;
            btnCancelAnimation.Enabled = true;
            fillEnabled = false;
        }

        private void enableButtons()
        {
            btnDrawDDA.Enabled = true;
            btnDrawBresenham.Enabled = true;
            btnDrawRhombus.Enabled = true;
            btnCircleBresenham.Enabled = true;
            btnClearCanvas.Enabled = true;
            btnCancelAnimation.Enabled = false;
            fillEnabled = true;
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

            resetBitmap();
            disableButtons();

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Line line = new Line(new Point(x0, picCanvas.Height - 1 - y0), new Point(x1, picCanvas.Height - 1 - y1));
            await line.DrawDDA(picCanvas, bitmap, cbxAnimationsEnabled.Checked, token);

            enableButtons();
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

            resetBitmap();
            disableButtons();

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Line line = new Line(new Point(x0, picCanvas.Height - 1 - y0), new Point(x1, picCanvas.Height - 1 - y1));
            await line.DrawBresenham(picCanvas, bitmap, cbxAnimationsEnabled.Checked, token);

            enableButtons();
        }

        private async void btnCircleBresenham_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if (!int.TryParse(txtCX.Text, out int cx) || cx < 0 || cx >= 400) valid = false;
            if (!int.TryParse(txtCY.Text, out int cy) || cy < 0 || cy >= 400) valid = false;
            if (!int.TryParse(txtCR.Text, out int cr)) valid = false;

            if (!valid)
            {
                MessageBox.Show("Todos los valores deben ser números enteros entre 0 y 399.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cr <= 0)
            {
                MessageBox.Show("El radio debe ser mayor a cero", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cx - cr < 0 || cx + cr >= 400 || cy - cr < 0 || cy + cr >= 400)
            {
                MessageBox.Show("El círculo se sale del rango permitido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            resetBitmap();
            disableButtons();

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Circle circle = new Circle(new Point(cx, picCanvas.Height - 1 - cy), cr);
            await circle.DrawBresenham(picCanvas, bitmap, cbxAnimationsEnabled.Checked, token);

            enableButtons();
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!fillEnabled) return;

            disableButtons();

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            await Filler.FlowFill(picCanvas, bitmap, new Point(e.X, e.Y), Color.Black, cbxAnimationsEnabled.Checked, token);

            enableButtons();
        }

        private async void btnDrawRhombus_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if (!int.TryParse(txtRhombusWidth.Text, out int rw) || rw <= 0 || rw >= 400) valid = false;
            if (!int.TryParse(txtRhombusHeight.Text, out int rh) || rh <= 0 || rh >= 400) valid = false;

            if (!valid)
            {
                MessageBox.Show("Todos los valores deben ser números enteros mayores a 0 y menores a 399.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            resetBitmap();
            disableButtons();

            Rhombus rhombus = new Rhombus(new Point(picCanvas.Width / 2, picCanvas.Height / 2), rw, rh);
            await rhombus.Draw(picCanvas, bitmap);

            enableButtons();
        }

        private void btnCancelAnimation_Click(object sender, EventArgs e)
        {
            if (cts != null) cts.Cancel();
        }

        private void btnClearCanvas_Click(object sender, EventArgs e)
        {
            resetBitmap();
        }
    }
}
