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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intentos;
            intentos = int.Parse(textIntentos.Text);
            textBox1.Text.ToUpper(); textBox2.Text.ToUpper(); textBox3.Text.ToUpper(); textBox4.Text.ToUpper();

                if ((textBox1.Text== "L") && (textBox2.Text == "O") && (textBox3.Text == "R") && (textBox11.Text == "R") && (textBox10.Text == "A") && (textBox9.Text == "T") && (textBox4.Text == "O") && (textBox8.Text == "N") && (textBox5.Text == "S") && (textBox6.Text == "R") && (textBox7.Text == "O"))
                {
                MessageBox.Show("Hecho");
                }
                else
                {
                intentos++;
                textIntentos.Text = intentos.ToString();
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
