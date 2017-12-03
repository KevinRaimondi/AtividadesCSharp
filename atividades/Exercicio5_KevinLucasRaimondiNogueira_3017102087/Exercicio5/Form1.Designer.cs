namespace Exercicio5_KevinLucasRaimondiNogueira_3017102087
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_CodigoProduto = new System.Windows.Forms.TextBox();
            this.tb_CodigoPais = new System.Windows.Forms.TextBox();
            this.tb_PesoProdutoKg = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_ValorTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ValorImposto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_PrecoProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_PesoProdutoG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo País de origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso do produto (Kg):";
            // 
            // tb_CodigoProduto
            // 
            this.tb_CodigoProduto.Location = new System.Drawing.Point(186, 32);
            this.tb_CodigoProduto.MaxLength = 2;
            this.tb_CodigoProduto.Name = "tb_CodigoProduto";
            this.tb_CodigoProduto.Size = new System.Drawing.Size(74, 22);
            this.tb_CodigoProduto.TabIndex = 3;
            this.tb_CodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CodigoProduto_KeyPress);
            // 
            // tb_CodigoPais
            // 
            this.tb_CodigoPais.Location = new System.Drawing.Point(186, 68);
            this.tb_CodigoPais.MaxLength = 1;
            this.tb_CodigoPais.Name = "tb_CodigoPais";
            this.tb_CodigoPais.Size = new System.Drawing.Size(74, 22);
            this.tb_CodigoPais.TabIndex = 4;
            this.tb_CodigoPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CodigoPais_KeyPress);
            // 
            // tb_PesoProdutoKg
            // 
            this.tb_PesoProdutoKg.Location = new System.Drawing.Point(186, 99);
            this.tb_PesoProdutoKg.Name = "tb_PesoProdutoKg";
            this.tb_PesoProdutoKg.Size = new System.Drawing.Size(74, 22);
            this.tb_PesoProdutoKg.TabIndex = 5;
            this.tb_PesoProdutoKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PesoProdutoKg_KeyPress);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(186, 137);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 6;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_ValorTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_ValorImposto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_PrecoProduto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_PesoProdutoG);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(306, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 148);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // tb_ValorTotal
            // 
            this.tb_ValorTotal.Location = new System.Drawing.Point(171, 110);
            this.tb_ValorTotal.Name = "tb_ValorTotal";
            this.tb_ValorTotal.ReadOnly = true;
            this.tb_ValorTotal.Size = new System.Drawing.Size(100, 22);
            this.tb_ValorTotal.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor Total (R$):";
            // 
            // tb_ValorImposto
            // 
            this.tb_ValorImposto.Location = new System.Drawing.Point(171, 77);
            this.tb_ValorImposto.Name = "tb_ValorImposto";
            this.tb_ValorImposto.ReadOnly = true;
            this.tb_ValorImposto.Size = new System.Drawing.Size(100, 22);
            this.tb_ValorImposto.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor Imposto (%):";
            // 
            // tb_PrecoProduto
            // 
            this.tb_PrecoProduto.Location = new System.Drawing.Point(171, 46);
            this.tb_PrecoProduto.Name = "tb_PrecoProduto";
            this.tb_PrecoProduto.ReadOnly = true;
            this.tb_PrecoProduto.Size = new System.Drawing.Size(100, 22);
            this.tb_PrecoProduto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Preço do Produto (R$):";
            // 
            // tb_PesoProdutoG
            // 
            this.tb_PesoProdutoG.Location = new System.Drawing.Point(171, 17);
            this.tb_PesoProdutoG.Name = "tb_PesoProdutoG";
            this.tb_PesoProdutoG.ReadOnly = true;
            this.tb_PesoProdutoG.Size = new System.Drawing.Size(100, 22);
            this.tb_PesoProdutoG.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Peso Produto (g):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 172);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.tb_PesoProdutoKg);
            this.Controls.Add(this.tb_CodigoPais);
            this.Controls.Add(this.tb_CodigoProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Exercicio 5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_CodigoProduto;
        private System.Windows.Forms.TextBox tb_CodigoPais;
        private System.Windows.Forms.TextBox tb_PesoProdutoKg;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_ValorImposto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_PrecoProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_PesoProdutoG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ValorTotal;
        private System.Windows.Forms.Label label7;
    }
}

