namespace Exercicio2_KevinLucasRaimondiNogueira_3017102087
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxConta = new System.Windows.Forms.TextBox();
            this.textBoxSaldoMes = new System.Windows.Forms.TextBox();
            this.textBoxTotalGasto = new System.Windows.Forms.TextBox();
            this.textBoxTotalCreditos = new System.Windows.Forms.TextBox();
            this.textBoxLimiteCredito = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNovoSaldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero da conta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo Inicial (Mês)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total de gasto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total de Creditos: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Limite de credito permitido";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(138, 6);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(280, 22);
            this.textBoxNome.TabIndex = 6;
            // 
            // textBoxConta
            // 
            this.textBoxConta.Location = new System.Drawing.Point(551, 6);
            this.textBoxConta.Name = "textBoxConta";
            this.textBoxConta.Size = new System.Drawing.Size(76, 22);
            this.textBoxConta.TabIndex = 7;
            this.textBoxConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBoxSaldoMes
            // 
            this.textBoxSaldoMes.Location = new System.Drawing.Point(141, 51);
            this.textBoxSaldoMes.Name = "textBoxSaldoMes";
            this.textBoxSaldoMes.Size = new System.Drawing.Size(78, 22);
            this.textBoxSaldoMes.TabIndex = 8;
            this.textBoxSaldoMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBoxTotalGasto
            // 
            this.textBoxTotalGasto.Location = new System.Drawing.Point(334, 51);
            this.textBoxTotalGasto.Name = "textBoxTotalGasto";
            this.textBoxTotalGasto.Size = new System.Drawing.Size(84, 22);
            this.textBoxTotalGasto.TabIndex = 9;
            this.textBoxTotalGasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBoxTotalCreditos
            // 
            this.textBoxTotalCreditos.Location = new System.Drawing.Point(551, 51);
            this.textBoxTotalCreditos.Name = "textBoxTotalCreditos";
            this.textBoxTotalCreditos.Size = new System.Drawing.Size(76, 22);
            this.textBoxTotalCreditos.TabIndex = 10;
            this.textBoxTotalCreditos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBoxLimiteCredito
            // 
            this.textBoxLimiteCredito.Location = new System.Drawing.Point(192, 99);
            this.textBoxLimiteCredito.Name = "textBoxLimiteCredito";
            this.textBoxLimiteCredito.Size = new System.Drawing.Size(77, 22);
            this.textBoxLimiteCredito.TabIndex = 11;
            this.textBoxLimiteCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNovoSaldo
            // 
            this.textBoxNovoSaldo.Location = new System.Drawing.Point(427, 99);
            this.textBoxNovoSaldo.Name = "textBoxNovoSaldo";
            this.textBoxNovoSaldo.ReadOnly = true;
            this.textBoxNovoSaldo.Size = new System.Drawing.Size(100, 22);
            this.textBoxNovoSaldo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Novo Saldo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 134);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNovoSaldo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLimiteCredito);
            this.Controls.Add(this.textBoxTotalCreditos);
            this.Controls.Add(this.textBoxTotalGasto);
            this.Controls.Add(this.textBoxSaldoMes);
            this.Controls.Add(this.textBoxConta);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Exercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxConta;
        private System.Windows.Forms.TextBox textBoxSaldoMes;
        private System.Windows.Forms.TextBox textBoxTotalGasto;
        private System.Windows.Forms.TextBox textBoxTotalCreditos;
        private System.Windows.Forms.TextBox textBoxLimiteCredito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNovoSaldo;
        private System.Windows.Forms.Label label7;
    }
}

