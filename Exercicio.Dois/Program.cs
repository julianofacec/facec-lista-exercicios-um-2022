using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Dois
{
    internal class Program
    {
        //private static readonly decimal _valorCambioStatic = 5.22m;
        private const decimal _valorCambioConst = 5.22m;

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em $: ");

            string valorDigitado = Console.ReadLine();
            decimal valorConvertido = 0.0m;

            decimal.TryParse(valorDigitado, out valorConvertido);

            //não vai funcionar
            //_valorCambioConst = 1.22m;

            decimal valorCambioConvertido = valorConvertido * _valorCambioConst;

            Console.WriteLine($"Valor em R$: {valorCambioConvertido}");
            Console.ReadLine();
        }
    }
}
