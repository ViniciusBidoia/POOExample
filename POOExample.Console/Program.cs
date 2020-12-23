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
    }
}
