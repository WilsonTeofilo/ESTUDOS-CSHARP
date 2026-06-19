using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            Console.WriteLine("digite um numero");
            double.TryParse(Console.ReadLine(), out num);

     
            Console.WriteLine($"você digitou o valor {num:N3}");
            Console.WriteLine($"a parte inteira dele é : {Math.Truncate(num)}");
            Console.WriteLine($"e arredondando temos : {Math.Round(num)}");
            
            
            Console.ReadKey();

        }
    }
}
