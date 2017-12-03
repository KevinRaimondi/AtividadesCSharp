using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9_KevinLucasRaimondiNogueira_3017102087
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            String resultado = null;
            int ano = Convert.ToInt32(textBox1.Text);
            if ((ano % 4).Equals(0) && !(ano % 100).Equals(0) || (ano % 400).Equals(0))
            {
                resultado = "O ano " + ano + " é bissexto ";
            }
            else
            {
                resultado = "O ano " + ano + " não é bissexto ";
            }
            MessageBox.Show(resultado);
        }
    }

}

