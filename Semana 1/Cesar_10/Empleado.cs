using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cesar_10
{
    class Empleado
    {
        string strNombre;
        string strIdentificacion;
        decimal dclSalarioDia;
        

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
        public string pIdentificacion
        {
            get
            {
                return strIdentificacion;
            }
            set
            {
                strIdentificacion = value;
            }
        }
        public decimal pSalarioDia
        {
            get
            {
                return dclSalarioDia;
            }
            set
            {
                dclSalarioDia = value;
            }
        }
         
    }
}
