using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10_KevinLucasRaimondiNogueira_3017102087
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double peso = Convert.ToDouble(maskedTextBoxPeso.Text), altura = Convert.ToDouble(maskedTextBoxAltura.Text), imc;
            String nome = textBoxNome.Text;

            imc = (peso) / (altura * altura);
            if (imc < 18.5)
            {
                MessageBox.Show(nome + " o sei IMC é: " + imc + " e sua classificação é Magrela.");
            }
            else
            {
                if ((imc >= 18.5) && imc <= 24.9)
                {
                    MessageBox.Show(nome + " o sei IMC é: " + imc + " e sua classificação é Saudável.");
                }
                else
                {
                    if ((imc >= 25) && (imc <= 29.9))
                    {
                        MessageBox.Show(nome + " o sei IMC é: " + imc + " e sua classificação é Sobrepeso.");
                    }
                    else
                    {
                        if ((imc >= 30) && (imc <= 34.9))
                        {
                            MessageBox.Show(nome + " o sei IMC é: " + imc + " e sua classificação é Obesidade Grau I.");
                        }
                        else
                        {
                            if ((imc >= 35) && (imc <= 39.9))
                            {
                                MessageBox.Show(nome + " o sei IMC é: " + imc + " e sua classificação é Obesidade Grau II (severa).");
                            }
                            else
                            {
                                MessageBox.Show(nome + " o sei IMC é: " + imc + " e sua classificação é Obesidade Grau III (mórbida).");
                            }
                        }
                    }
                }
            }
        }
    }
}
