using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.Models
{
    public class Moeda
    {
        //Encapsulamento "tradicional"
        /*
        private string lado;
        public string Lado { get => lado; set => lado = value; }
        */

        //Criando uma propriedade (prop)
        //Troque o nome da propriedade SEMPRE começando com maiúscula
        public string Lado { get; set; }

        public void Sortear()
        {
            Lado = new Random().Next().ToString();
            if(Lado == "0")
            {
                Lado = "cara";
            }
            else
            {
                Lado = "coroa";
            }
        }
    }
}
