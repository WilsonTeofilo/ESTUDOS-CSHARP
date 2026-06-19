using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano = DateTime.Now.Year;
            int anoNasc = 0;
            Console.WriteLine("em que ano você nasceu?");
            int.TryParse(Console.ReadLine(), out anoNasc);
            Console.WriteLine("atualmente estamos no ano " + ano);
            Console.WriteLine($"se você nasceu em {anoNasc}, você vai ter {ano-anoNasc}");
            Console.ReadKey();

        }
    }
}
