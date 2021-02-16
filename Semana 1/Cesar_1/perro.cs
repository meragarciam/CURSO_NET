using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_1
{
    public abstract class perro
    {
        public decimal altura;
        public decimal peso;
        public string color;
        public virtual String Ladrar()
        {
            return "Perro Ladrando";
        }
        public abstract String Dormir();
    }


        
        public class Chihuahua : perro
        {
            public override string Ladrar()
            {
                return "Chihuahua Ladrando";
            }
            public override string Dormir()
            {
                return "Chihuahua Durmiendo";
            }
        }
        public class Bulldog : perro
        {
            public override string Ladrar()
            {
                return "Bulldog Ladrando";
            }
            public override string Dormir()
            {
                return "Bulldog Durmiendo";
            }
        }
    
}

