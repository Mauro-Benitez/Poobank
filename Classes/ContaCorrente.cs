using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBank.Classes
{
    public class ContaCorrente : Conta
    {
        

        //construtor
        public ContaCorrente ()
        {
            this.NumeroDaConta = "00" + Conta.NumeroDaContaSequencial;
        }

    }
}
