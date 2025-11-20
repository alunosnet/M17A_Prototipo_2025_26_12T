namespace M17A_Prototipo_2025_26_12T.Emprestimo
{
    partial class F_Emprestimo
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
            this.cb_livro = new System.Windows.Forms.ComboBox();
            this.cb_leitor = new System.Windows.Forms.ComboBox();
            this.bt_emprestar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_livro
            // 
            this.cb_livro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_livro.FormattingEnabled = true;
            this.cb_livro.Location = new System.Drawing.Point(161, 42);
            this.cb_livro.Name = "cb_livro";
            this.cb_livro.Size = new System.Drawing.Size(301, 21);
            this.cb_livro.TabIndex = 0;
            // 
            // cb_leitor
            // 
            this.cb_leitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_leitor.FormattingEnabled = true;
            this.cb_leitor.Location = new System.Drawing.Point(164, 92);
            this.cb_leitor.Name = "cb_leitor";
            this.cb_leitor.Size = new System.Drawing.Size(297, 21);
            this.cb_leitor.TabIndex = 1;
            // 
            // bt_emprestar
            // 
            this.bt_emprestar.Location = new System.Drawing.Point(167, 146);
            this.bt_emprestar.Name = "bt_emprestar";
            this.bt_emprestar.Size = new System.Drawing.Size(294, 55);
            this.bt_emprestar.TabIndex = 2;
            this.bt_emprestar.Text = "Emprestar";
            this.bt_emprestar.UseVisualStyleBackColor = true;
            this.bt_emprestar.Click += new System.EventHandler(this.bt_emprestar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Leitor";
            // 
            // F_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_emprestar);
            this.Controls.Add(this.cb_leitor);
            this.Controls.Add(this.cb_livro);
            this.Name = "F_Emprestimo";
            this.Text = "F_Emprestimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_livro;
        private System.Windows.Forms.ComboBox cb_leitor;
        private System.Windows.Forms.Button bt_emprestar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}