using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar_10
{
    public partial class Form1 : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void No_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            myEmpleado.pNombre = textBoxNombre.Text;
            myEmpleado.pIdentificacion = textBoxIdentificacion.Text;
            myEmpleado.pSalarioDia = Convert.ToDecimal(textBoxSalarioDia.Text);
            myNomina.pDiasLaborados = Convert.ToInt32(textBoxDiasLaborales.Text);
            MessageBox.Show("Se guardó el registro correctamente");
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            textBoxTotal = myNomina.CalcularNomina(Convert.ToInt32(myNomina.pDiasLaborados), Convert.ToDecimal(myEmpleado.pSalarioDia)).ToString();
        }
    }
}

