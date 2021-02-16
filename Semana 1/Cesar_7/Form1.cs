using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            //SE CARGAN TODOS LOS CONTROLES DEL FORMULARIO
            InitializeComponent();
            //DIMENSIONAMOS UN ARRAY DE 5 STRINGS
            string[] nombres = new string[5];

            //DIMENSIO UN ARRAY DE CARACTERES
            nombres[0] = "JUANITO";
            nombres[1] = "PEDRITO";
            nombres[2] = "CORSINO";
            nombres[3] = "PELAYOR";

            Random generadorAleatorio = new Random();
            int nAleatorio = generadorAleatorio.Next(0, nombres.Length);

            string NombreX = nombres[nAleatorio];
            MessageBox.Show(NombreX);
            label1.Text = NombreX[0].ToString();
            label2.Text = NombreX[1].ToString();
            label3.Text = NombreX[2].ToString();
            label4.Text = NombreX[3].ToString();
            label5.Text = NombreX[4].ToString();
            label6.Text = NombreX[5].ToString();
            label7.Text = NombreX[6].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont=0;
            if (textBox1.Text == label1.Text)
            {
                cont++;
                label1.Visible = true;
            }
            if (textBox1.Text == label2.Text)
            {
                cont++;
                label2.Visible = true;
            }
            if (textBox1.Text == label3.Text)
            {
                cont++;
                label3.Visible = true;
            }
            if (textBox1.Text == label4.Text) 
            {
                cont++;
                label4.Visible = true;
            }
            if (textBox1.Text == label5.Text)
            {
                cont++;
                label5.Visible = true;
            }
            if (textBox1.Text == label6.Text) 
            {
                cont++;
                label6.Visible = true;
            }
            if (textBox1.Text == label7.Text) 
            {
                cont++;
                label7.Visible = true;
            }
            if (cont==0)
            {
                int intentos=0;
                intentos = int.Parse(numIntentos.Text);
                intentos--;
                numIntentos.Text = intentos.ToString();

                if (intentos < 0)
                {
                    MessageBox.Show("has fallado");
                    Application.Exit();
                }
            }
            if (label1.Visible == true && label2.Visible == true && label3.Visible == true && label4.Visible == true && label5.Visible == true && label6.Visible == true && label7.Visible == true)
            {
                MessageBox.Show("has acertado");
                Application.Exit();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}