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

        private void button2_Click(object sender, EventArgs e)
        {
            //invocamos al objeto Form2
            Form2 FormularioCrucigrama = new Form2();

            string Login, Password; //variales de texto
            Login = txtLogin.Text.Trim(); //quita espacios en cualquier parte de la cadena
            Password = txtPassword.Text.TrimEnd(); //quita espacios al final
            if(Login=="Ofimega" && Password=="danone")
            {
                MessageBox.Show("Bienvenido al sistema");
                FormularioCrucigrama.Show();
            }
            else 
            {
                MessageBox.Show("Acceso denegado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Salir", "Salir",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)==System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
