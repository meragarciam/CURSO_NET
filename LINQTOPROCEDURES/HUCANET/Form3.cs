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
    public partial class Form3 : Form
    {
        DataClasses1DataContext DoctorLinq = new DataClasses1DataContext();
        public Form3()
        {
            InitializeComponent();
            this.listardoctor();
        }
        void listardoctor()
        {
            dataGrid.DataSource = DoctorLinq.SP_ListarDoctor();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNomApe_TextChanged(object sender, EventArgs e)
        {

        }

        private void textInscripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.listardoctor();
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
            string strCodHospital;
            string strNumDoctor;
            string strNomApel;
            string strEspecialidad;


            if ((validaCadena(textCodHospital.Text, "Codigo Hospital") == true) && (validaCadena(textNumDoctor.Text, "Numero de Doctor") == true) && (validaCadena(textNomApe.Text, "Nombre y Apellidos") == true))
            {
                if ((comboEspecialidad.SelectedItem != null))
                {
                    strCodHospital = textCodHospital.Text;
                    strNumDoctor = textNumDoctor.Text;
                    strNomApel = textNomApe.Text;
                    strEspecialidad = comboEspecialidad.SelectedItem.ToString();


                    DoctorLinq.SP_InsertaDoctor(int.Parse(textCodHospital.Text), int.Parse(textNumDoctor.Text), textNomApe.Text, comboEspecialidad.SelectedItem.ToString());
                    this.listardoctor();
                }
                else MessageBox.Show("Le falta señalar la Especialidad");
            }

            //private void button3_Click(object sender, EventArgs e)
            //{

            //}

            //private void button4_Click(object sender, EventArgs e)
            //{

            //}

            //private void button5_Click(object sender, EventArgs e)
            //{

            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoctorLinq.SP_ModificarDoctor1(int.Parse(textCodHospital.Text), int.Parse(textNumDoctor.Text), textNomApe.Text, comboEspecialidad.SelectedItem.ToString());
            this.listardoctor();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoctorLinq.SP_EliminarDoctor(int.Parse(textNumDoctor.Text));
            this.listardoctor();
        }
    }
}
