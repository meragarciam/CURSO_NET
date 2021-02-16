using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_4
{
    public class Persona
    {
        //atributos solo accesibles en la misma clase
        protected string nombre;
        protected int edad;
        protected string apellidos;

        //metodos de carga, se carga valores por referencia
        public void SetNombre (String name)
        {
            nombre = name; 
        }
        public void Setapellidos (String surName)
        { 
            apellidos = surName; 
        }
        public void SetEdad (int age) 
        {
            edad = age;
        }

        public void Inicializar()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese los apellidos: ");
            apellidos = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad: ");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
        }

        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write("Es mayor de edad");
            }
            else
            {
                Console.Write("No es mayor de edad");
            }
            Console.ReadKey();
        }

        public void Saludar()
        {
            Console.WriteLine(this.nombre + "-ff"+ this.apellidos+ "Hola");
            if (this.edad > 18) Console.WriteLine("Y eres mayor de edad");
            else Console.WriteLine("Y eres menor de edad");
        }

        public void ModificarDatos(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}