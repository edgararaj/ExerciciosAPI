namespace CalculadoraIMC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pb_regua = new System.Windows.Forms.PictureBox();
            this.pb_indicador = new System.Windows.Forms.PictureBox();
            this.nud_altura = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_peso = new System.Windows.Forms.NumericUpDown();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pb_regua_icq = new System.Windows.Forms.PictureBox();
            this.pb_indicador_cintura = new System.Windows.Forms.PictureBox();
            this.pb_indicador_icq = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_icq = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.nud_quadril = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_cintura = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_regua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indicador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_peso)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_regua_icq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indicador_cintura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indicador_icq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quadril)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cintura)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 452);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pb_regua);
            this.tabPage1.Controls.Add(this.pb_indicador);
            this.tabPage1.Controls.Add(this.nud_altura);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nud_peso);
            this.tabPage1.Controls.Add(this.lbl_imc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IMC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pb_regua
            // 
            this.pb_regua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_regua.Image = ((System.Drawing.Image)(resources.GetObject("pb_regua.Image")));
            this.pb_regua.Location = new System.Drawing.Point(18, 321);
            this.pb_regua.Name = "pb_regua";
            this.pb_regua.Size = new System.Drawing.Size(400, 70);
            this.pb_regua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_regua.TabIndex = 26;
            this.pb_regua.TabStop = false;
            // 
            // pb_indicador
            // 
            this.pb_indicador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_indicador.Image = ((System.Drawing.Image)(resources.GetObject("pb_indicador.Image")));
            this.pb_indicador.Location = new System.Drawing.Point(216, 298);
            this.pb_indicador.Name = "pb_indicador";
            this.pb_indicador.Size = new System.Drawing.Size(18, 24);
            this.pb_indicador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_indicador.TabIndex = 23;
            this.pb_indicador.TabStop = false;
            this.pb_indicador.Visible = false;
            // 
            // nud_altura
            // 
            this.nud_altura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_altura.DecimalPlaces = 3;
            this.nud_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_altura.Location = new System.Drawing.Point(135, 148);
            this.nud_altura.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_altura.Name = "nud_altura";
            this.nud_altura.Size = new System.Drawing.Size(207, 26);
            this.nud_altura.TabIndex = 24;
            this.nud_altura.ValueChanged += new System.EventHandler(this.bt_imc_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Altura (m)";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Calculadora IMC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Peso (kg)";
            // 
            // nud_peso
            // 
            this.nud_peso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_peso.DecimalPlaces = 3;
            this.nud_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_peso.Location = new System.Drawing.Point(135, 104);
            this.nud_peso.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_peso.Name = "nud_peso";
            this.nud_peso.Size = new System.Drawing.Size(207, 26);
            this.nud_peso.TabIndex = 25;
            this.nud_peso.ValueChanged += new System.EventHandler(this.bt_imc_Click);
            // 
            // lbl_imc
            // 
            this.lbl_imc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imc.Location = new System.Drawing.Point(18, 225);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(400, 20);
            this.lbl_imc.TabIndex = 22;
            this.lbl_imc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pb_regua_icq);
            this.tabPage2.Controls.Add(this.pb_indicador_cintura);
            this.tabPage2.Controls.Add(this.pb_indicador_icq);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lbl_icq);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cb_sexo);
            this.tabPage2.Controls.Add(this.nud_quadril);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.nud_cintura);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ICQ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pb_regua_icq
            // 
            this.pb_regua_icq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_regua_icq.Image = global::CalculadoraIMC.Properties.Resources.regua_icq_masculino;
            this.pb_regua_icq.Location = new System.Drawing.Point(18, 298);
            this.pb_regua_icq.Name = "pb_regua_icq";
            this.pb_regua_icq.Size = new System.Drawing.Size(400, 90);
            this.pb_regua_icq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_regua_icq.TabIndex = 45;
            this.pb_regua_icq.TabStop = false;
            // 
            // pb_indicador_cintura
            // 
            this.pb_indicador_cintura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_indicador_cintura.Image = ((System.Drawing.Image)(resources.GetObject("pb_indicador_cintura.Image")));
            this.pb_indicador_cintura.Location = new System.Drawing.Point(209, 388);
            this.pb_indicador_cintura.Name = "pb_indicador_cintura";
            this.pb_indicador_cintura.Size = new System.Drawing.Size(18, 24);
            this.pb_indicador_cintura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_indicador_cintura.TabIndex = 44;
            this.pb_indicador_cintura.TabStop = false;
            this.pb_indicador_cintura.Visible = false;
            // 
            // pb_indicador_icq
            // 
            this.pb_indicador_icq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_indicador_icq.Image = ((System.Drawing.Image)(resources.GetObject("pb_indicador_icq.Image")));
            this.pb_indicador_icq.Location = new System.Drawing.Point(209, 275);
            this.pb_indicador_icq.Name = "pb_indicador_icq";
            this.pb_indicador_icq.Size = new System.Drawing.Size(18, 24);
            this.pb_indicador_icq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_indicador_icq.TabIndex = 44;
            this.pb_indicador_icq.TabStop = false;
            this.pb_indicador_icq.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Calculadora ICQ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_icq
            // 
            this.lbl_icq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_icq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_icq.Location = new System.Drawing.Point(18, 202);
            this.lbl_icq.Name = "lbl_icq";
            this.lbl_icq.Size = new System.Drawing.Size(400, 50);
            this.lbl_icq.TabIndex = 43;
            this.lbl_icq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "Sexo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_sexo
            // 
            this.cb_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_sexo.Location = new System.Drawing.Point(276, 134);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(121, 28);
            this.cb_sexo.TabIndex = 40;
            this.cb_sexo.SelectedIndexChanged += new System.EventHandler(this.cb_sexo_SelectedIndexChanged);
            // 
            // nud_quadril
            // 
            this.nud_quadril.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_quadril.DecimalPlaces = 3;
            this.nud_quadril.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_quadril.Location = new System.Drawing.Point(135, 148);
            this.nud_quadril.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_quadril.Name = "nud_quadril";
            this.nud_quadril.Size = new System.Drawing.Size(115, 26);
            this.nud_quadril.TabIndex = 38;
            this.nud_quadril.ValueChanged += new System.EventHandler(this.bt_icq_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Quadril (cm)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cintura (cm)";
            // 
            // nud_cintura
            // 
            this.nud_cintura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_cintura.DecimalPlaces = 3;
            this.nud_cintura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_cintura.Location = new System.Drawing.Point(135, 104);
            this.nud_cintura.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_cintura.Name = "nud_cintura";
            this.nud_cintura.Size = new System.Drawing.Size(115, 26);
            this.nud_cintura.TabIndex = 39;
            this.nud_cintura.ValueChanged += new System.EventHandler(this.bt_icq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 476);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(486, 446);
            this.Name = "Form1";
            this.Text = "SaudeMeuAmigo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_regua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indicador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_peso)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_regua_icq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indicador_cintura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indicador_icq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quadril)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cintura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pb_indicador;
        private System.Windows.Forms.NumericUpDown nud_altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_peso;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.PictureBox pb_regua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.NumericUpDown nud_quadril;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_cintura;
        private System.Windows.Forms.PictureBox pb_regua_icq;
        private System.Windows.Forms.PictureBox pb_indicador_icq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_icq;
        private System.Windows.Forms.PictureBox pb_indicador_cintura;
    }
}

