using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_sexo.SelectedIndex = 0;

            // rotate img
            var img = pb_indicador_cintura.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pb_indicador_cintura.Image = img;
        }

        private void bt_imc_Click(object sender, EventArgs e)
        {
            var peso = (double)nud_peso.Value;
            var altura = (double)nud_altura.Value;
            if (altura > 0 && peso > 0)
            {
                // calcular o imc 
                double imc = peso / (altura * altura);
                string text_final = String.Format("O teu IMC é de {0:0.000} ", imc);
                var regua_start = pb_regua.Location.X + 7;
                if (imc < 18.5)
                {
                    text_final = text_final + "(Peso Baixo)";
                    lbl_imc.ForeColor = Color.Blue;
                    pb_indicador.Location = new Point((int)(regua_start + (imc / 18.5 * 61) - (pb_indicador.Size.Width / 2)), pb_indicador.Location.Y);
                }
                else if (imc < 25)
                {
                    text_final = text_final + "(Peso Normal)";
                    lbl_imc.ForeColor = Color.Green;
                    pb_indicador.Location = new Point((int)(regua_start + 61 + ((imc - 18.5) / (25 - 18.5) * 139) - (pb_indicador.Size.Width / 2)), pb_indicador.Location.Y);
                }
                else if (imc < 30)
                {
                    text_final = text_final + "(Peso Excessivo)";
                    lbl_imc.ForeColor = Color.Orange;
                    pb_indicador.Location = new Point((int)(regua_start + 61 + 139 + ((imc - 25) / (30 - 25) * 69) - (pb_indicador.Size.Width / 2)), pb_indicador.Location.Y);
                }
                else if (imc < 35)
                {
                    text_final = text_final + "(Obesidade Grau I)";
                    lbl_imc.ForeColor = Color.Red;
                    pb_indicador.Location = new Point((int)(regua_start + 61 + 139 + 69 + ((imc - 30) / (35 - 30) * 48) - (pb_indicador.Size.Width / 2)), pb_indicador.Location.Y);
                }
                else if (imc < 40)
                { 
                    text_final = text_final + "(Obesidade Grau II)";
                    lbl_imc.ForeColor = Color.Red;
                    pb_indicador.Location = new Point((int)(regua_start + 61 + 139 + 69 + 48 + ((imc - 35) / (40 - 35) * 45) - (pb_indicador.Size.Width / 2)), pb_indicador.Location.Y);
                }
                else
                { 
                    text_final = text_final + "(Obesidade Grau III)";
                    lbl_imc.ForeColor = Color.Red;
                    var coeficient = (imc - 40) / (50 - 40);
                    pb_indicador.Location = new Point((int)(regua_start + 61 + 139 + 69 + 48 + 45 + ((coeficient > 1 ? 1 : coeficient) * 24) - (pb_indicador.Size.Width / 2)), pb_indicador.Location.Y);
                }
                lbl_imc.Text = text_final;
                pb_indicador.Visible = true;
            }
            else {
                pb_indicador.Visible = false;
                lbl_imc.ForeColor = Color.Red;
                if (altura <= 0 && peso <= 0)
                { 
                    lbl_imc.Text = "Altura e Peso inválidos!";
                }
                else if (altura <= 0)
                {
                    nud_altura.Focus();
                    lbl_imc.Text = "Altura inválida!";
                }
                else
                { 
                    nud_peso.Focus();
                    lbl_imc.Text = "Peso inválido!";
                }
            }
        }

        private void calcular_icq(bool show_error)
        { 
            var cintura = (double)nud_cintura.Value;
            var quadril = (double)nud_quadril.Value;
            var sexo = cb_sexo.SelectedIndex;
            if (cintura > 0 && quadril > 0)
            {
                // calcular o icq
                double icq = cintura / quadril;
                string text_final = String.Format("O teu ICQ é de {0:0.000}", icq);
                bool icq_mau = false;
                bool cintura_mau = false;
                double target_icq = sexo == 0 ? 1 : 0.8;
                double target_cintura = sexo == 0 ? 102 : 80;
                if (sexo == 0 && icq > target_icq || sexo == 1 && icq > target_icq)
                {
                    icq_mau = true;
                    text_final += " (Excede o recomendado!)";
                }
                if (sexo == 0 && cintura > target_cintura || sexo == 1 && cintura > target_cintura)
                {
                    cintura_mau = true;
                    text_final += "\nPerímetro da cintura excede o recomendado!";
                }

                if (icq_mau && cintura_mau)
                    lbl_icq.ForeColor = Color.Red;
                else if (icq_mau || cintura_mau)
                    lbl_icq.ForeColor = Color.Orange;
                else
                    lbl_icq.ForeColor = Color.Green;

                var icq_coeficient = icq / target_icq;
                pb_indicador_icq.Location = new Point((int)(pb_regua_icq.Location.X + 7 + ((icq_coeficient > 2 ? 2 : icq_coeficient) * 193) - (pb_indicador_icq.Size.Width / 2)), pb_indicador_icq.Location.Y);
                pb_indicador_icq.Visible = true;
                var cintura_coeficient = cintura / target_cintura;
                pb_indicador_cintura.Location = new Point((int)(pb_regua_icq.Location.X + 7 + ((cintura_coeficient > 2 ? 2 : cintura_coeficient) * 193) - (pb_indicador_cintura.Size.Width / 2)), pb_indicador_cintura.Location.Y);
                pb_indicador_cintura.Visible = true;
                lbl_icq.Text = text_final;
            }
            else if (show_error) {
                pb_indicador_icq.Visible = false;
                pb_indicador_cintura.Visible = false;
                lbl_icq.ForeColor = Color.Red;
                if (cintura <= 0 && quadril <= 0)
                { 
                    lbl_icq.Text = "Perímetro da Cintura e do Quadril inválidos!";
                }
                else if (cintura <= 0)
                {
                    nud_cintura.Focus();
                    lbl_icq.Text = "Perímetro da Cintura inválido!";
                }
                else
                { 
                    nud_quadril.Focus();
                    lbl_icq.Text = "Perímetro do Quadril inválido!";
                }
            }
        }

        private void bt_icq_Click(object sender, EventArgs e)
        {
            calcular_icq(true);
        }

        private void cb_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sexo.SelectedIndex == 0)
                pb_regua_icq.Image = Properties.Resources.regua_icq_masculino;
            else 
                pb_regua_icq.Image = Properties.Resources.regua_icq_feminino;

            calcular_icq(false);
        }
    }
}
