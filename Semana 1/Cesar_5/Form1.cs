using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton para sumar
            int num1, num2, resultado;
            if ((txtNumero1.Text == "") || (txtNumero2.Text == ""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
            num1 = int.Parse(txtNumero1.Text);
            num2 = int.Parse(txtNumero2.Text);
            resultado = num1 + num2;
            txtResultado.Text = resultado.ToString();
            }
        }

        private void textNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //boton para restar
            int num1, num2, resultado;
            if ((txtNumero1.Text == "") || (txtNumero2.Text == ""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                num1 = int.Parse(txtNumero1.Text);
                num2 = int.Parse(txtNumero2.Text);
                resultado = num1 - num2;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //boton para multiplicar
            int num1, num2, resultado;
            if ((txtNumero1.Text == "") || (txtNumero2.Text == ""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                num1 = int.Parse(txtNumero1.Text);
                num2 = int.Parse(txtNumero2.Text);
                resultado = num1 * num2;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //boton para dividir
            int num1, num2, resultado;
            if ((txtNumero1.Text == "") || (txtNumero2.Text == ""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                num1 = int.Parse(txtNumero1.Text);
                num2 = int.Parse(txtNumero2.Text);
                resultado = num1 / num2;
                txtResultado.Text = resultado.ToString();
            }

        }
    }
}
