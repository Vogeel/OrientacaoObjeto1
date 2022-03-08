using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto.ConsoleApp
{
    internal class Caixa
    {
        public int altura;
        public int largura;
        public int comprimento;

        public double ValorFinal()
        {
            double Volume = altura * largura * comprimento;
            return Volume;
        }
    }
}
