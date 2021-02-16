using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_4
{
    public class Estudiante: Persona
    {
        string curso = ".NET";
        public void Estudiar()
        {
           
            Console.WriteLine("Estoy estudiando");
        }
        public void VerCurso()
        {
            
            Console.WriteLine("Mi curso es {0}" + this.curso);
        }
    }
}