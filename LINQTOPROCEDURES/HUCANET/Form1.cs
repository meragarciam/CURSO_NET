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
    public partial class Form1 : Form
    {
        DataClasses1DataContext EnfermoLinq = new DataClasses1DataContext();
    public Form1()
    {
            InitializeComponent();
            this.listarenfermos();
    }
     void listarenfermos()
    {
        dataGrid.DataSource = EnfermoLinq.SP_ListarEnfermo();

    }
    private void Form1_Load(object sender, EventArgs e)
    {
            this.listarenfermos();
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
        private void button1_Click(object sender, EventArgs e)
        {
            string strInscripcion;
            string strApellido;
            string strSexo;
            string strFecha;
            string strDireccion;
            string strNumSS;

            if (radioSexoM.Checked == true)
            {
                strSexo = "M";
            }
            else strSexo = "F";
            if ((validaCadena(textInscripcion.Text, "Inscripcion") == true) && (validaCadena(textNomApe.Text, "Nombre y Apellidos") == true) && (validaCadena(strSexo, "Sexo") == true) && (validaCadena(textFecha.Text, "Fecha") == true) && (validaCadena(textDireccion.Text, "Dirección") == true) && (validaCadena(textNumSS.Text, "Número SS") == true))
            {
                if ((radioSexoM.Checked != false) || (radioSexoF.Checked != false)) { 
                strInscripcion = textInscripcion.Text;
                strApellido = textNomApe.Text;
                strFecha = textFecha.Text;
                strDireccion = textDireccion.Text;
                strNumSS = textNumSS.Text;
                
                EnfermoLinq.SP_InsertaEnfermo(int.Parse(textInscripcion.Text), textNomApe.Text, textDireccion.Text, Convert.ToDateTime(textFecha.Text), strSexo, int.Parse(textNumSS.Text));
                this.listarenfermos();
                }
                else MessageBox.Show("Le falta marcar el Sexo");

            }
            

        }
       
        private void radioSexoM_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strSexo;
            if (radioSexoM.Checked == true)
            {
                strSexo = "M";
            }
            else strSexo = "F";

            EnfermoLinq.SP_ModificarEnferno(int.Parse(textInscripcion.Text), textNomApe.Text, textDireccion.Text, Convert.ToDateTime(textFecha.Text), strSexo, int.Parse(textNumSS.Text));
            this.listarenfermos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnfermoLinq.SP_EliminarEnfermo(int.Parse(textInscripcion.Text));
            this.listarenfermos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

