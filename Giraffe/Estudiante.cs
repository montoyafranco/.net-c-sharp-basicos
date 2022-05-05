using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe   
{ 
   
    internal class Estudiante
    {
        public string name;
        public string carrera;
        public double promedio; 

        public Estudiante(string name,string carrera,double promedio)
        {
            this.name = name;
            this.carrera = carrera;
            this.promedio = promedio;

        }
        public bool Honor()
        {
            if (promedio > 2)
            {
                return true;

            }else
            {
                return false;
            }
        }
    }
}
