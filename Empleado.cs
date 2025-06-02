﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W
{
    internal class Empleado
    {
        public string Nombre {  get; set; }
        public double SueldoBase { get; set; }
        public virtual double CalcularSueldo()
        {
            return SueldoBase; 
        }
    }
}
