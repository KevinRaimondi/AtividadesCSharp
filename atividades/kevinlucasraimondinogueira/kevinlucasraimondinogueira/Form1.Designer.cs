namespace kevinlucasraimondinogueira3017102087
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Gerente = new System.Windows.Forms.RadioButton();
            this.rb_Operario = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_salarioBruto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_salarioLiquido = new System.Windows.Forms.TextBox();
            this.tb_imposto = new System.Windows.Forms.TextBox();
            this.tb_salarioBrutoCalculado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_salarioBruto);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Salário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Gerente);
            this.groupBox2.Controls.Add(this.rb_Operario);
            this.groupBox2.Location = new System.Drawing.Point(6, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categoria do Funcionário";
            // 
            // rb_Gerente
            // 
            this.rb_Gerente.AutoSize = true;
            this.rb_Gerente.Location = new System.Drawing.Point(152, 34);
            this.rb_Gerente.Name = "rb_Gerente";
            this.rb_Gerente.Size = new System.Drawing.Size(81, 21);
            this.rb_Gerente.TabIndex = 5;
            this.rb_Gerente.TabStop = true;
            this.rb_Gerente.Text = "Gerente";
            this.rb_Gerente.UseVisualStyleBackColor = true;
            // 
            // rb_Operario
            // 
            this.rb_Operario.AutoSize = true;
            this.rb_Operario.Checked = true;
            this.rb_Operario.Location = new System.Drawing.Point(42, 34);
            this.rb_Operario.Name = "rb_Operario";
            this.rb_Operario.Size = new System.Drawing.Size(85, 21);
            this.rb_Operario.TabIndex = 5;
            this.rb_Operario.TabStop = true;
            this.rb_Operario.Text = "Operário";
            this.rb_Operario.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turno de Trabalho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário Bruto (R$) ";
            // 
            // tb_salarioBruto
            // 
            this.tb_salarioBruto.Location = new System.Drawing.Point(139, 18);
            this.tb_salarioBruto.Name = "tb_salarioBruto";
            this.tb_salarioBruto.Size = new System.Drawing.Size(100, 22);
            this.tb_salarioBruto.TabIndex = 0;
            this.tb_salarioBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_salarioBruto_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_salarioLiquido);
            this.groupBox3.Controls.Add(this.tb_imposto);
            this.groupBox3.Controls.Add(this.tb_salarioBrutoCalculado);
            this.groupBox3.Location = new System.Drawing.Point(310, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 116);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Demonstrativo do Cálculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salário Líquido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Imposto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salário Bruto";
            // 
            // tb_salarioLiquido
            // 
            this.tb_salarioLiquido.Location = new System.Drawing.Point(141, 77);
            this.tb_salarioLiquido.Name = "tb_salarioLiquido";
            this.tb_salarioLiquido.ReadOnly = true;
            this.tb_salarioLiquido.Size = new System.Drawing.Size(128, 22);
            this.tb_salarioLiquido.TabIndex = 2;
            // 
            // tb_imposto
            // 
            this.tb_imposto.Location = new System.Drawing.Point(141, 49);
            this.tb_imposto.Name = "tb_imposto";
            this.tb_imposto.ReadOnly = true;
            this.tb_imposto.Size = new System.Drawing.Size(128, 22);
            this.tb_imposto.TabIndex = 1;
            // 
            // tb_salarioBrutoCalculado
            // 
            this.tb_salarioBrutoCalculado.Location = new System.Drawing.Point(141, 21);
            this.tb_salarioBrutoCalculado.Name = "tb_salarioBrutoCalculado";
            this.tb_salarioBrutoCalculado.ReadOnly = true;
            this.tb_salarioBrutoCalculado.Size = new System.Drawing.Size(128, 22);
            this.tb_salarioBrutoCalculado.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(327, 188);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 25);
            this.bt_calcular.TabIndex = 4;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 225);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermercado Bom de Preço";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_salarioBruto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_salarioLiquido;
        private System.Windows.Forms.TextBox tb_imposto;
        private System.Windows.Forms.TextBox tb_salarioBrutoCalculado;
        private System.Windows.Forms.RadioButton rb_Gerente;
        private System.Windows.Forms.RadioButton rb_Operario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_calcular;
    }
}

