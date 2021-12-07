using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Termometros 
{
    public partial class Form1 : Form
    {
        private double scale_x = 0.1;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += button1_Click;
            draw_graph(obter_funcao_escolhida());
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            scale_x += e.Delta * 1e-4;
            draw_graph(obter_funcao_escolhida());
        }

        struct Funcao
        {
            public Funcao(double a2, double b2, double minorante2, double majorante2)
            {
                a = a2;
                b = b2;
                minorante = minorante2;
                majorante = majorante2;
            }
            public double a, b;
            public double minorante, majorante;
        }

        private Funcao obter_funcao_escolhida()
        { 
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    return new Funcao(1 / 9.6e-3, -0.04 / 9.6e-3, 0.1, 1.3);
                case 1:
                    return new Funcao(1 / 9.6e-3, 0.52 / 9.6e-3, 0.1, 1.7);
                case 2:
                    return new Funcao(1 / 0.02, 0, 0.1, 2);
            }
            return new Funcao();
        }


        private void draw_graph(Funcao funcao_escolhida)
        {
            var canvas_width = pictureBox1.Size.Width;
            var canvas_height = pictureBox1.Size.Height;
            var imagem = new Bitmap(canvas_width, canvas_height);
            var canvas = Graphics.FromImage(imagem);
            var x_ref = (int)((canvas_width / 2) - (-funcao_escolhida.b / funcao_escolhida.a) / scale_x);
            var y_ref = canvas_height / 2;
            var ref_brush = new SolidBrush(Color.Black);
            var fun_brush = new SolidBrush(Color.Red);
            var font = new Font(FontFamily.GenericSerif, 12);
            var thickness = 2;
            canvas.FillRectangle(ref_brush, 0, y_ref, canvas_width, thickness);
            canvas.DrawString("y", font, ref_brush, canvas_width - 15, y_ref);
            canvas.FillRectangle(ref_brush, x_ref, 0, thickness, canvas_height);
            canvas.DrawString("x", font, ref_brush, x_ref + 5, 0);
            for (int x_a_desenhar = 0; x_a_desenhar < canvas_width; x_a_desenhar++)
            {
                var x = (x_a_desenhar - x_ref) * scale_x;
                var y = (int)(funcao_escolhida.a * x + funcao_escolhida.b);
                var y_a_desenhar = y_ref - y;
                canvas.FillRectangle(fun_brush, x_a_desenhar, y_a_desenhar, thickness, thickness);
            }
            canvas.Dispose();
            font.Dispose();
            ref_brush.Dispose();
            fun_brush.Dispose();
            pictureBox1.Image = imagem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcao funcao_escolhida = obter_funcao_escolhida();
            var voltagem = (double)nud_voltagem.Value;
            if (voltagem < funcao_escolhida.minorante || voltagem > funcao_escolhida.majorante)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Temperatura especificado fora do dominio do termómetro escolhido!";
            }
            else
            {
                var temperatura = funcao_escolhida.a * voltagem + funcao_escolhida.b;
                label4.ForeColor = Color.Black;
                label4.Text = String.Format("A temperatura é: {0:0.00}", temperatura);
            }
            draw_graph(funcao_escolhida);
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
