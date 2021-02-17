using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_10
{
    class Nomina
    {
        private int intDiasLaborados;
        public int pDiasLaborados
        {
            get
            {
                return intDiasLaborados;
            }
            set
            {
                intDiasLaborados = value;
            }
        }
        public decimal CalcularNomina (int intDiasLaborados, decimal dclSalarioDia)
        {
            decimal totalSalario = intDiasLaborados * dclSalarioDia;
            return totalSalario;
        }

    }
}
