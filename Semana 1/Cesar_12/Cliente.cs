using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_12
{
    class Cliente: Persona
    {
        public bool EsMayorEdad()
        {
            intEdad = base.CalcularEdad();
            if (intEdad >= 18) return (true);
            else return (false);
        }
    }
}
