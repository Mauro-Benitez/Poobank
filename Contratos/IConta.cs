using PooBank.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBank.Contratos
{
   public interface IConta
    {
        //metodos em forma de "contratos" , ao herdar a interface 'IConta', esses métodos precisam ser assinados
        double ConsultaSaldo();

        void Depositar(double valor);

        bool Sacar(double valor);

        string GetCodigoDoBanco();

        string GetNumeroDaAgencia();

        string GetNumeroDaConta();

        List<Extrato> Extrato();



    }
}
