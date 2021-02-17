using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_12
{
    class Persona
    {
        private string strNombre;
        private DateTime dtmFechaNacimiento;
        public int intEdad;
        private int intCredito;
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
        public int pCredito
        {
            get
            {
                return intCredito;
            }
            set
            {
                intCredito = value;
            }
        }
        public DateTime pFechaNacimiento
        {
            get
            {
                return dtmFechaNacimiento;
            }
            set
            {
                dtmFechaNacimiento = value;
            }
        }
        
        public int CalcularEdad()
        {
            
            TimeSpan intervalo;
            intervalo = DateTime.Now - (this.pFechaNacimiento);
            intEdad = (int)(intervalo.Days / 365.25);
            return intEdad;
        }
    }
}
