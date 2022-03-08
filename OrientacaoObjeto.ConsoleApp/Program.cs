using System;

namespace OrientacaoObjeto.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Caixa caixa = new Caixa();

            caixa.altura = 10;
            caixa.largura = 10;
            caixa.comprimento = 10;

            Console.WriteLine( "O volume da caixa é: " + caixa.ValorFinal());
            Console.ReadKey();

        }
    }
}
