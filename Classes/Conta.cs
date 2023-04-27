using PooBank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBank.Classes
{

    //classe abstrata (Apenas as classes herdam )
    public abstract class Conta : Banco, IConta
    {
        //constutor
        public Conta()
        {
            this.NumeroDaAgencia = "001";
            this.movimentacoes = new List<Extrato>();

            Conta.NumeroDaContaSequencial++;
        
        }

        //atributos
        private List <Extrato> movimentacoes;   
        public double Saldo { get; protected set; }
        public string NumeroDaAgencia { get; private set; }

        public string NumeroDaConta { get; protected set; }

        public static int NumeroDaContaSequencial { get; private set; }
         


        //metodos
        public double ConsultaSaldo()
        {
            return this.Saldo;
        }
        public void Depositar(double valor)
        {
            DateTime DataAtual = DateTime.Now;
            this.movimentacoes.Add(new Extrato(DataAtual, "Depósito", valor));
            this.Saldo += valor;
            
        }


        public bool Sacar(double valor)
        {
            if (valor > this.ConsultaSaldo())
                return false;

            DateTime DataAtual = DateTime.Now;
            this.movimentacoes.Add(new Extrato(DataAtual, "Saque", -valor));
            this.Saldo -= valor;
            return true;

        }
        public string GetCodigoDoBanco()
        {
            return this.CodigoDoBanco;
        }

        public string GetNumeroDaAgencia()
        {
            return this.NumeroDaAgencia;
        }

        public string GetNumeroDaConta()
        {
            return this.NumeroDaConta;
        }

        public List<Extrato> Extrato()
        {
            return this.movimentacoes;
        }
    }
}
