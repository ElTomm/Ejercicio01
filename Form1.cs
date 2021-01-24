using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpeEjercicio1
{
    public partial class lblv1 : Form
    {
        static operaciones op = new operaciones();
        public lblv1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblResultado.Text = op.Mult(Double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();
        }

        private void cmdSuma_Click(object sender, EventArgs e)
        {
            lblResultado.Text = op.Suma(Double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void cmdResta_Click(object sender, EventArgs e)
        {
            lblResultado.Text = op.Resta(Double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();
        }

        private void cmdDiv_Click(object sender, EventArgs e)
        {
            lblResultado.Text = op.Div(Double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
