using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUCANET
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool validaCadena(String cadena, String titulo)
        {

            if (cadena == "")
            {
                MessageBox.Show("TE FALTA EL DATO: " + " " + titulo);
                return false;
            }
            else return true;
        }
        private void FormPadre_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MDIParent1 FormularioPadre = new MDIParent1();

            string strUsuario;
            string strContra;
            if ((validaCadena(textUsuario.Text, "Usuario") == true) && (validaCadena(textPassword.Text, "Contraseña") == true))
            {

                strUsuario = textUsuario.Text;
                strContra = textPassword.Text;
                FormularioPadre.Show();
                FormularioPadre.FormClosing += new FormClosingEventHandler(FormPadre_FormClosing);
                this.Hide();

            }
            else MessageBox.Show("Algo está mal");
        }
    }
}

