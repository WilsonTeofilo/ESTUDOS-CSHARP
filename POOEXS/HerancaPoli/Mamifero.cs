using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPoli
{
    internal class Mamifero : Animal
    {
        public string corPelo { get; set; }



        public override void alimentar()
        {
            Console.WriteLine("Mamando...");   
        }

        public override void emitirSom()
        {
            Console.WriteLine("som de mamífero");
        }

        public override void locomover()
        {
            Console.WriteLine("Correndo");
        }
    }
}
