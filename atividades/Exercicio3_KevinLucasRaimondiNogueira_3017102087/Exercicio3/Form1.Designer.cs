namespace Exercicio3_KevinLucasRaimondiNogueira_3017102087
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
            this.textBoxLadoA = new System.Windows.Forms.TextBox();
            this.textBoxLadoB = new System.Windows.Forms.TextBox();
            this.textBoxLadoC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLadoA
            // 
            this.textBoxLadoA.Location = new System.Drawing.Point(12, 35);
            this.textBoxLadoA.Name = "textBoxLadoA";
            this.textBoxLadoA.Size = new System.Drawing.Size(132, 22);
            this.textBoxLadoA.TabIndex = 0;
            this.textBoxLadoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLadoA_KeyPress);
            // 
            // textBoxLadoB
            // 
            this.textBoxLadoB.Location = new System.Drawing.Point(12, 89);
            this.textBoxLadoB.Name = "textBoxLadoB";
            this.textBoxLadoB.Size = new System.Drawing.Size(132, 22);
            this.textBoxLadoB.TabIndex = 1;
            this.textBoxLadoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLadoB_KeyPress);
            // 
            // textBoxLadoC
            // 
            this.textBoxLadoC.Location = new System.Drawing.Point(12, 149);
            this.textBoxLadoC.Name = "textBoxLadoC";
            this.textBoxLadoC.Size = new System.Drawing.Size(132, 22);
            this.textBoxLadoC.TabIndex = 2;
            this.textBoxLadoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLadoC_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lado A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lado B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Labo C:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 187);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLadoC);
            this.Controls.Add(this.textBoxLadoB);
            this.Controls.Add(this.textBoxLadoA);
            this.Name = "Form1";
            this.Text = "Exercício 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLadoA;
        private System.Windows.Forms.TextBox textBoxLadoB;
        private System.Windows.Forms.TextBox textBoxLadoC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

