using PooBank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBank.Classes
{
    //classe abstrata (Apenas as classes herdam )
    public abstract class Banco 
    {
        //construtor
        public Banco()
        {
            this.CodigoDoBanco = "666";
            this.NomeDoBanco = "POO BANK";

        }

        //atributos
        public string NomeDoBanco { get; private set;}

        public string CodigoDoBanco { get; private set; }

    }
}
//teste 
