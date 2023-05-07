using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Basicas
{
    public class Multiplicacao
    {
        public double Multiplicando{ get; set; }
        public double Multiplicador{ get; set; }

        public double Calcular(double Multiplicando, double Multiplicador)
        {
            return Multiplicando * Multiplicador;
        }
    }
}
