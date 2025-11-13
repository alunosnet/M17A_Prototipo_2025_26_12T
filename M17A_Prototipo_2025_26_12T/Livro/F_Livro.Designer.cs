namespace M17A_Prototipo_2025_26_12T.Livro
{
    partial class F_Livro
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_procurar = new System.Windows.Forms.Button();
            this.pb_capa = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.tb_guardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lb_feedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_capa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(152, 29);
            this.tb_titulo.MaxLength = 50;
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(157, 20);
            this.tb_titulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Autor";
            // 
            // tb_autor
            // 
            this.tb_autor.Location = new System.Drawing.Point(152, 55);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(157, 20);
            this.tb_autor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ano";
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(152, 108);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(157, 20);
            this.tb_ano.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Aquisição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Preço";
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(152, 160);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(157, 20);
            this.tb_preco.TabIndex = 1;
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(152, 134);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(157, 20);
            this.dtp_data.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Capa";
            // 
            // bt_procurar
            // 
            this.bt_procurar.Location = new System.Drawing.Point(153, 317);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(113, 26);
            this.bt_procurar.TabIndex = 3;
            this.bt_procurar.Text = "Procurar...";
            this.toolTip1.SetToolTip(this.bt_procurar, "Escolher o ficheiro para a capa do livro.");
            this.bt_procurar.UseVisualStyleBackColor = true;
            this.bt_procurar.Click += new System.EventHandler(this.bt_procurar_Click);
            // 
            // pb_capa
            // 
            this.pb_capa.Location = new System.Drawing.Point(153, 197);
            this.pb_capa.Name = "pb_capa";
            this.pb_capa.Size = new System.Drawing.Size(177, 114);
            this.pb_capa.TabIndex = 4;
            this.pb_capa.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ISBN";
            // 
            // tb_isbn
            // 
            this.tb_isbn.Location = new System.Drawing.Point(152, 81);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(157, 20);
            this.tb_isbn.TabIndex = 1;
            // 
            // tb_guardar
            // 
            this.tb_guardar.Location = new System.Drawing.Point(86, 349);
            this.tb_guardar.Name = "tb_guardar";
            this.tb_guardar.Size = new System.Drawing.Size(244, 47);
            this.tb_guardar.TabIndex = 5;
            this.tb_guardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.tb_guardar, "Adiciona o livro à base de dados.");
            this.tb_guardar.UseVisualStyleBackColor = true;
            this.tb_guardar.Click += new System.EventHandler(this.tb_guardar_Click);
            // 
            // lb_feedback
            // 
            this.lb_feedback.AutoSize = true;
            this.lb_feedback.Location = new System.Drawing.Point(13, 425);
            this.lb_feedback.Name = "lb_feedback";
            this.lb_feedback.Size = new System.Drawing.Size(0, 13);
            this.lb_feedback.TabIndex = 6;
            // 
            // F_Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_feedback);
            this.Controls.Add(this.tb_guardar);
            this.Controls.Add(this.pb_capa);
            this.Controls.Add(this.bt_procurar);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_isbn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_autor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.label1);
            this.Name = "F_Livro";
            this.Text = "F_Livro";
            ((System.ComponentModel.ISupportInitialize)(this.pb_capa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_procurar;
        private System.Windows.Forms.PictureBox pb_capa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.Button tb_guardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lb_feedback;
    }
}