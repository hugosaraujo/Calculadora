using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Basicas
{
    public class Subtracao
    {
        public double Valor1{ get; set; }
        public double Valor2{ get; set; }

        public double Calcular(double Valor1, double Valor2)
        {
            return Valor1 - Valor2;
        }
    }

}
