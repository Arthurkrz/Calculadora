using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class CalculadoraCientifica : Calculadora
    {
        public virtual double Raiz(double numero)
        {
            return Math.Sqrt(numero);
        }
    }
}
