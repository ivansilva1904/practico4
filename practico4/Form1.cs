using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BUT_GENERAR_Click(object sender, EventArgs e)
        {
            LBOX_NUMEROS.Items.Clear();

            if (!string.IsNullOrWhiteSpace(TXT_DESDE.Text) && !string.IsNullOrWhiteSpace(TXT_HASTA.Text))
            {
                int desde = int.Parse(TXT_DESDE.Text);
                int hasta = int.Parse(TXT_HASTA.Text);

                if(desde < hasta)
                {
                    for(int i = desde; i <= hasta; i++)
                    {
                        LBOX_NUMEROS.Items.Add(i);
                    }
                }
                else
                {
                    for(int i = desde; i >= hasta; i--)
                    {
                        LBOX_NUMEROS.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void TXT_DESDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXT_HASTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BUT_PARES_Click(object sender, EventArgs e)
        {
            LBOX_NUMEROS.Items.Clear();

            if (!string.IsNullOrWhiteSpace(TXT_DESDE.Text) && !string.IsNullOrWhiteSpace(TXT_HASTA.Text))
            {
                int desde = int.Parse(TXT_DESDE.Text);
                int hasta = int.Parse(TXT_HASTA.Text);

                if (desde < hasta)
                {
                    for (int i = desde; i <= hasta; i++)
                    {
                        if (i % 2 == 0)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                    }
                }
                else
                {
                    for (int i = desde; i >= hasta; i--)
                    {
                        if(i % 2 == 0)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BUT_IMPARES_Click(object sender, EventArgs e)
        {
            LBOX_NUMEROS.Items.Clear();

            if (!string.IsNullOrWhiteSpace(TXT_DESDE.Text) && !string.IsNullOrWhiteSpace(TXT_HASTA.Text))
            {
                int desde = int.Parse(TXT_DESDE.Text);
                int hasta = int.Parse(TXT_HASTA.Text);

                if (desde < hasta)
                {
                    for (int i = desde; i <= hasta; i++)
                    {
                        if (i % 2 != 0)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                    }
                }
                else
                {
                    for (int i = desde; i >= hasta; i--)
                    {
                        if(i % 2 != 0)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BUT_PRIMOS_Click(object sender, EventArgs e)
        {
            LBOX_NUMEROS.Items.Clear();
            int a = 0;

            if (!string.IsNullOrWhiteSpace(TXT_DESDE.Text) && !string.IsNullOrWhiteSpace(TXT_HASTA.Text))
            {
                int desde = int.Parse(TXT_DESDE.Text);
                int hasta = int.Parse(TXT_HASTA.Text);

                if (desde < hasta)
                {
                    for (int i = desde; i <= hasta; i++)
                    {
                        for (int j = i; j >= 1; j--)
                        {
                            if(i % j == 0)
                            {
                                a++;
                            }
                        }
                        if(a == 2)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                        a = 0;
                    }
                }
                else
                {
                    for (int i = desde; i >= hasta; i--)
                    {
                        LBOX_NUMEROS.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
