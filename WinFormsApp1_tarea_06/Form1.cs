using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_tarea_06
{
    public partial class Form1 : Form
    {
        public string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_contar_Click(object sender, EventArgs e)
        {
            //Por verdad (Contar) => Se inhabilita el textBox de entrada, se cambia el mensaje del boton
            //              "Contar" a "clear", cuenta y muestra los valores en el textBox de salida.
            //Por falso (Clear) => Se recetean los valores.
            if (bttn_contar.Text.Equals("Contar")) {
                //Se valida que el TextBox "entrada" tiene un valor.
                if (!txtBx_entrada.Text.Equals("")) {
                    txtBx_entrada.Enabled = false;
                    bttn_contar.Text = "Contando...";
                    bttn_contar.Enabled = false;

                    int entrada = int.Parse(txtBx_entrada.Text);

                    contar_for(entrada);
                    txtBx_salida.AppendText("\r\n");
                    contar_while(entrada);
                    txtBx_salida.AppendText("\r\n");
                    contar_do_while(entrada);

                    bttn_contar.Text = "Clear";
                    bttn_contar.Enabled = true;
                }
            }
            else{
                txtBx_entrada.Text = "";
                txtBx_salida.Text = "";
                txtBx_entrada.Enabled = true;
                bttn_contar.Text = "Contar";
                bttn_contar.Enabled = true;
            }
        }

        private void contar_for(int entrada) {
            txtBx_salida.AppendText("Contar - for: \r\n");
            //string salida = "";
            for (int i = 0; i <= entrada; i++)
            {
                if (i < entrada)
                {
                    txtBx_salida.AppendText(i.ToString() + ", ");
                    //txtBx_salida.Text = txtBx_salida.Text + i.ToString() + ", ";
                    //salida = salida + i.ToString() + ", ";
                }
                else
                {
                    txtBx_salida.AppendText(i.ToString() + ".");
                    //txtBx_salida.Text = txtBx_salida.Text + i.ToString() + ". ";
                    //salida = salida + i.ToString() + ".";
                }
            }
            //txtBx_salida.Text = "";
            //txtBx_salida.Text = salida;
        }
        private void contar_while(int entrada)
        {
            int i = 0;
            txtBx_salida.AppendText("Contar - while: \r\n"); 
            while (i <= entrada) {
                if (i < entrada)
                {
                    txtBx_salida.AppendText(i.ToString() + ", ");
                }
                else
                {
                    txtBx_salida.AppendText(i.ToString() + ".");
                }
                i++;
            }
        }

        private void contar_do_while(int entrada)
        {
            int i = 0;
            txtBx_salida.AppendText("Contar - do while: \r\n");
            do {
                if (i < entrada)
                {
                    txtBx_salida.AppendText(i.ToString() + ", ");
                }
                else
                {
                    txtBx_salida.AppendText(i.ToString() + ".");
                }
                i++;
            } while (i<=entrada);
        }
        private void txtBx_salida_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de salida no puede recibir valores.
            if (e.KeyChar >= 0 && e.KeyChar <= 255) {
                e.Handled = true;
            }
        }

        private void txtBx_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de entrada solo puede recibir numeros.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >=58 && e.KeyChar <=255))
            {
                e.Handled = true;
            }
        }
    }
}
