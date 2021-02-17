using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar_12
{
    public partial class Form1 : Form
    {
        Cliente per;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            per = new Cliente();
            try
            {
                per.pNombre = textBoxNombre.Text;
                per.pCredito = Convert.ToInt32(textBoxCredito.Text);
                per.pFechaNacimiento = Convert.ToDateTime(dateNacimiento.Text);
                
            
            if (per.EsMayorEdad()) 
            { 
                string cadena = per.pNombre + " " +"tiene"+" "+per.intEdad+" "+ "años"+ "\n" + per.pNombre + " " + "es mayor de edad" + "\n"+ "Limite de credito"+ " " + per.pCredito;
                MessageBox.Show(cadena);
            }
            else
            {
                string cadena = per.pNombre + " " + "tiene" +" "+ per.intEdad + " " + "años" + "\n" + per.pNombre + " " + "es menor de edad" + "\n" + "Limite de credito" + " " + per.pCredito;
                MessageBox.Show(cadena);
            }
            }
            catch
            {
                MessageBox.Show("hay algún error");
            }
        }
    }
}
