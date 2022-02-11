namespace Quiz
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_inicial = new System.Windows.Forms.Panel();
            this.nud_perguntas = new System.Windows.Forms.NumericUpDown();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_questoes = new System.Windows.Forms.Panel();
            this.lbl_num_pergunta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.flp_respostas = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_pergunta = new System.Windows.Forms.Label();
            this.pnl_resultados = new System.Windows.Forms.Panel();
            this.lbl_resultado_resumo = new System.Windows.Forms.Label();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.flp_resultados = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_q = new System.Windows.Forms.Label();
            this.lbl_r = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_inicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_perguntas)).BeginInit();
            this.pnl_questoes.SuspendLayout();
            this.flp_respostas.SuspendLayout();
            this.pnl_resultados.SuspendLayout();
            this.flp_resultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnl_inicial
            // 
            this.pnl_inicial.BackColor = System.Drawing.Color.Transparent;
            this.pnl_inicial.Controls.Add(this.nud_perguntas);
            this.pnl_inicial.Controls.Add(this.btn_iniciar);
            this.pnl_inicial.Controls.Add(this.label3);
            this.pnl_inicial.Controls.Add(this.label1);
            this.pnl_inicial.Location = new System.Drawing.Point(12, 12);
            this.pnl_inicial.Name = "pnl_inicial";
            this.pnl_inicial.Size = new System.Drawing.Size(392, 571);
            this.pnl_inicial.TabIndex = 0;
            // 
            // nud_perguntas
            // 
            this.nud_perguntas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_perguntas.Location = new System.Drawing.Point(195, 264);
            this.nud_perguntas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_perguntas.Name = "nud_perguntas";
            this.nud_perguntas.Size = new System.Drawing.Size(120, 29);
            this.nud_perguntas.TabIndex = 3;
            this.nud_perguntas.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(143, 412);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(114, 47);
            this.btn_iniciar.TabIndex = 6;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de perguntas:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(79, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUIZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_questoes
            // 
            this.pnl_questoes.BackColor = System.Drawing.Color.Transparent;
            this.pnl_questoes.Controls.Add(this.lbl_num_pergunta);
            this.pnl_questoes.Controls.Add(this.button1);
            this.pnl_questoes.Controls.Add(this.lbl_warning);
            this.pnl_questoes.Controls.Add(this.flp_respostas);
            this.pnl_questoes.Controls.Add(this.btn_prev);
            this.pnl_questoes.Controls.Add(this.btn_next);
            this.pnl_questoes.Controls.Add(this.lbl_pergunta);
            this.pnl_questoes.Location = new System.Drawing.Point(12, 12);
            this.pnl_questoes.Name = "pnl_questoes";
            this.pnl_questoes.Size = new System.Drawing.Size(392, 571);
            this.pnl_questoes.TabIndex = 1;
            this.pnl_questoes.Visible = false;
            // 
            // lbl_num_pergunta
            // 
            this.lbl_num_pergunta.AutoSize = true;
            this.lbl_num_pergunta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_pergunta.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_num_pergunta.Location = new System.Drawing.Point(32, 29);
            this.lbl_num_pergunta.Name = "lbl_num_pergunta";
            this.lbl_num_pergunta.Size = new System.Drawing.Size(56, 32);
            this.lbl_num_pergunta.TabIndex = 10;
            this.lbl_num_pergunta.Text = "100";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Quiz.Properties.Resources.Flat_restart_icon_svg;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(304, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 47);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // lbl_warning
            // 
            this.lbl_warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_warning.Location = new System.Drawing.Point(38, 465);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(313, 23);
            this.lbl_warning.TabIndex = 8;
            this.lbl_warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_respostas
            // 
            this.flp_respostas.AutoScroll = true;
            this.flp_respostas.Controls.Add(this.radioButton1);
            this.flp_respostas.Location = new System.Drawing.Point(38, 103);
            this.flp_respostas.Name = "flp_respostas";
            this.flp_respostas.Size = new System.Drawing.Size(313, 343);
            this.flp_respostas.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButton1.Size = new System.Drawing.Size(287, 53);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.Location = new System.Drawing.Point(38, 505);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(86, 47);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "Prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(130, 505);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(86, 47);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_pergunta
            // 
            this.lbl_pergunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pergunta.Location = new System.Drawing.Point(80, 12);
            this.lbl_pergunta.Name = "lbl_pergunta";
            this.lbl_pergunta.Size = new System.Drawing.Size(271, 69);
            this.lbl_pergunta.TabIndex = 0;
            this.lbl_pergunta.Text = "label2";
            this.lbl_pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_resultados
            // 
            this.pnl_resultados.BackColor = System.Drawing.Color.Transparent;
            this.pnl_resultados.Controls.Add(this.lbl_resultado_resumo);
            this.pnl_resultados.Controls.Add(this.btn_reiniciar);
            this.pnl_resultados.Controls.Add(this.flp_resultados);
            this.pnl_resultados.Controls.Add(this.label2);
            this.pnl_resultados.Location = new System.Drawing.Point(12, 12);
            this.pnl_resultados.Name = "pnl_resultados";
            this.pnl_resultados.Size = new System.Drawing.Size(392, 571);
            this.pnl_resultados.TabIndex = 2;
            this.pnl_resultados.Visible = false;
            // 
            // lbl_resultado_resumo
            // 
            this.lbl_resultado_resumo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado_resumo.Location = new System.Drawing.Point(38, 58);
            this.lbl_resultado_resumo.Name = "lbl_resultado_resumo";
            this.lbl_resultado_resumo.Size = new System.Drawing.Size(313, 23);
            this.lbl_resultado_resumo.TabIndex = 7;
            this.lbl_resultado_resumo.Text = "label4";
            this.lbl_resultado_resumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reiniciar.Location = new System.Drawing.Point(132, 505);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(114, 47);
            this.btn_reiniciar.TabIndex = 6;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // flp_resultados
            // 
            this.flp_resultados.AutoScroll = true;
            this.flp_resultados.Controls.Add(this.lbl_q);
            this.flp_resultados.Controls.Add(this.lbl_r);
            this.flp_resultados.Controls.Add(this.lbl_d);
            this.flp_resultados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_resultados.Location = new System.Drawing.Point(38, 103);
            this.flp_resultados.Name = "flp_resultados";
            this.flp_resultados.Size = new System.Drawing.Size(313, 375);
            this.flp_resultados.TabIndex = 5;
            // 
            // lbl_q
            // 
            this.lbl_q.Location = new System.Drawing.Point(3, 0);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(290, 71);
            this.lbl_q.TabIndex = 0;
            this.lbl_q.Text = "label4";
            this.lbl_q.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_r
            // 
            this.lbl_r.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_r.Location = new System.Drawing.Point(3, 71);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(290, 46);
            this.lbl_r.TabIndex = 0;
            this.lbl_r.Text = "label4";
            this.lbl_r.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_d
            // 
            this.lbl_d.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_d.Location = new System.Drawing.Point(3, 117);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(290, 1);
            this.lbl_d.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultados:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(417, 597);
            this.Controls.Add(this.pnl_inicial);
            this.Controls.Add(this.pnl_questoes);
            this.Controls.Add(this.pnl_resultados);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quiz";
            this.pnl_inicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_perguntas)).EndInit();
            this.pnl_questoes.ResumeLayout(false);
            this.pnl_questoes.PerformLayout();
            this.flp_respostas.ResumeLayout(false);
            this.pnl_resultados.ResumeLayout(false);
            this.flp_resultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnl_inicial;
        private System.Windows.Forms.NumericUpDown nud_perguntas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_questoes;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_pergunta;
        private System.Windows.Forms.FlowLayoutPanel flp_respostas;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Panel pnl_resultados;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.FlowLayoutPanel flp_resultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_q;
        private System.Windows.Forms.Label lbl_r;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.Label lbl_resultado_resumo;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_num_pergunta;
    }
}

