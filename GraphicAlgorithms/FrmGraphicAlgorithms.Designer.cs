namespace GraphicAlgorithms
{
    partial class FrmGraphicAlgorithms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnDrawDDA = new System.Windows.Forms.Button();
            this.btnDrawBresenham = new System.Windows.Forms.Button();
            this.btnCircleBresenham = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblCircle = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCX = new System.Windows.Forms.TextBox();
            this.txtCY = new System.Windows.Forms.TextBox();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDrawRhombus = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRhombusHeight = new System.Windows.Forms.TextBox();
            this.txtRhombusWidth = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(400, 400);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // btnDrawDDA
            // 
            this.btnDrawDDA.Location = new System.Drawing.Point(436, 101);
            this.btnDrawDDA.Name = "btnDrawDDA";
            this.btnDrawDDA.Size = new System.Drawing.Size(75, 23);
            this.btnDrawDDA.TabIndex = 1;
            this.btnDrawDDA.Text = "DDA";
            this.btnDrawDDA.UseVisualStyleBackColor = true;
            this.btnDrawDDA.Click += new System.EventHandler(this.btnDrawDDA_Click);
            // 
            // btnDrawBresenham
            // 
            this.btnDrawBresenham.Location = new System.Drawing.Point(531, 101);
            this.btnDrawBresenham.Name = "btnDrawBresenham";
            this.btnDrawBresenham.Size = new System.Drawing.Size(75, 23);
            this.btnDrawBresenham.TabIndex = 2;
            this.btnDrawBresenham.Text = "Bresenham";
            this.btnDrawBresenham.UseVisualStyleBackColor = true;
            this.btnDrawBresenham.Click += new System.EventHandler(this.btnDrawBresenham_Click);
            // 
            // btnCircleBresenham
            // 
            this.btnCircleBresenham.Location = new System.Drawing.Point(436, 220);
            this.btnCircleBresenham.Name = "btnCircleBresenham";
            this.btnCircleBresenham.Size = new System.Drawing.Size(75, 23);
            this.btnCircleBresenham.TabIndex = 3;
            this.btnCircleBresenham.Text = "Bresenham";
            this.btnCircleBresenham.UseVisualStyleBackColor = true;
            this.btnCircleBresenham.Click += new System.EventHandler(this.btnCircleBresenham_Click);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(434, 30);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(45, 16);
            this.lblLine.TabIndex = 4;
            this.lblLine.Text = "Línea";
            // 
            // lblCircle
            // 
            this.lblCircle.AutoSize = true;
            this.lblCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircle.Location = new System.Drawing.Point(434, 149);
            this.lblCircle.Name = "lblCircle";
            this.lblCircle.Size = new System.Drawing.Size(55, 16);
            this.lblCircle.TabIndex = 5;
            this.lblCircle.Text = "Círculo";
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(474, 49);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(38, 20);
            this.txtX0.TabIndex = 6;
            this.txtX0.Text = "0";
            // 
            // txtY0
            // 
            this.txtY0.Location = new System.Drawing.Point(474, 75);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(38, 20);
            this.txtY0.TabIndex = 7;
            this.txtY0.Text = "0";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(569, 49);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(38, 20);
            this.txtX1.TabIndex = 8;
            this.txtX1.Text = "399";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(569, 75);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(38, 20);
            this.txtY1.TabIndex = 9;
            this.txtY1.Text = "399";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "x_0:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "y_0:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "x_1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "y_1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "x:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "y:";
            // 
            // txtCX
            // 
            this.txtCX.Location = new System.Drawing.Point(473, 168);
            this.txtCX.Name = "txtCX";
            this.txtCX.Size = new System.Drawing.Size(38, 20);
            this.txtCX.TabIndex = 17;
            this.txtCX.Text = "200";
            // 
            // txtCY
            // 
            this.txtCY.Location = new System.Drawing.Point(473, 194);
            this.txtCY.Name = "txtCY";
            this.txtCY.Size = new System.Drawing.Size(38, 20);
            this.txtCY.TabIndex = 18;
            this.txtCY.Text = "200";
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(569, 166);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(38, 20);
            this.txtCR.TabIndex = 19;
            this.txtCR.Text = "199";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "r:";
            // 
            // btnDrawRhombus
            // 
            this.btnDrawRhombus.Location = new System.Drawing.Point(437, 310);
            this.btnDrawRhombus.Name = "btnDrawRhombus";
            this.btnDrawRhombus.Size = new System.Drawing.Size(90, 23);
            this.btnDrawRhombus.TabIndex = 21;
            this.btnDrawRhombus.Text = "Dibujar Rombo";
            this.btnDrawRhombus.UseVisualStyleBackColor = true;
            this.btnDrawRhombus.Click += new System.EventHandler(this.btnDrawRhombus_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Haz click en cualquier parte del canvas para pintar.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(434, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Rombo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(433, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Relleno";
            // 
            // txtRhombusHeight
            // 
            this.txtRhombusHeight.Location = new System.Drawing.Point(568, 284);
            this.txtRhombusHeight.Name = "txtRhombusHeight";
            this.txtRhombusHeight.Size = new System.Drawing.Size(38, 20);
            this.txtRhombusHeight.TabIndex = 28;
            this.txtRhombusHeight.Text = "350";
            // 
            // txtRhombusWidth
            // 
            this.txtRhombusWidth.Location = new System.Drawing.Point(474, 284);
            this.txtRhombusWidth.Name = "txtRhombusWidth";
            this.txtRhombusWidth.Size = new System.Drawing.Size(38, 20);
            this.txtRhombusWidth.TabIndex = 27;
            this.txtRhombusWidth.Text = "200";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(529, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "alto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "ancho:";
            // 
            // FrmGraphicAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRhombusHeight);
            this.Controls.Add(this.txtRhombusWidth);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDrawRhombus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCR);
            this.Controls.Add(this.txtCY);
            this.Controls.Add(this.txtCX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.lblCircle);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnCircleBresenham);
            this.Controls.Add(this.btnDrawBresenham);
            this.Controls.Add(this.btnDrawDDA);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmGraphicAlgorithms";
            this.Text = "FrmGraphicAlgorithms";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDrawDDA;
        private System.Windows.Forms.Button btnDrawBresenham;
        private System.Windows.Forms.Button btnCircleBresenham;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblCircle;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCX;
        private System.Windows.Forms.TextBox txtCY;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDrawRhombus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRhombusHeight;
        private System.Windows.Forms.TextBox txtRhombusWidth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}