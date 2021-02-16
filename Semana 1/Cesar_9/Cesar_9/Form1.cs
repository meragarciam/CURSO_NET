using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar_9
{
    public partial class Alumno : Form
    {
        string nombre;
        int edad;
        int nota;
       
        public void Inicializar()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad: ");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
            string linea1;
            Console.Write("Ingrese la nota: ");
            linea1= Console.ReadLine();
            nota = int.Parse(linea1);
        }
        public void AsignarCurso()
        {
            if (nota >= 40 && nota <= 59) MessageBox.Show("B1 Lower Intermediate");
            if (nota >= 60 && nota <= 74) MessageBox.Show("B2 Intermediate");
            if (nota >= 75 && nota <= 89) MessageBox.Show("C1 Upper Intermediate");
            if (nota >= 90 && nota <= 100) MessageBox.Show("C2 Advanced");
        }
        public void Imprimir()
        {
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
            Console.Write("Nota: ");
            Console.WriteLine(nota);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
