using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = ""; 
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResultado.Text += ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = ""; //irá limpar o resultado capitado e deixar vazio
            operacao = "SOMA"; // para o programa identitificar que a operação é soma
            labelOp.Text = "+"; // VAi deixar a calculadora mais visual / lblOperacao.Text irá transformar em string

        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                textResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                textResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                textResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if(operacao == "DIVISAO")
            {
                textResultado.Text = Convert.ToString(valor1 / valor2);
            }
                    
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "DIVISAO";
            lblOperacao.Text = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textResultado.Text += ".";
        }
    }
}
