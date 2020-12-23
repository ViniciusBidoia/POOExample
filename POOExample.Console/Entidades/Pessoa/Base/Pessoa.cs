using System;
using System.Collections.Generic;
using System.Text;

namespace POOExample.ConsoleApp.Entidades.Pessoa.Base
{
    public abstract class Pessoa
    {
        public int Cpf { get; private set; }
        public string Nome { get; private set; }
        public DateTime DtNascimento { get; private set; }
        public int Tamanho { get; private set; }
        public string CorCabelo { get; private set; }
        public string CorOlho { get; private set; }

        protected Pessoa(int cpf, string nome, DateTime dtNascimento, int tamanho, string corCabelo, string corOlho)
        {
            Cpf = cpf;
            Nome = nome;
            DtNascimento = dtNascimento;
            Tamanho = tamanho;
            CorCabelo = corCabelo;
            CorOlho = corOlho;
        }

        public void Falar()
        {
            Console.WriteLine($"Pessoa... {Nome} está falando sua data de nascimento {DtNascimento.ToLongDateString()}");
        }

        public void Andar()
        {
            Console.WriteLine($"Pessoa... {Nome} está andando");
        }

        public void Correr()
        {
            Console.WriteLine($"Pessoa... {Nome} está correndo");
        }

        public void Sentar()
        {
            Console.WriteLine($"Pessoa... {Nome} está sentando");
        }
    }
}
