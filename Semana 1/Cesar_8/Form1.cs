using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cesar_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean IsValid (String Caja)
        {
            if (Caja != "") return true;
            else return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
            using (var writetext =new StreamWriter ("write.txt"))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    writetext.WriteLine($"{row.Cells[0].Value}, { row.Cells[1].Value}, { row.Cells[2].Value}, { row.Cells[3].Value}, { row.Cells[4].Value}, { row.Cells[5].Value}, { row.Cells[6].Value}, { row.Cells[7].Value}, { row.Cells[8].Value}, { row.Cells[9].Value}, { row.Cells[10].Value}");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFichero_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBoxHabitacion.Text, textBoxCliente.Text, textBoxTrabajador.Text, textBoxCosta.Text, TextBoxObservacion, comboBoxEstado.Items, comboBoxReserva.Items, dateTimeIngreso.Value, dateTimeReserva.Value, dateTimeSalida.Value);
        }
    }
}
