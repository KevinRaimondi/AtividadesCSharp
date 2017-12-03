namespace Exercicio4_KevinLucasRaimondiNogueira_3017102087
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
            this.tb_SaldoBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TempoServico = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_SaldoLiquido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_classficacao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo Base:";
            // 
            // tb_SaldoBase
            // 
            this.tb_SaldoBase.Location = new System.Drawing.Point(15, 49);
            this.tb_SaldoBase.Name = "tb_SaldoBase";
            this.tb_SaldoBase.Size = new System.Drawing.Size(100, 22);
            this.tb_SaldoBase.TabIndex = 1;
            this.tb_SaldoBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SaldoBase_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo de Serviço (Funcionario):";
            // 
            // tb_TempoServico
            // 
            this.tb_TempoServico.Location = new System.Drawing.Point(148, 49);
            this.tb_TempoServico.Name = "tb_TempoServico";
            this.tb_TempoServico.Size = new System.Drawing.Size(100, 22);
            this.tb_TempoServico.TabIndex = 3;
            this.tb_TempoServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TempoServico_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_SaldoLiquido
            // 
            this.lb_SaldoLiquido.AutoSize = true;
            this.lb_SaldoLiquido.Location = new System.Drawing.Point(270, 87);
            this.lb_SaldoLiquido.Name = "lb_SaldoLiquido";
            this.lb_SaldoLiquido.Size = new System.Drawing.Size(0, 17);
            this.lb_SaldoLiquido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Classificação:";
            // 
            // lb_classficacao
            // 
            this.lb_classficacao.AutoSize = true;
            this.lb_classficacao.Location = new System.Drawing.Point(112, 87);
            this.lb_classficacao.Name = "lb_classficacao";
            this.lb_classficacao.Size = new System.Drawing.Size(0, 17);
            this.lb_classficacao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salário Liquido:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 126);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_classficacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_SaldoLiquido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_TempoServico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_SaldoBase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Exercicio 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SaldoBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TempoServico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_SaldoLiquido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_classficacao;
        private System.Windows.Forms.Label label4;
    }
}

