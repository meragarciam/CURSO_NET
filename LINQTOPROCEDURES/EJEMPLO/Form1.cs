using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJEMPLO
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
            this.listarclientes();
        }
        void listarclientes()
        {
            dataGrid.DataSource = ClienteLinq.SP_ListarClientes();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listarclientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.SP_ModificarCliente(textNombre.Text, textApellidoM.Text, textApellidoP.Text, textTelefono.Text);
            this.listarclientes();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.SP_EliminarCliente(textNombre.Text);
            this.listarclientes();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.SP_InsertaCliente(textNombre.Text, textApellidoM.Text, textApellidoP.Text, textTelefono.Text);
            this.listarclientes();
        }
    }
}
