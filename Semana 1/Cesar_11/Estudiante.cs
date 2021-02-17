using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_11
{
    class Estudiante : Persona
    {
        
        int intCalificacion;
        
        public int pCalificacion
        {
            get
            {
                return intCalificacion;
            }
            set
            {
                intCalificacion = value;
            }
        }
        
        public string Estudiar()
        {
            return  "esta estudiando";
        }
    }
}
