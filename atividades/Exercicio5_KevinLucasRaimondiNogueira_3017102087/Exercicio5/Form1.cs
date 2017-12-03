using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5_KevinLucasRaimondiNogueira_3017102087
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(225, 190);
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int codigoProduto = Convert.ToInt32(tb_CodigoProduto.Text);
            int codigoPais = Convert.ToInt32(tb_CodigoPais.Text);
            Double pesoProdutoKg = Convert.ToDouble(tb_PesoProdutoKg.Text);
            Double pesoProdutoG;
            Double precoPorGrama = 0.0;
            Double precoProduto;
            int valorImposto = 0;
            Double valorTotal;
            Boolean erro = false;
            if (!(codigoProduto < 1) && !(codigoProduto > 10))
            {
                if ((codigoProduto >= 1) && (codigoProduto <= 4))
                {
                    precoPorGrama = 10.00;
                }
                else
                {
                    if ((codigoProduto >= 5) && (codigoProduto <= 7))
                    {
                        precoPorGrama = 25.00;
                    }
                    else
                    {
                        if ((codigoProduto >= 8) && (codigoProduto <= 10))
                        {
                            precoPorGrama = 35.00;
                        }
                    }
                }
            }
            else
            {
                erro = true;
                MessageBox.Show("Codigo Produto Invalido");
            }

            if (!erro)
            {
                switch (codigoPais)
                {
                    case 1:
                        valorImposto = 0;
                        break;
                    case 2:
                        valorImposto = 15;
                        break;
                    case 3:
                        valorImposto = 25;
                        break;
                    default:
                        erro = true;
                        MessageBox.Show("Codigo País Invalido");
                        break;
                }
            }

            if (!erro)
            {
                pesoProdutoG = pesoProdutoKg * 1000;
                precoProduto = precoPorGrama * pesoProdutoG;
                valorTotal = precoProduto * 10 / valorImposto;

                tb_PesoProdutoG.Text = pesoProdutoG.ToString();
                tb_PrecoProduto.Text = precoProduto.ToString();
                tb_ValorImposto.Text = valorImposto.ToString();
                tb_ValorTotal.Text = valorTotal.ToString();

                this.Size = new Size(480, 190);
            }


                // MessageBox.Show("Triangulo escaleno");
               
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

        private void tb_CodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void tb_CodigoPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void tb_PesoProdutoKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }
    }
}
