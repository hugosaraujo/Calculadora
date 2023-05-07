using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Basicas
{
    public class Divisao
    {
        public double Dividendo{ get; set; }
        public double Divisor{ get; set; }

        public double Calcular(double Valor1,  double Valor2)
        {
            if (Divisor == 0) 
            {
                return 0; 
            }
            
            return Valor1 / Valor2;
        }
    }
}
