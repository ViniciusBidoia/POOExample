using System;
using System.Collections.Generic;
using System.Text;

namespace POOExample.ConsoleApp.Entidades.Veiculo
{
    public class Carro : Veiculo.Base.Veiculo
    {
        //Utilizando Herança 
        public Carro(string nmFabricante, string nmModelo) : base(nmFabricante, nmModelo)
        {
        }
    }
}
