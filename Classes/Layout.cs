using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PooBank.Classes
{
    public class Layout
    {



        public static List<Pessoa> pessoas = new List<Pessoa>();

        static int op = 0;
       

        public static void poobank()
        {
            int linha = 0;
            int coluna = 0;

            Console.WriteLine(@"        .______     ______     ______      .______        ___      .__   __.  __  ___");
            Console.WriteLine(@"        |   _  \   /  __  \   /  __  \     |   _  \      /   \     |  \ |  | |  |/  / ");
            Console.WriteLine(@"        |  |_)  | |  |  |  | |  |  |  |    |  |_)  |    /  ^  \    |   \|  | |  '  /  ");
            Console.WriteLine(@"        |   ___/  |  |  |  | |  |  |  |    |   _  <    /  /_\  \   |  . `  | |    <   ");
            Console.WriteLine(@"        |  |      |  `--'  | |  `--'  |    |  |_)  |  /  _____  \  |  |\   | |  .  \  ");
            Console.WriteLine(@"        | _|       \______/   \______/     |______/  /__/     \__\ |__| \__| |__|\__\");

        }


        public static void Telaprincipal()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();


            poobank();

            Console.SetCursorPosition(0, 8);

            Console.WriteLine("                                                                           ");
            Console.WriteLine("                                  DIGITE A OPÇÃO DESEJADA:                 ");
            Console.WriteLine("                                 ==========================                ");
            Console.WriteLine("                                 1- Criar Conta                            ");
            Console.WriteLine("                                 ==========================                ");
            Console.WriteLine("                                 2- Entrar com CPF e Senha                 ");
            Console.WriteLine("                                 ==========================                ");



            //Console.WriteLine("Cursor position: ({0}, {1})", Console.CursorLeft, Console.CursorTop);



            Console.SetCursorPosition(58, 9); op = int.Parse(Console.ReadLine());


            switch (op)
            {
                case 1:
                    TelaCriarConta();
                    break;

                case 2:
                    TelaLogin();
                    break;

                default:
                    Console.SetCursorPosition(38, 17); Console.WriteLine("OPÇÃO INVÁLIDA :(");
                    Console.SetCursorPosition(33, 18); Console.WriteLine("==========================");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Telaprincipal();

                    break;
            }



        }

        private static void TelaCriarConta()
        {

            Console.Clear();
            poobank();

            Console.SetCursorPosition(0, 8);
            Console.WriteLine("                                      CRIE UMA CONTA!                      ");
            Console.WriteLine("                                 ==========================                ");
            Console.WriteLine("                                 DIGITE O NOME:                            ");
            Console.WriteLine("                                 ==========================                ");
            Console.WriteLine("                                 DIGITE O CPF:                             ");
            Console.WriteLine("                                 ==========================                ");
            Console.WriteLine("                                 DIGITE A SENHA:                           ");
            Console.WriteLine("                                 ==========================                ");

            Console.SetCursorPosition(47, 10); string Nome = Console.ReadLine();
            Console.SetCursorPosition(46, 12); string Cpf = Console.ReadLine();
            Console.SetCursorPosition(48, 14); string Senha = Console.ReadLine();

            ContaCorrente contacorrente = new ContaCorrente();

            Pessoa pessoa = new Pessoa();



            pessoa.SetNome(Nome);
            pessoa.SetCpf(Cpf);
            pessoa.SetSenha(Senha);
            pessoa.Conta = contacorrente;

            pessoas.Add(pessoa);

            Console.Clear();
            poobank();

            Console.SetCursorPosition(0, 8);
            Console.WriteLine("                                CONTA CADASTRADA COM SUCESSO!                           ");
            Console.WriteLine("                               ===============================                          ");
            Thread.Sleep(1000);
            TelaContaLogada(pessoa);

        }


        private static void TelaLogin()
        {
           
            Console.Clear();
            poobank();
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("                                     ACESSE SUA CONTA!                     ");
            Console.WriteLine("                                 ==========================                ");
            Console.WriteLine("                                 DIGITE O CPF:                             ");
            Console.WriteLine("                                 ==========================                ");
            Console.WriteLine("                                 DIGITE A SENHA:                           ");
            Console.WriteLine("                                 ==========================                ");

            Console.SetCursorPosition(46, 10); string Cpf = Console.ReadLine();
            Console.SetCursorPosition(48, 12); string Senha = Console.ReadLine();



            Pessoa pessoa = pessoas.FirstOrDefault(x => x.Cpf == Cpf && x.Senha == Senha);

            if (pessoa != null)
            {
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("                                 LOGIN EFETUADO :)                     ");
                Console.WriteLine("                               ====================                    ");
                Console.Clear();
                TelaContaLogada(pessoa);

            }

            else
            {

                
                Console.SetCursorPosition(3, 15);Console.WriteLine("                               CPF OU SENHA INCORRETA :(               ");
                Console.SetCursorPosition(3, 16); Console.WriteLine("                              ==========================              ");
                Thread.Sleep(1000);
                Telaprincipal();

            }


        }


        private static void TelaBoasVindas(Pessoa pessoa)
        {
            string Info =
                $"{pessoa.Nome} | Banco:{pessoa.Conta.GetCodigoDoBanco()}  |  Conta:{pessoa.Conta.GetNumeroDaConta()}  |  Agencia:{pessoa.Conta.GetNumeroDaAgencia()}";


            Console.WriteLine();
            Console.WriteLine($"SEJA BEM-VINDO, {Info}");

        }



        private static void TelaContaLogada(Pessoa pessoa)
        {

            Console.Clear();
            TelaBoasVindas(pessoa);


           
            Console.WriteLine();
            Console.SetCursorPosition(25, 4); Console.WriteLine("ESCOLHA UM OPÇÃO:");
            Console.SetCursorPosition(22, 5); Console.WriteLine("========================");
            Console.SetCursorPosition(7, 8); Console.WriteLine("[1] Realizar um Depósito");
            Console.SetCursorPosition(7, 9); Console.WriteLine("=========================");
            Console.SetCursorPosition(40, 8); Console.WriteLine("[2]Realizar um Saque");
            Console.SetCursorPosition(38, 9); Console.WriteLine("========================");
            Console.SetCursorPosition(9, 11); Console.WriteLine("[3]Consultar Saldo");
            Console.SetCursorPosition(7, 12); Console.WriteLine("=========================");
            Console.SetCursorPosition(44, 11); Console.WriteLine("[4]Extrato");
            Console.SetCursorPosition(38, 12); Console.WriteLine("========================");
            Console.SetCursorPosition(30, 14); Console.WriteLine("[5]Sair");
            Console.SetCursorPosition(22, 15); Console.WriteLine("========================");


            Console.SetCursorPosition(42, 4); op = int.Parse(Console.ReadLine());


            switch (op)
            {
                case 1:
                    Teladeposito(pessoa);
                    break;


                case 2:
                    TelaSaque(pessoa);
                    break;

                case 3:
                    TelaConsultaSaldo(pessoa);
                    break;

                case 4:
                    TelaExtrato(pessoa);
                    break;

                case 5:
                    Console.Clear();
                    Telaprincipal();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("                       Opção Inválida :(                     ");
                    Console.WriteLine("                   ========================                 ");


                    break;


            }
        }


        private static void Teladeposito(Pessoa pessoa)
        {

            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.SetCursorPosition(25, 4); Console.WriteLine("DIGITE O VALOR A SER DEPÓSITADO");
            Console.SetCursorPosition(25, 5); Console.WriteLine("=================================");
            Console.SetCursorPosition(25, 6); Console.WriteLine("R$ ");
            Console.SetCursorPosition(25, 7); Console.WriteLine("=================================");


            Console.SetCursorPosition(28, 6); double valor = double.Parse(Console.ReadLine());
            pessoa.Conta.Depositar(valor);

            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.SetCursorPosition(35, 4); Console.WriteLine("DEPOSITANDO...");
            Console.SetCursorPosition(25, 5); Console.WriteLine("=================================");
            Thread.Sleep(1000);

            Console.Clear();
            TelaBoasVindas(pessoa);

            Console.SetCursorPosition(25, 4); Console.WriteLine("DEPÓSITO REALIZADO COM SUCESSO :)");
            Console.SetCursorPosition(25, 5); Console.WriteLine("=================================");
            Thread.Sleep(1000);


            Console.Clear();
            TelaContaLogada(pessoa);
        }


        private static void TelaSaque(Pessoa pessoa)
        {

            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.SetCursorPosition(26, 4); Console.WriteLine("DIGITE O VALOR A SER SACADO");
            Console.SetCursorPosition(25, 5); Console.WriteLine("=================================");
            Console.SetCursorPosition(25, 6); Console.WriteLine("R$ ");
            Console.SetCursorPosition(25, 7); Console.WriteLine("=================================");


            Console.SetCursorPosition(28, 6); double valor = double.Parse(Console.ReadLine());
            bool oksaque = pessoa.Conta.Sacar(valor);

            if (oksaque)
            {
                Console.Clear();
                TelaBoasVindas(pessoa);
                Console.SetCursorPosition(35, 4); Console.WriteLine("SACANDO...");
                Console.SetCursorPosition(25, 5); Console.WriteLine("=================================");
                Thread.Sleep(1000);
               
                Console.Clear();
                TelaBoasVindas(pessoa);
                Console.SetCursorPosition(25, 4); Console.WriteLine("SAQUE REALIZADO COM SUCESSO :)");
                Console.SetCursorPosition(25, 5); Console.WriteLine("=================================");
                Thread.Sleep(1000);
                Console.Clear();
                TelaContaLogada(pessoa);
                //TelaBoasVindas(pessoa);
                //VoltarTelaLogada(pessoa);

            }

            else
            {
                Console.Clear();
                TelaBoasVindas(pessoa);
                Console.SetCursorPosition(29, 4); Console.WriteLine("SALDO INSUFICIENTE :(");
                Console.SetCursorPosition(25, 5); Console.WriteLine("=================================");
                Thread.Sleep(1000);
                Console.Clear();
                TelaBoasVindas(pessoa);
                VoltarTelaLogada(pessoa);
            }






            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("                                                                     ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("              DEPOSITO REALIZADO COM SUCESSO :)                     ");
            Console.WriteLine("              =================================                       ");
            Thread.Sleep(1000);


            Console.Clear();
            TelaBoasVindas(pessoa);
            VoltarTelaLogada(pessoa);



        }






        private static void VoltarTelaLogada(Pessoa pessoa)
        {
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                           ESCOLHA UM OPÇÃO                             ");
            Console.WriteLine("                       ========================                         ");
            Console.WriteLine("                       [1] Voltar a minha conta                         ");
            Console.WriteLine("                       ========================                         ");
            Console.WriteLine("                              [2]Sair                                  ");
            Console.WriteLine("                       ========================                         ");

            Console.SetCursorPosition(44,8); op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Retornando...");
                Thread.Sleep(1000);
                Console.Clear();
                TelaContaLogada(pessoa);

            }
            else if (op == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Saindo...");
                Thread.Sleep(1000);
                Console.Clear();
                Telaprincipal();
            }

            else
            {
                Console.WriteLine("Opção inválido :( ");
                Thread.Sleep(1000);
                Console.Clear();
                TelaBoasVindas(pessoa);
                VoltarTelaLogada(pessoa);
            }
        }




        private static void TelaConsultaSaldo(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("                                                                     ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine($"                        SEU SALDO É DE R${pessoa.Conta.ConsultaSaldo()}        ");
            Console.WriteLine("                ============================================         ");

            Console.WriteLine("                                                                    ");
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                           ESCOLHA UM OPÇÃO                             ");
            Console.WriteLine("                       ========================                         ");
            Console.WriteLine("                       [1] Voltar a minha conta                         ");
            Console.WriteLine("                       ========================                         ");
            Console.WriteLine("                              [2]Sair                                  ");
            Console.WriteLine("                       ========================                         ");

            Console.SetCursorPosition(44, 8); op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine();
                Console.SetCursorPosition(27, 15); Console.WriteLine("Retornando...");
                Thread.Sleep(1000);
                Console.Clear();
                TelaContaLogada(pessoa);

            }
            else if (op == 2)
            {
                Console.WriteLine();
                Console.SetCursorPosition(27, 15); Console.WriteLine("Saindo...");
                Thread.Sleep(1000);
                Console.Clear();
                Telaprincipal();
            }

            else
            {
                Console.SetCursorPosition(27, 15); Console.WriteLine("Opção inválido :( ");
                Thread.Sleep(1000);
                Console.Clear();
                TelaConsultaSaldo(pessoa);
            }



        }

        private static void TelaExtrato(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);


            if (pessoa.Conta.Extrato().Any())
            {

                double valor = pessoa.Conta.Extrato().Sum(x => x.Valor);


                foreach (Extrato extrato in pessoa.Conta.Extrato())
                {


                    Console.WriteLine("                                                                            ");
                    Console.WriteLine($"                      Tipo de movimentação: {extrato.Descricao}             ");
                    Console.WriteLine("                ============================================                ");
                    Console.WriteLine($"                      Data: {extrato.Data.ToString("dd/MM/yyy")} Hora: {extrato.Data.ToString("HH:mm:ss")}       ");
                    Console.WriteLine("                ============================================                ");
                    Console.WriteLine($"                              Valor: R${extrato.Valor}                             ");
                    Console.WriteLine("                ============================================                ");
                    Console.WriteLine("                                                                            ");





                }





                Console.WriteLine("                                                                       ");
                Console.WriteLine($"                             Sub Total: R${valor}                      ");
                Console.WriteLine("                ============================================           ");


            }


            else
            {
                Console.WriteLine("                                                                       ");
                Console.WriteLine("                         Não há extrato a ser exibido :(                    ");
                Console.WriteLine("                   ============================================         ");
            }



            //Console.WriteLine($"                      SEU SALDO É DE {pessoa.Conta.ConsultaSaldo()}        ");
            //

            Console.WriteLine("                                                                    ");
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                           ESCOLHA UM OPÇÃO                             ");
            Console.WriteLine("                       ========================                         ");
            Console.WriteLine("                       [1] Voltar a minha conta                         ");
            Console.WriteLine("                       ========================                         ");
            Console.WriteLine("                              [2]Sair                                  ");
            Console.WriteLine("                       ========================                         ");

            Console.SetCursorPosition(44, 15);  op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine();
                Console.SetCursorPosition(27, 25); Console.WriteLine("Retornando...");
                Thread.Sleep(1000);
                Console.Clear();
                TelaContaLogada(pessoa);

            }
            else if (op == 2)
            {
                Console.WriteLine();  
                Console.SetCursorPosition(27, 25); Console.WriteLine("Saindo...");
                Thread.Sleep(1000);
                Console.Clear();
                Telaprincipal();
            }

            else
            {
                Console.SetCursorPosition(27, 25); Console.WriteLine("Opção inválido :( ");
                Thread.Sleep(1000);
                Console.Clear();
                TelaExtrato(pessoa);
            }



        }











    }
}
