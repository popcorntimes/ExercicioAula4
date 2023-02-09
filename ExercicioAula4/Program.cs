using System;
using System.Collections.Generic;
namespace ExercicioAula4
{
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

            public Time(string nome, List<Jogador> jogadores)
            {
                this.Nome = nome;
                this.Jogadores = jogadores;
            }
        }

        public class Jogador
        {
            public string Nome { get; set; }
            public Tipo Tipo { get; set; }

            public Jogador(string nome, Tipo tipo)
            {
                this.Nome = nome;
                this.Tipo = tipo;
            }
        }
        static void Main(string[] args)
        {

            List<Time> times = new List<>()
            /* times.AddRange(new List<Time>
            {
                new Time("Gremio", new List<Jogador>()
                {
                    Add(new Jogador("Hugo Souza", Tipo.GOLEIRO))
                })

            });*/

        }
    }
}
