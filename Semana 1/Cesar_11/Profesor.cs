using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_11
{
    class Profesor: Persona
    {
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
    }
}
