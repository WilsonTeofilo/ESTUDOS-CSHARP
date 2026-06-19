using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace HerancaPoli
{
    internal abstract class Animal
    {
        public float peso { get; set; }
        public int idade { get; set; }
        public int membros { get; set; }

        public abstract void locomover();
        public abstract void alimentar();
        public abstract void emitirSom();

    }
}
