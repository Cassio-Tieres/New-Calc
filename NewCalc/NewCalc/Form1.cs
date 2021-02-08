using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalc
{
    public partial class Form1 : Form
    {
        int valor1;
        int valor2;

        int resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtValores_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt16(txtValores.Text);
            valor2 = Convert.ToInt16(txtValores2.Text);

            resultado = valor1 + valor2;
            lblResultado.Text = Convert.ToString(resultado);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt16(txtValores.Text);
            valor2 = Convert.ToInt16(txtValores2.Text);

            resultado = valor1 - valor2;
            lblResultado.Text = Convert.ToString(resultado);
        }
    }
}
