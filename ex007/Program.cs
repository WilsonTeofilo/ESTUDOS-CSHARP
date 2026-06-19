using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ex007
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int inicio = 0;
            int fim = 0;

            Console.WriteLine("sorteador de número, coloque o numero mínimo e o número maximo a ser sorteado:");
            await Task.Delay(2000);
            Console.WriteLine("NÚMERO MÍNIMO:");
            //
            int.TryParse(ReadLine(),out inicio);
            Console.BackgroundColor = ConsoleColor.Magenta;
            await Task.Delay(2000);
            Console.WriteLine("NUMERO MAXIMO:");
            int.TryParse(ReadLine(), out fim);
            fim += 1;

            Random gerador = new Random();
           int aleatorio = gerador.Next(inicio, fim);

            ResetColor();
            Console.WriteLine("NUMERO ALEATORIO GERADO: " +aleatorio);
            ReadKey();



        }
    }
}
