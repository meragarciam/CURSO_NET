using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_11
{
    class Persona
    {
        string strNombre;
        public string pNombre
        {
            get
            {
                return strNombre;
            }
            set
            {
                strNombre = value;
            }
        }
        public string Asistir()
        {
            return  "asiste a la escuela";
        }
    }
}
