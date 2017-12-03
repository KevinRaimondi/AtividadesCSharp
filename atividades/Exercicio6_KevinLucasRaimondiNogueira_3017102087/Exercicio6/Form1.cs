using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio6_KevinLucasRaimondiNogueira_3017102087
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double posicaoIni = Convert.ToDouble(tb_PosicaoIni.Text);
            Double velocidadeIni = Convert.ToDouble(tb_VelocidadeIni.Text);
            Double aceleracao = Convert.ToDouble(tb_Aceleracao.Text);
            Double resultado = 0.0;

            resultado = posicaoIni + velocidadeIni * 60 + ((aceleracao / 2) * 3600);

            tb_resultado.Text = resultado.ToString();
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

        private void tb_PosicaoIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void tb_VelocidadeIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void tb_Aceleracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }
    }
}
