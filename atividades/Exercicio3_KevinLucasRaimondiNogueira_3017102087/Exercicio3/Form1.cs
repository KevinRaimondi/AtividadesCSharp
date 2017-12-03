using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_KevinLucasRaimondiNogueira_3017102087
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBoxLadoA.Text);
            int y = Convert.ToInt32(textBoxLadoB.Text);
            int z = Convert.ToInt32(textBoxLadoC.Text);

            if ((x < y + z) && (y < x + z) && (z < x + y))
            {
                if ((x.Equals(y)) && (y.Equals(z)))
                {
                    MessageBox.Show("Triangulo equilatero");
                }
                else
                {
                    if ((x.Equals(y)) || (x.Equals(z)) || (y.Equals(z)))
                    {
                        MessageBox.Show("Triangulo isosceles");
                    }
                    else
                    {
                        MessageBox.Show("Triangulo escaleno");
                    }
                }
            }
            else
            {
                MessageBox.Show("Não é um Triangulo");
            }
        }

        private void textBoxLadoA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxLadoB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxLadoC_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
