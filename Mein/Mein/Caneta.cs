using System;
using System.Collections.Generic;
using System.Text;

namespace Mein
{
    internal class Caneta
    {
        private int _carga;
        public float Ponta { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public bool Tampada { get; set; }

        public int Carga{
            get
            {
                return this._carga;
            }

            set
            {
                int ValorFuturo = this._carga + value;
                this._carga = Math.Clamp(ValorFuturo, 0, 100);

                if (this._carga >= 100)
                {
                    Console.WriteLine("Sua caneta está cheia, não é possível encher mais");
                }

                else if (this._carga <=0)
                {
                    Console.WriteLine("sua caneta está vazia, encha");
                }


            }
    }
        //fim get set Carga

        public void Escrever()
        {
           
            if (this._carga <= 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Sua carga está baixa, coloque tinta na caneta!");
                Console.ResetColor(); 
                return; 
            }

         
            if (this.Tampada == true)
            {
                Console.WriteLine("Impossível escrever, caneta tampada.");
                return; 
            }

            Console.WriteLine("Escrevendo.....");

            this.Carga = -5;
        }

        public void Status()
        {
            Console.WriteLine("Sua caneta é da cor: " + this.Cor);
            Console.WriteLine("MARCA: " +this.Marca);
            Console.WriteLine("CARGA DE TINTA DA CANETA:" +this._carga  + "%");
            Console.WriteLine("Tampada? " + this.Tampada);
        }

    

        public Caneta (int cargas, float pontas,string marcas,string cores, bool tampadas)
        {
            this.Carga = cargas;
            this.Ponta = pontas;
            this.Marca = marcas;
            this.Cor = cores;
            this.Tampada = tampadas;

        }


    





    }
}
