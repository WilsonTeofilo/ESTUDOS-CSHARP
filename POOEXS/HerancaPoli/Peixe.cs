using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPoli
{
    internal class Peixe : Animal
    {
        public string corEscama { get; set; }
        public override void alimentar()
        {
            Console.WriteLine("comendo algas");
        }

        public override void emitirSom()
        {
            Console.WriteLine("peixe não faz som");
        }

        public override void locomover()
        {
            Console.WriteLine("Nadando");
        }


        public void SoltarBolha()
        {
            Console.WriteLine("soltou bolhas");
        }
    }
}
