﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_1
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Chihuahua _Chihuahua1 = new Chihuahua();
            Chihuahua _Chihuahua2 = new Chihuahua();
            Bulldog _Bulldog1 = new Bulldog();
            Bulldog _Bulldog2 = new Bulldog();

            
         
            perro[] _Perrera = { _Chihuahua1, _Chihuahua2, _Bulldog1, _Bulldog2 };
            foreach( perro item in _Perrera)
            {
                Console.WriteLine(item.Ladrar());
                Console.WriteLine(item.Dormir());
            }
            Console.ReadLine();

            
        }
    }
}
