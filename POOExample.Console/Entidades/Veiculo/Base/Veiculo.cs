using System;
using System.Collections.Generic;
using System.Text;

namespace POOExample.ConsoleApp.Entidades.Veiculo.Base
{
    //Classe abstrada, apenas para usar como base para hernaça, nunca implementação
    public abstract class Veiculo
    {
        public string NmFabricante { get; private set; }
        public string NmModelo { get; private set; }
        public bool FlOn { get; private set; }

        //Apenas será constuido a entidade do veiculo na classe veiculo. Não é possivel alterar em outro lugar.
        protected Veiculo(string nmFabricante, string nmModelo)
        {
            NmFabricante = nmFabricante;
            NmModelo = nmModelo;
        }        

        public void Ligar()
        {
            if (!FlOn)
            {
                Console.WriteLine($"Ligando... {NmModelo}");
                FlOn = true;
            }
        }

        public void Desligar()
        {
            if (FlOn)
            {
                Console.WriteLine($"Desligando... {NmModelo}");
                FlOn = false;
            }
        }

        public void Mover()
        {
            if (FlOn)
                Console.WriteLine($"Movendo... {NmModelo}");
        }

        public void Parar()
        {
            if (FlOn)
                Console.WriteLine($"Parando... {NmModelo}");
        }
    }
}
