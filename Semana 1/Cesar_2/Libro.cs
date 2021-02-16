using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cesar_2
{
    public class Libro
    {
        private string ISBN;
        private string TITULO;
        private int ESCRITOR;

        public string Alquilar()
        {
            return "ALQUILADO";
        }

        public string Vender()
        {
            return "VENDIDO";
        }
    }
}