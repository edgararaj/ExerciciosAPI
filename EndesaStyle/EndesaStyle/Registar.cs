using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndesaStyle
{
    public partial class Registar : Form
    {
        SortedDictionary<MyDate, double> consumos;

        public Registar(SortedDictionary<MyDate, double> consumos)
        {
            this.consumos = consumos;
            InitializeComponent();
            add_month_entry(dateTimePicker1.Value);
        }

        List<DateTimePicker> dtp_list = new List<DateTimePicker>();
        List<NumericUpDown> nud_list = new List<NumericUpDown>();

        public void add_month_entry(DateTime value)
        { 
            var dtp = new System.Windows.Forms.DateTimePicker();
            var nud = new System.Windows.Forms.NumericUpDown();
            // 
            // dtp_first
            // 
            dtp.CustomFormat = "MMMM \'de\' yyyy";
            dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtp.Location = new System.Drawing.Point(3, 3);
            dtp.Size = new System.Drawing.Size(166, 20);
            dtp.TabIndex = 4;
            dtp.Value = value;
            // 
            // nud_first
            // 
            nud.DecimalPlaces = 3;
            nud.Location = new System.Drawing.Point(175, 3);
            nud.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nud.Size = new System.Drawing.Size(120, 20);
            nud.TabIndex = 1;

            list_view.Controls.Add(dtp);
            dtp_list.Add(dtp);
            list_view.Controls.Add(nud);
            nud_list.Add(nud);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var num_meses = (int)numericUpDown1.Value;

            var meses_delta = num_meses - list_view.Controls.Count / 2;
            for (int i = 0; i < Math.Abs(meses_delta); i++)
            {
                if (meses_delta > 0)
                    add_month_entry(dtp_list.Last().Value.AddMonths(1));
                else
                {
                    list_view.Controls.RemoveAt(list_view.Controls.Count - 1); // remove nud
                    nud_list.RemoveAt(nud_list.Count - 1);
                    list_view.Controls.RemoveAt(list_view.Controls.Count - 1); // remove dtp
                    dtp_list.RemoveAt(dtp_list.Count - 1);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtp_list.Count; i++)
                dtp_list[i].Value = dateTimePicker1.Value.AddMonths(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<MyDate, double> new_elements = new Dictionary<MyDate, double>();
            dtp_list.Zip(nud_list, (k, v) => new { k = new MyDate(k.Value.Month, k.Value.Year), v = (double)v.Value }).ToList().ForEach(x => new_elements[x.k] = x.v);
            var elementos_ja_inseridos = new_elements.Where(x => consumos.Contains(x)).Select(x => x.Key.ToString()).ToList();
            if (elementos_ja_inseridos.Count > 1)
            {
                var result = MessageBox.Show($"Os mêses de {string.Join(", ", elementos_ja_inseridos)} já foram registados!\nDeseja alteralos?", "Registos existentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) return;
            }
            else if (elementos_ja_inseridos.Count == 1)
            { 
                var result = MessageBox.Show($"O mês de {elementos_ja_inseridos[0]} já foi registado!\nDeseja alteralo?", "Registo existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) return;
            }
            new_elements.ToList().ForEach(x => consumos[x.Key] = x.Value);
            Close();
        }
    }
}
