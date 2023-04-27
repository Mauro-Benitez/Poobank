using PooBank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBank.Classes
{
    public class Pessoa
    {
        //atributos
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        
        public IConta Conta { get; set; } 


        //metodos
        public string SetNome(string nome)
        {
            return this.Nome = nome;
        }

        public string SetCpf(string valor)
        {
            return this.Cpf = valor;
        }

        public string SetSenha(string senha)
        {
            return this.Senha = senha;
        }

    }
}
