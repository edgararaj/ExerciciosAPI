using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EqSegundoGrau
{
    public partial class Form1 : Form
    {
        private double scale_x = 0.1;
        private int? x_ref = null;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseWheel += pictureBox1_MouseWheel;
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            scale_x += e.Delta * 1e-4;
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = (double)numericUpDown1.Value;
            var b = (double)numericUpDown2.Value;
            var c = (double)numericUpDown3.Value;
            var raizes = new List<double>();

            if (a == 0 && b == 0)
            {
                label4.Text = "Não existem raizes reais para esta equação!";
                label4.ForeColor = Color.Red;
            }
            else
            {
                if (a == 0)
                {
                    var raiz = -c / b;
                    raizes.Add(raiz);
                    label4.Text = String.Format("Esta equação admite apenas uma raiz:\nx = {0:0.00}", raiz);
                    label4.ForeColor = Color.Black;
                }
                else if (b == 0)
                {
                    if (a * c > 0)
                    {
                        label4.Text = "Não existem raizes reais para esta equação!";
                        label4.ForeColor = Color.Red;
                    }
                    else
                    {
                        var raiz1 = Math.Sqrt(-c / a);
                        var raiz2 = -Math.Sqrt(-c / a);
                        raizes.Add(raiz1);
                        raizes.Add(raiz2);
                        label4.Text = String.Format("Esta equação admite duas raizes:\nx = {0:0.00}\ne\nx = {1:0.00}", raiz1, raiz2);
                        label4.ForeColor = Color.Black;
                    }
                }
                else 
                { 
                    double delta = Math.Pow(b, 2) - (4 * a * c);
                    double deltaraiz = Math.Sqrt(delta);
                    if (delta < 0)
                    {
                        label4.Text = "Não existem raizes reais para esta equação!";
                        label4.ForeColor = Color.Red;
                    }
                    else {
                        var raiz1 = (-b + deltaraiz) / (2 * a);
                        var raiz2 = (-b - deltaraiz) / (2 * a);
                        raizes.Add(raiz1);
                        if (delta > 0)
                        {
                            raizes.Add(raiz2);
                            label4.Text = String.Format("Esta equação admite duas raizes:\nx = {0:0.00}\ne\nx = {1:0.00}", raiz1, raiz2);
                        }
                        else 
                        {
                            label4.Text = String.Format("Esta equação admite uma raiz dupla:\nx = {0:0.00}", raiz1);
                        }
                        label4.ForeColor = Color.Black;
                    }
                }
            }

            var canvas_width = pictureBox1.Size.Width;
            var canvas_height = pictureBox1.Size.Height;
            var ref_brush = new SolidBrush(Color.Black);
            var fun_brush = new SolidBrush(Color.Red);
            var imagem = new Bitmap(canvas_width, canvas_height);
            var canvas = Graphics.FromImage(imagem);
            var thickness = 2;
            if (raizes.Count > 0)
            {
                var raiz_media = 0.0;
                foreach (var raiz in raizes)
                {
                    raiz_media += raiz / scale_x;
                }
                raiz_media /= raizes.Count;
                x_ref = (int)((canvas_width / 2) - raiz_media);
            }
            else
            {
                if (x_ref == null) x_ref = (canvas_width / 2);
            }
            var y_ref = canvas_height / 2;
            canvas.FillRectangle(ref_brush, 0, y_ref, canvas_width, thickness);
            canvas.FillRectangle(ref_brush, x_ref.Value, 0, thickness, canvas_height);
            for (int x_a_desenhar = 0; x_a_desenhar < canvas_width; x_a_desenhar++)
            {
                var x = (x_a_desenhar - x_ref) * scale_x;
                var y = (int)(a * x * x + b * x + c);
                var y_a_desenhar = y_ref - y;
                canvas.FillRectangle(fun_brush, x_a_desenhar, y_a_desenhar, thickness, thickness);
            }
            canvas.Dispose();
            ref_brush.Dispose();
            fun_brush.Dispose();
            pictureBox1.Image = imagem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !(MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scale_x = 0.1;
            button1_Click(sender, e);
        }
    }
}
