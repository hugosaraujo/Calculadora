using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Basicas;

namespace Calculadora
{
    public class Operacoes
    {
        public Soma Soma { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }
        public Divisao Divisao { get; private set; }

        public Operacoes()
        {
            Soma = new Soma();
            Subtracao = new Subtracao();
            Multiplicacao = new Multiplicacao();
            Divisao = new Divisao();
        }
    }
}
