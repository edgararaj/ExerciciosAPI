using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public struct MyDate : IComparable
{
    int month, year;

    public MyDate(int month, int year)
    {
        this.month = month;
        this.year = year;
    }

    public int CompareTo(object other)
    {
        var year_compare = year.CompareTo(((MyDate)other).year);
        if (year_compare == 0)
            return month.CompareTo(((MyDate)other).month);
        else return year_compare;
    }

    public override string ToString()
    {
        return $"{month}/{year}";
    }
}

namespace EndesaStyle
{
    public partial class Principal : Form
    {
        SortedDictionary<MyDate, double> consumos = new SortedDictionary<MyDate, double> {};

        private void add_consumos_to_list_view()
        {
            foreach (var item in consumos)
            {
                var list_view_item = list_view.Items.Add(item.Key.ToString());
                list_view_item.Tag = item.Key;
                list_view_item.SubItems.Add(item.Value.ToString());
            }
        }

        public Principal()
        {
            InitializeComponent();
            realces.Add(add_realce(Color.Red, Realce.Comparacao.ValorMaior));
            realces.Add(add_realce(Color.Green, Realce.Comparacao.ValorMenor));
        }

        private void mostrar_estatisticas()
        {
            if (list_view.SelectedItems.Count > 0)
            {
                var consumo_total_sel_num = list_view.SelectedItems.Cast<ListViewItem>().Sum(x => consumos[(MyDate)x.Tag]);
                consumo_total_sel.Text = consumo_total_sel_num.ToString();
                consumo_medio_sel.Text = (consumo_total_sel_num / list_view.SelectedItems.Count).ToString();
            }
            else
            {
                consumo_total_sel.Clear();
                consumo_medio_sel.Clear();
            }

            if (consumos.Count > 0)
            {
                var consumo_total_num = consumos.Sum(x => x.Value);
                consumo_total.Text = consumo_total_num.ToString();
                consumo_medio.Text = (consumo_total_num / consumos.Count).ToString();
            }
            else
            {
                consumo_total.Clear();
                consumo_medio.Clear();
            }
        }

        class Realce {
            public enum Comparacao { 
                ValorMaiorA,
                ValorMenorA,
                ValorIgualA,
                ValorMaior,
                ValorMenor,
            }
            public Label lb_realcar_a = new Label();
            public Button bt_cor = new Button();
            public ComboBox cb_tipo = new ComboBox();
            public Label lb_a = new Label();
            public NumericUpDown nu_valor = new NumericUpDown();
            public Button bt_apagar = new Button();
        }

        List<Realce> realces = new List<Realce>();

        private Realce add_realce(Color color, Realce.Comparacao comp, double valor = 0)
        {
            var realce = new Realce();
            // 
            // lb_realcar_a
            // 
            realce.lb_realcar_a.AutoSize = true;
            realce.lb_realcar_a.Location = new System.Drawing.Point(3, 0);
            realce.lb_realcar_a.Name = "lb_realcar_a";
            realce.lb_realcar_a.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            realce.lb_realcar_a.Size = new System.Drawing.Size(53, 20);
            realce.lb_realcar_a.TabIndex = 0;
            realce.lb_realcar_a.Text = "Realçar a";
            // 
            // bt_cor
            // 
            realce.bt_cor.Location = new System.Drawing.Point(62, 3);
            realce.bt_cor.Name = "bt_cor";
            realce.bt_cor.Size = new System.Drawing.Size(75, 23);
            realce.bt_cor.TabIndex = 1;
            realce.bt_cor.Text = "Cor";
            realce.bt_cor.UseVisualStyleBackColor = true;
            realce.bt_cor.Click += (s, e) =>
            {
                colorDialog1.ShowDialog();
                realce.bt_cor.BackColor = colorDialog1.Color;
                realce.bt_cor.ForeColor = getContrastyColor(colorDialog1.Color);
                clear_filters();
                foreach (var arroz in realces)
                    update_filter(arroz);
            };
            // 
            // cb_tipo
            // 
            realce.cb_tipo.FormattingEnabled = true;
            realce.cb_tipo.Location = new System.Drawing.Point(143, 3);
            realce.cb_tipo.Name = "cb_tipo";
            realce.cb_tipo.Size = new System.Drawing.Size(126, 21);
            realce.cb_tipo.TabIndex = 2;
            realce.cb_tipo.Items.AddRange(new object[] {
            "valores superiores",
            "valores inferiores",
            "valores iguais",
            "o maior valor",
            "o menor valor"});
            realce.cb_tipo.SelectedValueChanged += (s, e) =>
            {
                if (realce.cb_tipo.SelectedIndex == (int)Realce.Comparacao.ValorMaior || realce.cb_tipo.SelectedIndex == (int)Realce.Comparacao.ValorMenor)
                { 
                    realce.lb_a.Enabled = false;
                    realce.nu_valor.Enabled = false;
                }
                else
                {
                    realce.lb_a.Enabled = true;
                    realce.nu_valor.Enabled = true;
                }

                clear_filters();
                foreach (var arroz in realces)
                    update_filter(arroz);
            };
            // 
            // lb_a
            // 
            realce.lb_a.AutoSize = true;
            realce.lb_a.Location = new System.Drawing.Point(275, 0);
            realce.lb_a.Name = "lb_a";
            realce.lb_a.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            realce.lb_a.Size = new System.Drawing.Size(13, 20);
            realce.lb_a.TabIndex = 3;
            realce.lb_a.Text = "a";
            // 
            // nu_valor
            // 
            realce.nu_valor.Location = new System.Drawing.Point(294, 3);
            realce.nu_valor.Name = "nu_valor";
            realce.nu_valor.Size = new System.Drawing.Size(120, 20);
            realce.nu_valor.TabIndex = 4;
            realce.nu_valor.DecimalPlaces = 3;
            realce.nu_valor.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            realce.nu_valor.ValueChanged += (s, e) =>
            {
                clear_filters();
                foreach (var arroz in realces)
                    update_filter(arroz);
            };
            // 
            // bt_apagar
            // 
            realce.bt_apagar.BackColor = System.Drawing.SystemColors.Control;
            realce.bt_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            realce.bt_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            realce.bt_apagar.ForeColor = System.Drawing.Color.Red;
            realce.bt_apagar.Location = new System.Drawing.Point(420, 3);
            realce.bt_apagar.Name = "bt_apagar";
            realce.bt_apagar.Size = new System.Drawing.Size(19, 20);
            realce.bt_apagar.TabIndex = 5;
            realce.bt_apagar.Text = "X";
            realce.bt_apagar.UseVisualStyleBackColor = false;
            realce.bt_apagar.Click += (s, e) =>
            {
                realce_view.Controls.Remove(realce.lb_realcar_a);
                realce_view.Controls.Remove(realce.bt_cor);
                realce_view.Controls.Remove(realce.cb_tipo);
                realce_view.Controls.Remove(realce.lb_a);
                realce_view.Controls.Remove(realce.nu_valor);
                realce_view.Controls.Remove(realce.bt_apagar);
                realces.Remove(realce);
                clear_filters();
                foreach (var arroz in realces)
                    update_filter(arroz);
            };

            realce_view.Controls.Add(realce.lb_realcar_a);
            realce_view.Controls.Add(realce.bt_cor);
            realce_view.Controls.Add(realce.cb_tipo);
            realce_view.Controls.Add(realce.lb_a);
            realce_view.Controls.Add(realce.nu_valor);
            realce_view.Controls.Add(realce.bt_apagar);

            realce.bt_cor.BackColor = color;
            realce.bt_cor.ForeColor = getContrastyColor(color);
            if (comp == Realce.Comparacao.ValorMaior || comp == Realce.Comparacao.ValorMenor)
            {
                realce.lb_a.Enabled = false;
                realce.nu_valor.Enabled = false;
            }

            realce.nu_valor.Value = (decimal)valor;

            realce.cb_tipo.SelectedIndex = (int)comp;

            return realce;
        }

