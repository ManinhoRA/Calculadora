using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        double numero1 = 0, numero2 = 0;
        char operador;
        bool adicao;
        bool subtracao;
        double valor1;
        double valor2;

        public frmCalculadora()
        {
            InitializeComponent();
        }
        private void UsarNumero(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
            var botao = ((Button)sender);
            if (txtResultado.Text == "0")
                txtResultado.Text = "";
                txtResultado.Text += botao.Text;
        }
        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultado.Text);
            valor1 = numero1 / 100;
            numero2 = valor1 * numero2;
            valor2 = numero2;
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultado.Text);

            if (operador == '+')
            {
                if (valor2 == 0)
                {
                    txtResultado.Text = (numero1 + numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
                if (valor2 > 0)
                {
                    txtResultado.Text = (numero1 + valor2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
            }
            else if (operador == '-')
            {
                if (valor2 == 0)
                {
                    txtResultado.Text = (numero1 - numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
                if (valor2 > 0)
                {
                    txtResultado.Text = (numero1 - valor2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
            }
            else if (operador == '*')
            {
                if (valor2 == 0)
                {
                    txtResultado.Text = (numero1 * numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
                if (valor2 > 0)
                {
                    txtResultado.Text = valor2.ToString();
                    valor2 = Convert.ToDouble(txtResultado.Text);
                }
            }
            else if (operador == '/')
            {
                if (valor2 == 0)
                {
                    txtResultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
                if (valor2 > 0)
                {
                    double resDiv = numero1 / (numero2 / 100);
                    double valorDiv = Convert.ToDouble(resDiv);
                    numero1 = valorDiv;
                    txtResultado.Text = numero1.ToString();
                }
                //else
                //{
                //    lblAviso.Visible = true;
                //    lblAviso.Text = "Impossível dividir por zero";
                //}
            }
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0"; 
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = '\0';
            txtResultado.Text = "0";
            lblAviso.Visible = false;
        }
        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            lblAviso.Visible = false;
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }
        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            numero1 *= -1;
            txtResultado.Text = numero1.ToString();
        }
        private void Operador(object sender, EventArgs e)
        {
            var botao = ((Button)sender);

            numero1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(botao.Tag);

            if (operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                txtResultado.Text = numero1.ToString();
            }
            else if (operador == '²')
            {
                numero1 = Math.Pow(numero1, 2);
                txtResultado.Text = numero1.ToString();
            }
            else if (operador == '-')
            {
                numero2 = Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = "0";
            }
            else
            {
                txtResultado.Text = "0";
            }
        }
    }
}
