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
    public partial class Form4 : Form
    {
        DataClasses1DataContext SalaLinq = new DataClasses1DataContext();
        public Form4()
        {
            InitializeComponent();
            this.listarsalas();
        }
        void listarsalas()
        {
            dataGrid.DataSource = SalaLinq.SP_ListarEnfermo();

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.listarsalas();
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
            string strCodSala;
            string strNombre;
            string strEspecialidad;

            if ((validaCadena(comboBox1.Text, "Codigo Hospital") == true) && (validaCadena(textCodSala.Text, "Codigo Sala") == true) && (validaCadena(textNombre.Text, "Nombre") == true))
            {
                if ((comboEspecialidad.SelectedItem != null))
                {
                   //strCodHospital = comboBox1.Text;
                   // strCodSala = int.Parse(textCodSala.Text);
                    strNombre = textNombre.Text;
                    strEspecialidad = comboEspecialidad.SelectedItem.ToString();

                    SalaLinq.SP_InsertaSala(int.Parse(textCodSala.Text), int.Parse(comboBox1.Text), textNombre.Text, comboEspecialidad.SelectedItem.ToString());
                    this.listarsalas();
                }
                else MessageBox.Show("Le falta señalar la Especialidad");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalaLinq.SP_EliminarSala(int.Parse(textCodSala.Text));
            this.listarsalas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalaLinq.SP_ModificarSala(int.Parse(textCodSala.Text), int.Parse(comboBox1.Text), textNombre.Text, comboEspecialidad.SelectedItem.ToString());
            this.listarsalas();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            comboBox1.Items.Insert(0, "Seleccione...")

            foreach (DataRow row in .Tables(0).Rows)
            {
                comboBox1.Items.Insert(row.ItemArray(0));
                aux++;
            }
        }
    }
    }
}
