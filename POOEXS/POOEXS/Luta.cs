using System;
using System.Collections.Generic;
using System.Text;

namespace POOEXS
{
    internal class Luta 
    {
        private Lutador _desafiado;
        private Lutador _desafiante;
        private bool _aprovado;
        public int rounds; 



        public void marcarLuta(Lutador l1, Lutador l2, int round){
            if (l1 != l2 && l1.Categoria == l2.Categoria && !string.IsNullOrEmpty(l1.Categoria)) {
                this._desafiante = l1;
                this._desafiado = l2;
                this.rounds = round;
                this._aprovado = true;}

            else{
                this._desafiante = null;
                this._desafiado = null;
                this.rounds = 0;
                this._aprovado = false;}
        }

        public async Task Lutar(){
            if (this._aprovado== true)
            {
                Console.WriteLine("No corner azul....");
                await Task.Delay(3500);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                _desafiado.Apresentar();
                Console.ResetColor();

                Console.WriteLine("No Corner Vermelho....");
                await Task.Delay(3500);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                _desafiante.Apresentar();
                Console.ResetColor();

                Console.WriteLine("começa nossa luta de " + this.rounds + " Rounds");

                Random decisao = new Random();

                int result = decisao.Next(0, 4);

                switch (result)
                {
                    case 1: // Empate
                        Console.WriteLine(" FIM DE PAPO! Os juízes deram empate!");
                        this._desafiado.Empatar();
                        this._desafiante.Empatar();
                        Console.WriteLine("com isso os novos cartéis são:");
                        await Task.Delay(3500);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"DESAFIANTE - {this._desafiante.nome} : V: {this._desafiante.vitorias}, D: {this._desafiante.derrotas}, E: {this._desafiante.empates}");
                        Console.ResetColor();
                        await Task.Delay(3500);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"DESAFIADO - {this._desafiado.nome} : V: {this._desafiado.vitorias}, D: {this._desafiado.derrotas}, E: {this._desafiado.empates}");
                        Console.ResetColor();
                        break;

                    case 2: // Desafiado ganha (Corner Azul)
                        this._desafiado.Ganhar();
                        this._desafiante.Perder();

                        Console.WriteLine("Os novos cartéis atualizados:");
                        await Task.Delay(3500);

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($" VENCEDOR (AZUL) - {this._desafiado.nome} : V: {this._desafiado.vitorias}, D: {this._desafiado.derrotas}, E: {this._desafiado.empates}");
                        Console.ResetColor();

                        await Task.Delay(3500);

                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"PERDEDOR - {this._desafiante.nome} : V: {this._desafiante.vitorias}, D: {this._desafiante.derrotas}, E: {this._desafiante.empates}");
                        Console.ResetColor();
                        break;

                    case 3: // Desafiante ganha (Corner Vermelho)
                        this._desafiante.Ganhar();
                        this._desafiado.Perder();

                        Console.WriteLine("Os novos cartéis atualizados:");
                        await Task.Delay(3500);

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"VENCEDOR (VERMELHO) - {this._desafiante.nome} : V: {this._desafiante.vitorias}, D: {this._desafiante.derrotas}, E: {this._desafiante.empates}");
                        Console.ResetColor();

                        await Task.Delay(3500);

                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"PERDEDOR - {this._desafiado.nome} : V: {this._desafiado.vitorias}, D: {this._desafiado.derrotas}, E: {this._desafiado.empates}");
                        Console.ResetColor();
                        break;
                }
            }
            else { Console.WriteLine("A luta não foi aprovada, ninguém sobe no octógono!"); }
        }



    }
    }

