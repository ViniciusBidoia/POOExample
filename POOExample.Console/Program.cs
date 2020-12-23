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
                        
                        break;

                    case 2:
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
    }
}
