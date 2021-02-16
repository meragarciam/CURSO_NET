using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante();
            //e1.Edad = 15;
            //e1.Nombre = "Paco";
            //e1.Apellidos = "Suárez Fernández";
            e1.Inicializar();
            e1.Saludar();
            e1.SetNombre("Monica");

            e1.VerCurso();
            e1.Estudiar();
            int edad;
            edad = int.Parse(Console.ReadLine());
            e1.SetEdad(21);

            Console.WriteLine("\n");

            Profesor p1 = new Profesor();
            //p1.Edad = 37;
            //p1.Nombre = "Ana";
            //p1.Apellidos = "Marina García";
            p1.Inicializar();
            p1.Saludar();
           
            p1.Explicar();

            Console.ReadKey();
        }

        private static void ejercicio1Persona()
        {
            Persona per1 = new Persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.EsMayorEdad();
        }
    }
}
