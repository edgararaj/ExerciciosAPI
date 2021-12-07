namespace EndesaStyle
{
    partial class Principal
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
            this.list_view = new System.Windows.Forms.ListView();
            this.ch_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_consumo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.consumo_total = new System.Windows.Forms.TextBox();
            this.consumo_total_sel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.consumo_medio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.consumo_medio_sel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_ult_meses = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.consumo_ult_meses = new System.Windows.Forms.TextBox();
            this.realce_view = new System.Windows.Forms.FlowLayoutPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ult_meses)).BeginInit();
            this.SuspendLayout();
            // 
            // list_view
            // 
            this.list_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_data,
            this.ch_consumo});
            this.list_view.FullRowSelect = true;
            this.list_view.GridLines = true;
            this.list_view.HideSelection = false;
            this.list_view.Location = new System.Drawing.Point(28, 72);
            this.list_view.Name = "list_view";
            this.list_view.Size = new System.Drawing.Size(289, 469);
            this.list_view.TabIndex = 0;
            this.list_view.UseCompatibleStateImageBehavior = false;
            this.list_view.View = System.Windows.Forms.View.Details;
            this.list_view.SelectedIndexChanged += new System.EventHandler(this.list_view_SelectedIndexChanged);
            // 
            // ch_data
            // 
            this.ch_data.Text = "Data";
            this.ch_data.Width = 109;
            // 
            // ch_consumo
            // 
            this.ch_consumo.Text = "Consumo";
            this.ch_consumo.Width = 138;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registo de consumos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(343, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 627);
            this.label2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estatísticas";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(181, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Consumo Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Consumo Total (Selecionado):";
            // 
            // consumo_total
            // 
            this.consumo_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consumo_total.Location = new System.Drawing.Point(617, 84);
            this.consumo_total.Name = "consumo_total";
            this.consumo_total.ReadOnly = true;
            this.consumo_total.Size = new System.Drawing.Size(220, 20);
            this.consumo_total.TabIndex = 5;
            // 
            // consumo_total_sel
            // 
            this.consumo_total_sel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consumo_total_sel.Location = new System.Drawing.Point(617, 118);
            this.consumo_total_sel.Name = "consumo_total_sel";
            this.consumo_total_sel.ReadOnly = true;
            this.consumo_total_sel.Size = new System.Drawing.Size(220, 20);
            this.consumo_total_sel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Consumo Médio:";
            // 
            // consumo_medio
            // 
            this.consumo_medio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consumo_medio.Location = new System.Drawing.Point(617, 154);
            this.consumo_medio.Name = "consumo_medio";
            this.consumo_medio.ReadOnly = true;
            this.consumo_medio.Size = new System.Drawing.Size(220, 20);
            this.consumo_medio.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Consumo Médio (Selecionado):";
            // 
            // consumo_medio_sel
            // 
            this.consumo_medio_sel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consumo_medio_sel.Location = new System.Drawing.Point(617, 190);
            this.consumo_medio_sel.Name = "consumo_medio_sel";
            this.consumo_medio_sel.ReadOnly = true;
            this.consumo_medio_sel.Size = new System.Drawing.Size(220, 20);
            this.consumo_medio_sel.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Média dos últimos";
            // 
            // nud_ult_meses
            // 
            this.nud_ult_meses.Location = new System.Drawing.Point(491, 228);
            this.nud_ult_meses.Name = "nud_ult_meses";
            this.nud_ult_meses.Size = new System.Drawing.Size(51, 20);
            this.nud_ult_meses.TabIndex = 7;
            this.nud_ult_meses.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_ult_meses.ValueChanged += new System.EventHandler(this.nud_ult_meses_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "meses:";
            // 
            // consumo_ult_meses
            // 
            this.consumo_ult_meses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consumo_ult_meses.Location = new System.Drawing.Point(617, 227);
            this.consumo_ult_meses.Name = "consumo_ult_meses";
            this.consumo_ult_meses.ReadOnly = true;
            this.consumo_ult_meses.Size = new System.Drawing.Size(220, 20);
            this.consumo_ult_meses.TabIndex = 5;
            // 
            // realce_view
            // 
            this.realce_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.realce_view.AutoScroll = true;
            this.realce_view.Location = new System.Drawing.Point(387, 284);
            this.realce_view.Name = "realce_view";
            this.realce_view.Size = new System.Drawing.Size(467, 246);
            this.realce_view.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(533, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 42);
            this.button3.TabIndex = 10;
            this.button3.Text = "Adicionar Realce";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 624);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.realce_view);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nud_ult_meses);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.consumo_ult_meses);
            this.Controls.Add(this.consumo_medio_sel);
            this.Controls.Add(this.consumo_medio);
            this.Controls.Add(this.consumo_total_sel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.consumo_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_view);
            this.Name = "Principal";
            this.Text = "EletricidadeTaCara";
            ((System.ComponentModel.ISupportInitialize)(this.nud_ult_meses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_view;
        private System.Windows.Forms.ColumnHeader ch_data;
        private System.Windows.Forms.ColumnHeader ch_consumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox consumo_total;
        private System.Windows.Forms.TextBox consumo_total_sel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox consumo_medio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox consumo_medio_sel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_ult_meses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox consumo_ult_meses;
        private System.Windows.Forms.FlowLayoutPanel realce_view;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button3;
    }
}

