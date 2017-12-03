using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4_KevinLucasRaimondiNogueira_3017102087
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double saldoBase = Convert.ToDouble(tb_SaldoBase.Text);
            int imposto = 0;
            int tempoServico = Convert.ToInt32(tb_TempoServico.Text);
            Double gratificacao = 0;
            Double salarioLiquido = 0;
            Double descontoImposto = 0;

            if ((saldoBase >= 200) && (saldoBase <= 400))
            {
                imposto = 3 / 100;
            }
            else
            {
                if ((saldoBase >= 450) && (saldoBase <= 700))
                {
                    imposto = 8 / 100;
                }
                else
                {
                    if (saldoBase > 700)
                    {
                        imposto = 12 / 100;
                    }
                }
            }
            
            if ((saldoBase < 500) && (tempoServico <= 3))
            {
                gratificacao = 20.00;
            }
            else
            {
                if ((saldoBase < 500) && (tempoServico > 3))
                {
                    gratificacao = 30.00;
                }
            }

            if ((saldoBase > 500) && (tempoServico <= 3))
            {
                gratificacao = 23.00;
            }
            else
            {
                if ((saldoBase > 500) && (tempoServico > 3) && (tempoServico <= 6))
                {
                    gratificacao = 35.00;
                }
                else
                {
                    if ((saldoBase > 500) && (tempoServico > 6))
                    {
                        gratificacao = 38.00;

                    }
                }
            }

            if (!(imposto.Equals(0))) {
                descontoImposto = saldoBase / imposto;
            }
            salarioLiquido = saldoBase - descontoImposto + gratificacao;

            lb_SaldoLiquido.Text = salarioLiquido.ToString();

            if ((salarioLiquido <= 350))
            {
                lb_classficacao.Text = "A";
            }
            else
            {
                if ((salarioLiquido > 350) && (salarioLiquido <= 600))
                {
                    lb_classficacao.Text = "B";
                }
                else
                {
                    if (salarioLiquido > 600)
                    {
                        lb_classficacao.Text = "C";
                    }
                }

            }

        }

        public void validarNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_TempoServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void tb_SaldoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }
    }
}
