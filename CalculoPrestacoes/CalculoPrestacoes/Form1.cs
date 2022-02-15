using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace CalculoPrestacoes
{
    public partial class Form1 : Form
    {
        private Calculadora calculadora;
        private TextBox txt_a_calcular;
        private Color txt_a_calcular_prev_back_color;
        private Timer lbl_msg_timer = new Timer();
        private Dictionary<TextBox, Calculadora.Variavel> txts;

        private Point grafico_center;
        private PointF grafico_scale = new PointF(1, 1);
        private bool grafico_mouse_dragging = false;
        private Point grafico_mouse_start;
        private Point grafico_mouse_start_center;

        public Form1()
        {
            InitializeComponent();
            grafico_center = new Point(pb_grafico.Width / 2, pb_grafico.Height / 2);
            txts = new Dictionary<TextBox, Calculadora.Variavel> {
                { txt_p, Calculadora.Variavel.P },
                { txt_t, Calculadora.Variavel.T },
                { txt_v, Calculadora.Variavel.V },
                { txt_n, Calculadora.Variavel.N },
            };
            InitializeGraphicComboBoxes();
            pb_grafico.MouseWheel += (sender, e) =>
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    grafico_scale.Y += e.Delta * 1e-3f * grafico_scale.Y;
                }
                else if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
                { 
                    grafico_scale.X += e.Delta * 1e-3f * grafico_scale.X;
                    grafico_scale.Y += e.Delta * 1e-3f * grafico_scale.Y;
                }
                else
                {
                    grafico_scale.X += e.Delta * 1e-3f * grafico_scale.X;
                }

                calculadora.min = (int)(-grafico_center.X * grafico_scale.X);
                calculadora.max = (int)((pb_grafico.Width - grafico_center.X) * grafico_scale.X);
                txt_a_calcular.Text = calculadora.Calcular().ToString();

                DesenharGrafico();
            };
        }

        private void InitializeGraphicComboBoxes()
        { 
            cb_x.Items.Clear();
            foreach (var name in txts.Values)
            {
                cb_x.Items.Add(name);
            }
            cb_x.SelectedIndexChanged -= cb_x_SelectedIndexChanged;
            cb_x.SelectedIndex = 0;
            cb_x.SelectedIndexChanged += cb_x_SelectedIndexChanged;

            cb_y.Items.Clear();
            int? cant_be = null;
            for (int i = 0; i < txts.Count; i++)
            {
                var name = txts.ToList()[i].Value;
                if (name != Calculadora.Variavel.T && name != Calculadora.Variavel.N)
                {
                    var position_inserted = cb_y.Items.Add(name);
                    if (name == VariavelGraficoX()) cant_be = position_inserted;
                }
            }
            cb_y.SelectedIndexChanged -= cb_y_SelectedIndexChanged;
            if (cant_be == cb_y.Items.Count - 1)
                cb_y.SelectedIndex = cant_be.Value - 1;
            else
                cb_y.SelectedIndex = cant_be.Value + 1;
            cb_y.SelectedIndexChanged += cb_y_SelectedIndexChanged;
        }

        private bool ConstruirCalculadora()
        {
            if (txt_a_calcular != null) txt_a_calcular.BackColor = txt_a_calcular_prev_back_color;
            int parcelas_invalidas = 0;
            if (!double.TryParse(txt_p.Text, out double p)) 
            {
                parcelas_invalidas++;
                txt_a_calcular = txt_p;
                if (txt_p.Text.Length != 0) {
                    MessageBox.Show("Prestação deverá ser um numero racional!");
                    return false;
                }
            }
            if (!double.TryParse(txt_t.Text, out double t))
            {
                parcelas_invalidas++;
                txt_a_calcular = txt_t;
                if (txt_t.Text.Length != 0) {
                    MessageBox.Show("Taxa deverá ser um numero racional!");
                    return false;
                }
            }
            if (!double.TryParse(txt_v.Text, out double v)) 
            {
                parcelas_invalidas++;
                txt_a_calcular = txt_v;
                if (txt_v.Text.Length != 0)
                {
                    MessageBox.Show("Valor deverá ser um numero racional!");
                    return false;
                }
            }
            if (!double.TryParse(txt_n.Text, out double n) || n <= 0) 
            {
                parcelas_invalidas++;
                txt_a_calcular = txt_n;
                if (txt_n.Text.Length != 0)
                {
                    MessageBox.Show("Número de períodos deverá ser um numero racional positivo!");
                    return false;
                }
            }

            if (parcelas_invalidas == 1 || parcelas_invalidas == 0 && txt_a_calcular != null) {
                txt_a_calcular_prev_back_color = txt_a_calcular.BackColor;
                txt_a_calcular.BackColor = Color.LightGreen;
                var min = -grafico_center.X * grafico_scale.X;
                var max = (pb_grafico.Width - grafico_center.X) * grafico_scale.X;
                calculadora = new Calculadora(p, t, v, n, txts[txt_a_calcular], grafico_scale.X, (int)min, (int)max);
                return true;
            }

            var prev_color = lbl_msg.ForeColor;
            lbl_msg.ForeColor = Color.Red;
            lbl_msg_timer.Interval = 1000;
            lbl_msg_timer.Tick += (a, b) =>
            {
                lbl_msg.ForeColor = prev_color;
                lbl_msg_timer.Stop();
            };
            lbl_msg_timer.Start();

            return false;
        }

        private Calculadora.Variavel VariavelGraficoX()
        {
            return (Calculadora.Variavel)Enum.Parse(typeof(Calculadora.Variavel), cb_x.Text);
        }

        private Calculadora.Variavel VariavelGraficoY()
        {
            return (Calculadora.Variavel)Enum.Parse(typeof(Calculadora.Variavel), cb_y.Text);
        }

        private void DesenharGrafico()
        { 
            calculadora.DesenharGrafico(pb_grafico, grafico_scale, grafico_center, VariavelGraficoX(), VariavelGraficoY(), (int)nud_div.Value);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (!ConstruirCalculadora()) return;
            txt_a_calcular.Text = calculadora.Calcular().ToString();

            DesenharGrafico();

            pb_grafico.Visible = true;
            btn_reset_center.Visible = true;
            btn_reset_sx.Visible = true;
            btn_reset_sy.Visible = true;
            lbl_x.Visible = true;
            cb_x.Visible = true;
            lbl_y.Visible = true;
            cb_y.Visible = true;
            lbl_div.Visible = true;
            nud_div.Visible = true;
        }

        private void pb_grafico_MouseDown(object sender, MouseEventArgs e)
        {
            grafico_mouse_dragging = true;
            grafico_mouse_start = new Point(e.X, e.Y);
            grafico_mouse_start_center = grafico_center;
        }

        private void pb_grafico_MouseUp(object sender, MouseEventArgs e)
        {
            grafico_mouse_dragging = false;
        }

        private void pb_grafico_MouseMove(object sender, MouseEventArgs e)
        {
            if (grafico_mouse_dragging && grafico_mouse_start != null)
            {
                grafico_center.X = e.X - grafico_mouse_start.X + grafico_mouse_start_center.X;
                grafico_center.Y = e.Y - grafico_mouse_start.Y + grafico_mouse_start_center.Y;

                calculadora.min = (int)(-grafico_center.X * grafico_scale.X);
                calculadora.max = (int)((pb_grafico.Width - grafico_center.X) * grafico_scale.X);
                txt_a_calcular.Text = calculadora.Calcular().ToString();

                DesenharGrafico();
            }
        }

        private void btn_reset_center_Click(object sender, EventArgs e)
        {
            grafico_center = new Point(pb_grafico.Width / 2, pb_grafico.Height / 2);
            DesenharGrafico();
        }

        private void btn_reset_sx_Click(object sender, EventArgs e)
        {
            grafico_scale.X = 1;
            DesenharGrafico();
        }

        private void btn_reset_sy_Click(object sender, EventArgs e)
        {
            grafico_scale.Y = 1;
            DesenharGrafico();
        }

        private void cb_x_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prev_name = VariavelGraficoY();
            int? cant_be = null;
            int? must_be = null;

            cb_y.Items.Clear();
            for (int i = 0; i < txts.Count; i++)
            {
                var name = txts.Values.ToList()[i];
                if (name != Calculadora.Variavel.T && name != Calculadora.Variavel.N)
                {
                    var position_inserted = cb_y.Items.Add(name);
                    if (name == VariavelGraficoX()) cant_be = position_inserted;
                    if (name == prev_name) must_be = position_inserted;
                }
            }

            cb_y.SelectedIndexChanged -= cb_y_SelectedIndexChanged;
            if (must_be != cant_be)
            { 
                cb_y.SelectedIndex = must_be.Value;
            }
            else
            { 
                if (cant_be == cb_y.Items.Count - 1)
                    cb_y.SelectedIndex = cant_be.Value - 1;
                else
                    cb_y.SelectedIndex = cant_be.Value + 1;
            }
            cb_y.SelectedIndexChanged += cb_y_SelectedIndexChanged;

            DesenharGrafico();
        }

        private void cb_y_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prev_name = VariavelGraficoX();
            int? cant_be = null;
            int? must_be = null;

            cb_x.Items.Clear();
            for (int i = 0; i < txts.Count; i++)
            {
                var name = txts.Values.ToList()[i];
                if (name == VariavelGraficoY()) cant_be = i;
                if (name == prev_name) must_be = i;
                cb_x.Items.Add(name);
            }

            cb_x.SelectedIndexChanged -= cb_x_SelectedIndexChanged;
            if (must_be != cant_be)
            { 
                cb_x.SelectedIndex = must_be.Value;
            }
            else
            { 
                if (cant_be == cb_x.Items.Count - 1)
                    cb_x.SelectedIndex = cant_be.Value - 1;
                else
                    cb_x.SelectedIndex = cant_be.Value + 1;
            }
            cb_x.SelectedIndexChanged += cb_x_SelectedIndexChanged;

            DesenharGrafico();
        }

        private void nud_div_ValueChanged(object sender, EventArgs e)
        {
            DesenharGrafico();
        }
    }
}
