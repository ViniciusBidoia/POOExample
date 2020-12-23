using System;
using System.Collections.Generic;
using System.Text;

namespace POOExample.ConsoleApp.Entidades.Pessoa
{
    public class Homem : Base.Pessoa
    {
        public Homem(int cpf, string nome, DateTime dtNascimento, int tamanho, string corCabelo, string corOlho) : base(cpf, nome, dtNascimento, tamanho, corCabelo, corOlho)
        {

        }
    }
}
