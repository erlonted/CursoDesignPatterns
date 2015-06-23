using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double valor = 0;

            if (orcamento.Valor < 1000.00)
                valor = orcamento.Valor * 0.05;
            else if (orcamento.Valor >= 1000.00 && orcamento.Valor <= 3000.00)
                valor = orcamento.Valor * 0.07;
            else
                valor = (orcamento.Valor * 0.08) + 30.00;

            return valor;

        }
    }
}
