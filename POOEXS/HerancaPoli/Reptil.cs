using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPoli
{
    internal class Reptil : Animal{
        public string corEscama { get; set; }

        public override void alimentar()
        {
            Console.WriteLine("Comendo Vegetais");  
        }

        public override void emitirSom()
        {
            Console.WriteLine("sons de Réptil");  
        }

        public override void locomover()
        {
            Console.WriteLine("Rastejando");
        }
    }
}
