using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_9
{
    class Alumno
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
            linea1 = Console.ReadLine();
            nota = int.Parse(linea1);
        }
        public void AsignarCurso()
        {
            if (nota <= 40 && nota >= 59) Console.WriteLine("B1 Lower Intermediate");
            if (nota <= 60 && nota >= 74) Console.WriteLine("B2 Intermediate");
            if (nota <= 75 && nota >= 89) Console.WriteLine("C1 Upper Intermediate");
            if (nota <= 90 && nota >= 100) Console.WriteLine("C2 Advanced");
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
    }
}
