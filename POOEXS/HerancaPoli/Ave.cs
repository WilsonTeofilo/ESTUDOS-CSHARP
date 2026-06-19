using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPoli
{
    internal class Ave : Animal
    {
        public string corPena { get; set; }
        public override void alimentar()
        {
            Console.WriteLine("comendo frutas");
        }

        public override void emitirSom()
        {
            Console.WriteLine("som de ave");
        }

        public override void locomover()
        {
            Console.WriteLine("Voando");
        }

        public void fazerNinho()
        {
            Console.WriteLine("construiu um ninho");
        }
    }
}
