using System;
using System.Collections.Generic;
    internal class Program
    {
        public enum Tipo
        {
            GOLEIRO,
            LATERAL,
            ZAGUEIRO,
            VOLANTE,
            MEIA,
            ATACANTE
        };
        public class Time
        {
            public string Nome { get; set; }
            public List<Jogador> Jogadores { get; set; }

            /*public Time(string nome, List<Jogador> jogadores)
            {
                this.Nome = nome;
                this.Jogadores = jogadores;
            }*/
        }

        public class Jogador
        {
            public string Nome { get; set; }
            public Tipo Tipo { get; set; }

            /*public Jogador(string nome, Tipo tipo)
            {
                this.Nome = nome;
                this.Tipo = tipo;
            }*/
        }
        static void Main(string[] args)
        {

            List<Time> times = new List<Time>()
                {
                    new Time(){ Nome = "Gremio", Jogadores = new List<Jogador>(){
                        new Jogador(){Nome = "Gabriel Granco", Tipo = Tipo.GOLEIRO },
                        new Jogador(){Nome = "Rafinha", Tipo = Tipo.LATERAL},
                        new Jogador(){Nome = "Bruno Cortez", Tipo = Tipo.LATERAL},
                        new Jogador(){Nome = "Pedro Geromel", Tipo = Tipo.ZAGUEIRO},
                        new Jogador(){Nome = "Ruan", Tipo = Tipo.ZAGUEIRO},
                        new Jogador(){Nome = "Tiago Santos", Tipo = Tipo.VOLANTE},
                        new Jogador(){Nome = "Lucas Silva", Tipo = Tipo.VOLANTE},
                        new Jogador(){Nome = "Ferreira", Tipo = Tipo.MEIA},
                        new Jogador(){Nome = "Jaminton Campaz", Tipo = Tipo.MEIA},
                        new Jogador(){Nome = "Jhonata Robert", Tipo = Tipo.MEIA},
                        new Jogador(){Nome = "Diego Souza", Tipo = Tipo.ATACANTE}
                    }},

                    new Time(){ Nome = "Flamengo", Jogadores = new List<Jogador>(){
                        new Jogador(){Nome = "Hugo Souza", Tipo = Tipo.GOLEIRO },
                        new Jogador(){Nome = "Rodinel", Tipo = Tipo.LATERAL},
                        new Jogador(){Nome = "Renê", Tipo = Tipo.LATERAL},
                        new Jogador(){Nome = "Gustavo Henrique", Tipo = Tipo.ZAGUEIRO},
                        new Jogador(){Nome = "Léo Pereira", Tipo = Tipo.ZAGUEIRO},
                        new Jogador(){Nome = "Thiago Maia", Tipo = Tipo.VOLANTE},
                        new Jogador(){Nome = "João Gomes", Tipo = Tipo.VOLANTE},
                        new Jogador(){Nome = "Kenedy", Tipo = Tipo.MEIA},
                        new Jogador(){Nome = "Diego", Tipo = Tipo.MEIA},
                        new Jogador(){Nome = "Vitinho", Tipo = Tipo.MEIA},
                        new Jogador(){Nome = "Vitor Gabriel", Tipo = Tipo.ATACANTE}
                    }},
                };

        //LINQ sem lambda
        var result = from time in times 
                     from jogador in time.Jogadores
                     where jogador.Tipo == Tipo.MEIA 
                     select jogador;

        //LINQ com lambda
        var result2 = times.SelectMany(t => t.Jogadores).Where(j => j.Tipo == Tipo.MEIA);

        foreach (var r in result2)
        {
            Console.WriteLine(r.Nome);
        }
        
        }
    }

