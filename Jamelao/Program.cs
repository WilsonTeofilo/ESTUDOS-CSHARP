using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.CodeDom;

namespace Jamelao
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //testando metodos math e linq
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite um Número");
            Console.ResetColor();
            double num = 0;
            double.TryParse(Console.ReadLine(), out num);
            Console.WriteLine($"seu numero com 3 casas decimais {num:N3}");
            await Task.Delay(2000);
            Console.WriteLine($"Seu número sem os decimais: {Math.Truncate(num)}");
            Console.WriteLine($"seu número arredondado é :  {Math.Round(num)}");
            await Task.Delay(2000);

            int[] vetor = { 3, 5, 9, 1, 3 };
            Console.Write($"Números do vetor: ");
            for (int cont = 0; cont <= vetor.Length-1; cont++)
            {  
                Console.Write($"{vetor[cont]},");   
            }
            await Task.Delay(2000);
            Console.WriteLine($"Maior número do vetor: {vetor.Max()}");
            Console.WriteLine($"Menor Número do vetor: {vetor.Min()}");

            int var1 = 33;
            int var2 = 44;

            await Task.Delay(2000);

            Console.WriteLine($"se tenho uma variavel com o valor: {var1} e outra {var2}... " +
                $"a menor é : {Math.Min(var1,var2)} e a maior é : {Math.Max(var1,var2)} " );
            Console.Clear();
            
            //clamp
            double nota1 = 0;
            double nota2 = 0;
            double media = 0;

            await Task.Delay(2000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("nota do 1 semestre de wilson");
            Console.ResetColor();
            double.TryParse(Console.ReadLine(), out nota1);
            //
            await Task.Delay(2000);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("nota do 2 semestre de wilson");
            double.TryParse(Console.ReadLine(), out nota2);

            media = (nota1 + nota2)/ 2;
            double final = Math.Clamp(media, 0, 10);


            Console.WriteLine($"Nota final é  {final}");

        }
    }
}
