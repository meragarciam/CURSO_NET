using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_11
{
    class Profesor: Persona
    {
        
        double dlbSueldo;
       
        public double pSueldo
        {
            get
            {
                return dlbSueldo;
            }
            set
            {
                dlbSueldo = value;
            }
        }
        
        public string Enseñar()
        {
            return  "esta enseñando";
        }
    }
}
