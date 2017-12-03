namespace Exercicio10_KevinLucasRaimondiNogueira_3017102087
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBoxPeso = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAltura = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 40);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 22);
            this.textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe o Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informe o Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Informe a Altura:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBoxPeso
            // 
            this.maskedTextBoxPeso.Location = new System.Drawing.Point(12, 91);
            this.maskedTextBoxPeso.Mask = "999.00";
            this.maskedTextBoxPeso.Name = "maskedTextBoxPeso";
            this.maskedTextBoxPeso.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxPeso.TabIndex = 7;
            // 
            // maskedTextBoxAltura
            // 
            this.maskedTextBoxAltura.Location = new System.Drawing.Point(13, 143);
            this.maskedTextBoxAltura.Mask = "99.00";
            this.maskedTextBoxAltura.Name = "maskedTextBoxAltura";
            this.maskedTextBoxAltura.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxAltura.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 179);
            this.Controls.Add(this.maskedTextBoxAltura);
            this.Controls.Add(this.maskedTextBoxPeso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form1";
            this.Text = "Exercicio10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPeso;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAltura;
    }
}

