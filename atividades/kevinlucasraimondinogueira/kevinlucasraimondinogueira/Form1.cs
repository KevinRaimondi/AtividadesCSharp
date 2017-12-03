using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kevinlucasraimondinogueira3017102087
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicializar();


        }

        public void inicializar()
        {
            carregarCombox();
            rb_Operario.Checked = true;
            rb_Gerente.Checked = false;
            tb_salarioBruto.Text = "";
            tb_salarioBrutoCalculado.Text = "";
            tb_imposto.Text = "";
            tb_salarioLiquido.Text = "";
        }

        private void carregarCombox()
        {
            List<Item> list = new List<Item>();

            list.Add(new Item { Nome = "Matutino", Valor = "1" });
            list.Add(new Item { Nome = "Vespertino", Valor = "2" });
            list.Add(new Item { Nome = "Noturno", Valor = "3" });

            list.Sort(delegate (Item a, Item b)
            {
                return a.Nome.CompareTo(b.Nome);
            });

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Valor";

            comboBox1.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicializar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_salarioBruto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            if (!tb_salarioBruto.Text.Equals(""))
            {
                Double salarioBruto = Convert.ToDouble(tb_salarioBruto.Text);
                String valueComboBox = (String)comboBox1.SelectedValue;
                Double salarioBrutoCalculado = 0.0;
                Double porcentagemBeneficio = 0.0;
                Double alicota = 0.0;
                Double imposto = 0.0;
                Double salarioLiquido = 0.0;
                Double parcelaDedutivel = 0.0;

                if (rb_Operario.Checked.Equals(true))
                {
                    if (valueComboBox.Equals("1") || valueComboBox.Equals("2"))
                    {
                        porcentagemBeneficio = 0.5;
                    }
                    else
                    {
                        porcentagemBeneficio = 0.7;
                    }
                }
                else
                {
                    if (rb_Gerente.Checked.Equals(true))
                    {
                        if (valueComboBox.Equals("1") || valueComboBox.Equals("2"))
                        {
                            porcentagemBeneficio = 1.0;
                        }
                        else
                        {
                            porcentagemBeneficio = 1.5;
                        }
                    }
                }

                salarioBrutoCalculado = ((salarioBruto * porcentagemBeneficio) / 100) + salarioBruto;
                tb_salarioBrutoCalculado.Text = formatarMoeda(salarioBrutoCalculado);


                if (salarioBrutoCalculado < 1499.15)
                {
                    imposto = 0.0;

                }
                else
                {
                    if (salarioBrutoCalculado > 1499.16 && salarioBrutoCalculado <= 22460.75)
                    {
                        alicota = 7.5 / 100;
                        parcelaDedutivel = 112.43;
                    }
                    else
                    {
                        if (salarioBrutoCalculado > 2246.76 && salarioBrutoCalculado <= 2995.75)
                        {
                            alicota = 15.0 / 100;
                            parcelaDedutivel = 280.94;
                        }
                        else
                        {
                            if (salarioBrutoCalculado > 2995.71 && salarioBrutoCalculado <= 3743.19)
                            {
                                alicota = 22.5 / 100;
                                parcelaDedutivel = 505.62;
                            }
                            else
                            {
                                if (salarioBrutoCalculado > 3743.19)
                                {
                                    alicota = 27.5 / 100;
                                    parcelaDedutivel = 692.78;
                                }
                            }
                        }
                    }

                    imposto = (salarioBruto * alicota) - parcelaDedutivel;
                }

                salarioLiquido = salarioBrutoCalculado - imposto;

                tb_salarioLiquido.Text = formatarMoeda(salarioLiquido);
                tb_imposto.Text = formatarMoeda(imposto);

            }

        }
        String formatarMoeda(Double value)
        {
            return String.Format("{0:C}", Convert.ToInt32(value));
        }

        private double Truncar(double valor)
        {
            valor *= 100;
            valor = Math.Truncate(valor);
            valor /= 100;

            return valor;
        }


    }
}
