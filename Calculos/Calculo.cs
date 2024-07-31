﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public static class Calculo
    {
        //método que retorna a soma
        public static double Somar(double x, double y)
        {
            return (x + y);
        }

        public static double Dividir(double x, double y)
        {
            return (x /  y);
        }

        public static double Subtrair(double x, double y)
        { 
            return (x - y);
        }

        public static double Multiplicar(double x, double y) 
        { 
            return (x * y);
        }

        public static double Modulo(double x)
        {
            return Math.Abs(x);
        }

    }
}