        private void clear_filters()
        {
            foreach (var item in list_view.Items)
            {
                ((ListViewItem)item).BackColor = Color.White;
                ((ListViewItem)item).ForeColor = Color.Black;
            }
        }

        private void update_filter(Realce realce)
        {
            if (consumos.Count > 0)
            {
                var comp = (Realce.Comparacao)realce.cb_tipo.SelectedIndex;

                var lista_a_realcar = new List<KeyValuePair<MyDate, double>>();
                switch (comp)
                {
                    case Realce.Comparacao.ValorMaior:
                        lista_a_realcar = consumos.Where(x => x.Value == consumos.Values.Max()).ToList();
                        if (lista_a_realcar.Count == consumos.Count) return;
                        break;

                    case Realce.Comparacao.ValorMenor:
                        lista_a_realcar = consumos.Where(x => x.Value == consumos.Values.Min()).ToList();
                        if (lista_a_realcar.Count == consumos.Count) return;
                        break;

                    case Realce.Comparacao.ValorIgualA:
                        lista_a_realcar = consumos.Where(x => x.Value == (double)realce.nu_valor.Value).ToList();
                        break;

                    case Realce.Comparacao.ValorMaiorA:
                        lista_a_realcar = consumos.Where(x => x.Value > (double)realce.nu_valor.Value).ToList();
                        break;

                    case Realce.Comparacao.ValorMenorA:
                        lista_a_realcar = consumos.Where(x => x.Value < (double)realce.nu_valor.Value).ToList();
                        break;
                }

                foreach (var consumo in lista_a_realcar)
                {
                    var max_index = consumos.Keys.ToList().IndexOf(consumo.Key);
                    list_view.Items[max_index].BackColor = realce.bt_cor.BackColor;
                    list_view.Items[max_index].ForeColor = realce.bt_cor.ForeColor;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registar_form = new Registar(consumos);
            registar_form.ShowDialog();
            list_view.Items.Clear();
            add_consumos_to_list_view();
            foreach (var filter in realces)
                update_filter(filter);
            mostrar_estatisticas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list_view.SelectedItems.Count == 1)
            {
                var item = list_view.SelectedItems[0];
                var item_index = item.Index;
                consumos.Remove((MyDate)item.Tag);
                list_view.Items.Remove(item);
                if (item_index < list_view.Items.Count)
                    list_view.Items[item_index].Selected = true;
                else if (item_index - 1 >= 0)
                    list_view.Items[item_index - 1].Selected = true;
            }
            else
                foreach (ListViewItem item in list_view.SelectedItems)
                {
                    consumos.Remove((MyDate)item.Tag);
                    list_view.Items.Remove(item);
                }

            foreach (var arroz in realces)
                update_filter(arroz);

            mostrar_estatisticas();
        }

        private void list_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrar_estatisticas();
        }

        private void nud_ult_meses_ValueChanged(object sender, EventArgs e)
        {
            var ult_meses = (int)nud_ult_meses.Value;
            var skip = consumos.Count - ult_meses;
            if (skip >= 0 && ult_meses > 0)
            {
                consumo_ult_meses.Text = (consumos.Skip(skip).Sum(x => x.Value) / ult_meses).ToString();
            }
            else
                consumo_ult_meses.Clear();
        }

        private Color getContrastyColor(Color color)
        {
            return color.GetBrightness() >= 0.5 ? Color.Black : Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var realce = add_realce(Color.Black, Realce.Comparacao.ValorIgualA);
            realces.Add(realce);
            update_filter(realce);
        }
    }
}
