using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar_11
{
    public partial class Form1 : Form
    {
        //VARIABLES GLOBALES
        Profesor p1 = new Profesor(); //SOLO CREO UNO Y MODIFICO SUS DATOS
        Estudiante e1; //CREO VARIOS ESTUDIANTES. INICIALIZAMOS PERO NO CREAMOS
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioProfesor.Checked==true)
                {
                
                p1.pNombre = textBoxNombre.Text;
                p1.pSueldo = Convert.ToDouble(textBoxSueldo.Text);
               
                }
                else
                {
                e1 = new Estudiante(); //ASI CREAMOS VARIOS ESTUDIANTES
                e1.pNombre = textBoxNombre.Text;
                e1.pCalificacion = Convert.ToInt32(textBoxCalificacion.Text);
                }
            MessageBox.Show("Se guardó el registro correctamente");
            }
            catch
            {
                MessageBox.Show("hay algún error");
            }
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
          
            if (radioProfesor.Checked == true)
            {
                string cadena = "Nombre:" +" "+ p1.pNombre + "\n" + "Sueldo:" + " "+p1.pSueldo + "\n" + p1.pNombre +" "+ p1.Asistir() + "\n" + p1.pNombre + " " + p1.Enseñar();
                MessageBox.Show(cadena);   
            }
            else
            {
                string cadena = "Nombre:" + " " + e1.pNombre + "\n" + "Calificación:" + " " + e1.pCalificacion + "\n" + e1.pNombre + " " + e1.Asistir() + "\n" + e1.pNombre + " " + e1.Estudiar();
                MessageBox.Show(cadena);
            }
        }

        private void radioProfesor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCalificacion.Enabled = false;
            textBoxSueldo.Enabled = true;
            textBoxSueldo.Clear();
            textBoxCalificacion.Clear();
        }

        private void radioEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCalificacion.Enabled = true;
            textBoxSueldo.Enabled = false;
            textBoxSueldo.Clear();
            textBoxCalificacion.Clear();
        }
    }
}
