using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Tres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distancia percorrida" +
                "em Km: ");
            decimal.TryParse(Console.ReadLine(), out decimal kmPercorrido);

            Console.WriteLine("Informe o combustivel gasto na viagem" +
                "em Litros: ");
            decimal.TryParse(Console.ReadLine(), out decimal litrosGastos);

            Console.WriteLine($"Sua média foi de {kmPercorrido / litrosGastos}");
            Console.ReadLine();

        }
    }
}