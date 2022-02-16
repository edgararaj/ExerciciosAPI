namespace CalculoPrestacoes
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
            this.txt_p = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_grafico = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_t = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_v = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_reset_center = new System.Windows.Forms.Button();
            this.btn_reset_sx = new System.Windows.Forms.Button();
            this.btn_reset_sy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_x = new System.Windows.Forms.ComboBox();
            this.lbl_x = new System.Windows.Forms.Label();
            this.cb_y = new System.Windows.Forms.ComboBox();
            this.lbl_y = new System.Windows.Forms.Label();
            this.nud_div = new System.Windows.Forms.NumericUpDown();
            this.lbl_div = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_div)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_p
            // 
            this.txt_p.Location = new System.Drawing.Point(165, 224);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(122, 26);
            this.txt_p.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(175, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculadora de Prestações";
            // 
            // pb_grafico
            // 
            this.pb_grafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_grafico.Location = new System.Drawing.Point(642, 12);
            this.pb_grafico.Name = "pb_grafico";
            this.pb_grafico.Size = new System.Drawing.Size(545, 463);
            this.pb_grafico.TabIndex = 2;
            this.pb_grafico.TabStop = false;
            this.pb_grafico.Visible = false;
            this.pb_grafico.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_grafico_MouseDown);
            this.pb_grafico.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_grafico_MouseMove);
            this.pb_grafico.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_grafico_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prestação (P)";
            // 
            // txt_t
            // 
            this.txt_t.Location = new System.Drawing.Point(165, 271);
            this.txt_t.Name = "txt_t";
            this.txt_t.Size = new System.Drawing.Size(122, 26);
            this.txt_t.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Taxa (T)";
            // 
            // txt_v
            // 
            this.txt_v.Location = new System.Drawing.Point(430, 224);
            this.txt_v.Name = "txt_v";
            this.txt_v.Size = new System.Drawing.Size(122, 26);
            this.txt_v.TabIndex = 0;
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(430, 271);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(122, 26);
            this.txt_n.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor (V)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Períodos (N)";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(624, -37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 700);
            this.label6.TabIndex = 4;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.Location = new System.Drawing.Point(171, 173);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(305, 16);
            this.lbl_msg.TabIndex = 5;
            this.lbl_msg.Text = "Deixe em branco o espaço que pretende calcular!";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(276, 339);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(95, 45);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_reset_center
            // 
            this.btn_reset_center.Location = new System.Drawing.Point(642, 481);
            this.btn_reset_center.Name = "btn_reset_center";
            this.btn_reset_center.Size = new System.Drawing.Size(116, 31);
            this.btn_reset_center.TabIndex = 6;
            this.btn_reset_center.Text = "Reset Center";
            this.btn_reset_center.UseVisualStyleBackColor = true;
            this.btn_reset_center.Visible = false;
            this.btn_reset_center.Click += new System.EventHandler(this.btn_reset_center_Click);
            // 
            // btn_reset_sx
            // 
            this.btn_reset_sx.Location = new System.Drawing.Point(764, 481);
            this.btn_reset_sx.Name = "btn_reset_sx";
            this.btn_reset_sx.Size = new System.Drawing.Size(116, 31);
            this.btn_reset_sx.TabIndex = 6;
            this.btn_reset_sx.Text = "Reset ScaleX";
            this.btn_reset_sx.UseVisualStyleBackColor = true;
            this.btn_reset_sx.Visible = false;
            this.btn_reset_sx.Click += new System.EventHandler(this.btn_reset_sx_Click);
            // 
            // btn_reset_sy
            // 
            this.btn_reset_sy.Location = new System.Drawing.Point(888, 481);
            this.btn_reset_sy.Name = "btn_reset_sy";
            this.btn_reset_sy.Size = new System.Drawing.Size(116, 31);
            this.btn_reset_sy.TabIndex = 6;
            this.btn_reset_sy.Text = "Reset ScaleY";
            this.btn_reset_sy.UseVisualStyleBackColor = true;
            this.btn_reset_sy.Visible = false;
            this.btn_reset_sy.Click += new System.EventHandler(this.btn_reset_sy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CalculoPrestacoes.Properties.Resources.eq;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(107, 470);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 89);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cb_x
            // 
            this.cb_x.FormattingEnabled = true;
            this.cb_x.Location = new System.Drawing.Point(760, 556);
            this.cb_x.Name = "cb_x";
            this.cb_x.Size = new System.Drawing.Size(143, 28);
            this.cb_x.TabIndex = 8;
            this.cb_x.Visible = false;
            this.cb_x.SelectedIndexChanged += new System.EventHandler(this.cb_x_SelectedIndexChanged);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(721, 559);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(33, 20);
            this.lbl_x.TabIndex = 9;
            this.lbl_x.Text = "X =";
            this.lbl_x.Visible = false;
            // 
            // cb_y
            // 
            this.cb_y.FormattingEnabled = true;
            this.cb_y.Location = new System.Drawing.Point(990, 556);
            this.cb_y.Name = "cb_y";
            this.cb_y.Size = new System.Drawing.Size(143, 28);
            this.cb_y.TabIndex = 8;
            this.cb_y.Visible = false;
            this.cb_y.SelectedIndexChanged += new System.EventHandler(this.cb_y_SelectedIndexChanged);
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(951, 559);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(33, 20);
            this.lbl_y.TabIndex = 9;
            this.lbl_y.Text = "Y =";
            this.lbl_y.Visible = false;
            // 
            // nud_div
            // 
            this.nud_div.DecimalPlaces = 2;
            this.nud_div.Location = new System.Drawing.Point(1111, 484);
            this.nud_div.Name = "nud_div";
            this.nud_div.Size = new System.Drawing.Size(76, 26);
            this.nud_div.TabIndex = 10;
            this.nud_div.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_div.Visible = false;
            this.nud_div.ValueChanged += new System.EventHandler(this.nud_div_ValueChanged);
            // 
            // lbl_div
            // 
            this.lbl_div.AutoSize = true;
            this.lbl_div.Location = new System.Drawing.Point(1045, 486);
            this.lbl_div.Name = "lbl_div";
            this.lbl_div.Size = new System.Drawing.Size(60, 20);
            this.lbl_div.TabIndex = 11;
            this.lbl_div.Text = "Divisão";
            this.lbl_div.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 628);
            this.Controls.Add(this.lbl_div);
            this.Controls.Add(this.nud_div);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.cb_y);
            this.Controls.Add(this.cb_x);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_reset_sy);
            this.Controls.Add(this.btn_reset_sx);
            this.Controls.Add(this.btn_reset_center);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_grafico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.txt_v);
            this.Controls.Add(this.txt_t);
            this.Controls.Add(this.txt_p);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora de Prestações";
            ((System.ComponentModel.ISupportInitialize)(this.pb_grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_div)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_grafico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_v;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_reset_center;
        private System.Windows.Forms.Button btn_reset_sx;
        private System.Windows.Forms.Button btn_reset_sy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_x;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.ComboBox cb_y;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.NumericUpDown nud_div;
        private System.Windows.Forms.Label lbl_div;
    }
}

