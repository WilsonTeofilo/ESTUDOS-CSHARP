using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace POOEXS
{
    internal class Lutador : ILutadorInter
    {
        public string nome { get; set; }
        public string nacionalidade { get; set; }
        public int idade { get; set; }
        public float altura { get; set; }
        public int vitorias { get; set; }
        public int derrotas { get; set; }
        public int empates { get; set; }
        private float _peso;
        private string _categoria; 


        public float peso{
            get
            {return this._peso;}
            set { this._peso = Math.Clamp(value, 0, 200);

                if (this._peso >= 40 && this._peso <= 50){
                    this._categoria = "Peso Pena";}
               
                else if (this._peso >= 50.01 && this.peso <= 60) {
                    this._categoria = "Peso Leve";}

                else if (this._peso >= 60.01 && this.peso <= 70) {
                    this._categoria = "Peso Médio";}

                else if (this._peso >= 70.01 && this.peso <= 80) {
                    this._categoria = "Peso Meio Pesado";}

                else if (this._peso >= 80.01 && this.peso <= 100) {
                    this._categoria = "Peso Pesado";}

                else{Console.WriteLine("Lutador inválido, não aceito em nenhuma categoria de peso");}
            }

        }//fimpeso

        public string Categoria
        {
            get { return this._categoria; }
        }


        public void Apresentar()
        {
            Console.WriteLine($"la vém ele o grande {this.nome}. \n Nascido em  {this.nacionalidade}: e pesando {this._peso}");
            Console.WriteLine($"lutando pela categoria : {this._categoria} e com cartel de : {this.vitorias} vitorias, {this.empates} Empates, e {this.derrotas} Derrotas");
        }

        public void Status()
        {
            Console.WriteLine("nome: " + this.nome);
            Console.WriteLine("Altura: " + this.altura);
            Console.WriteLine("Nacionalidade: " + this.nacionalidade);
            Console.WriteLine("Peso: " + this._peso);
            Console.WriteLine("Categoria: " + this._categoria);
            Console.WriteLine($" Cartel> Vitorias: {this.vitorias}, Derrotas: {this.derrotas}, Empates: {this.empates}");
        }
        public void Ganhar()
        {
            this.vitorias += 1;
        }

        public void Perder()
        {
            this.derrotas += 1;
        }

        public void Empatar()
        {
            this.empates += 1;
        }



        public Lutador (string nome, string nacionalidade, int idade,float altura, int vitorias, int derrotas, int empates, float peso)
        {
            this.nome = nome;
            this.nacionalidade = nacionalidade;
            this.idade = idade;
            this.altura = altura;
            this.vitorias = vitorias;
            this.derrotas = derrotas;
            this.empates = empates;
            this.peso = peso;
        }

    }
}
