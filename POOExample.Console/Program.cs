using POOExample.ConsoleApp.Entidades.Pessoa;
using POOExample.ConsoleApp.Entidades.Pessoa.Base;
using POOExample.ConsoleApp.Entidades.Veiculo;
using POOExample.ConsoleApp.Entidades.Veiculo.Base;
using System;

namespace POOExample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escolha qual a opção deseja testar:");
                Console.WriteLine("1. Veiculo.");
                Console.WriteLine("2. Pessoa.");

                var option = Console.ReadLine();

                switch (Convert.ToInt32(option))
                {
                    case 1:
                        UsarVeiculo();
                        break;

                    case 2:
                        UsarPessoa();
                        break;

                    default:
                        Console.WriteLine("Opções nao conferem.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        #region Pessoa
        public static void UsarPessoa()
        {
            Homem homem = new Homem(457, "Vinicus Bidoia", new DateTime(1998, 04, 24), 183, "Loiro", "Verde");
            Mulher mulher = new Mulher(111, "Mariana Salvador", new DateTime(1989, 07, 26), 162, "Morena", "Castanho");

            Comer(homem, mulher);
        }

        static void Comer(params Pessoa[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                pessoa.Andar();
                pessoa.Falar();
                pessoa.Sentar();

                Console.WriteLine($"{pessoa.Nome} está comendo!");
            }
        }

        #endregion

        #region Veiculo

        /// <summary>
        /// Metodo para testar o Veiculo
        /// </summary>
        public static void UsarVeiculo()
        {
            var moto = new Moto("Haojue", "DK 150");
            var carro = new Carro("GM - Chevrolet", "Vectra");

            Estacionar(moto, carro);
        }

        /// <summary>
        /// Método polimórfico
        /// </summary>
        /// <param name="veiculos"></param>
        private static void Estacionar(params Veiculo[] veiculos)
        {
            foreach (var veiculo in veiculos)
            {
                if (!veiculo.FlOn)
                    veiculo.Ligar();

                veiculo.Mover();
                veiculo.Mover();
                veiculo.Parar();
                veiculo.Desligar();
                Console.WriteLine($"{veiculo.NmModelo} estacionado!");
            }
        }

        #endregion
    }
}
