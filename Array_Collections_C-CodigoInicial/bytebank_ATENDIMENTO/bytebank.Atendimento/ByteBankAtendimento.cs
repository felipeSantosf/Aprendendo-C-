using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;

namespace bytebank_ATENDIMENTO.bytebank.Atendimento
{
    internal class ByteBankAtendimento
    {
        private List<ContaCorrente> _listaDecontas = new List<ContaCorrente>() {
    new ContaCorrente(123, "536721") { Saldo = 100, Titular = new Cliente { Cpf = "83974265", Nome = "Felipe Santos", Profissao = "Analista" } },
    new ContaCorrente(456, "325422") { Saldo = 20, Titular = new Cliente { Cpf = "789342321", Nome = "Pedro João", Profissao = "Contador" }},
    new ContaCorrente(789, "098324", "Felicio Meira", "3298747212", "Dev") { Saldo = 300},
    new ContaCorrente(012, "324765", "Maria Joana", "3424234354", "Analista Financeiro") { Saldo = 400}
            };
       public void AtendimentoCliente()
        {
            char opcao = '0';
            while (opcao != '6')
            {
                Console.Clear();
                Console.WriteLine("====================================================");
                Console.WriteLine("=========            Atendimento            ========");
                Console.WriteLine("=========1 - Cadastrar Conta                ========");
                Console.WriteLine("=========2 - Listar Contas                  ========");
                Console.WriteLine("=========3 - Remover Conta                  ========");
                Console.WriteLine("=========4 - Ordenar Contas                 ========");
                Console.WriteLine("=========5 - Pesquisar Conta                ========");
                Console.WriteLine("=========6 - Sair do sistema                ========");
                Console.WriteLine("====================================================");

                Console.WriteLine("\n\n");
                Console.WriteLine("Digite a opção desejada: ");

                try
                {
                    opcao = Console.ReadLine()[0];
                }
                catch (Exception excessao)
                {
                    throw new ByteBankException(excessao.Message);
                }

                try
                {
                    switch (opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarContas();
                            break;
                        case '3':
                            RemoverContas();
                            break;
                        case '4':
                            OrdenarContas();
                            break;
                        case '5':
                            PesquisarConta();
                            break;
                        case '6':
                            Sair();
                            break;
                        default:
                            Console.WriteLine("Opção não implementada.");
                            break;
                    }
                }
                catch (ByteBankException excessao)
                {

                }

            }

        }

       public void Sair()
        {
            Console.WriteLine("Aplicação finalizada...");
            Environment.Exit(0);
        }

       public void PesquisarConta()
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("============       PESQUISAR CONTAS       ==========");
            Console.WriteLine("====================================================");
            Console.WriteLine("\n");
            Console.WriteLine("Deseja pesquisas por (1) Número da conta ou (2) CPF do Titular? ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Informe o número da Conta: ");
                        string _numeroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                        if (consultaConta != null)
                        {
                            Console.WriteLine(consultaConta.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Conta não encontrada!");
                        }

                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Informe o CPF do titular: ");
                        string _cpf = Console.ReadLine();
                        ContaCorrente consultaCPF = ConsultaPorCPFTitular(_cpf);
                        if (consultaCPF != null)
                        {
                            Console.WriteLine(consultaCPF.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Conta não encontrada!");
                        }

                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("Opção não implementada.");
                    break;
            }


        }

       public ContaCorrente? ConsultaPorCPFTitular(string? cpf)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < _listaDecontas.Count; i++)
            //{
            //    if (_listaDecontas[i].Titular.Cpf.Equals(cpf))
            //    {
            //        conta = _listaDecontas[i];
            //    }
            //}

            //return conta;
            //return _listaDecontas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
            return (from conta in _listaDecontas
                    where conta.Titular.Cpf == cpf
                    select conta).FirstOrDefault();
        }

       public ContaCorrente? ConsultaPorNumeroConta(string? numeroConta)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < _listaDecontas.Count; i++)
            //{
            //    if (_listaDecontas[i].Conta.Equals(numeroConta))
            //    {
            //        conta = _listaDecontas[i];
            //    }
            //}
            //return conta;
            return _listaDecontas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
        }

       public void OrdenarContas()
        {
            _listaDecontas.Sort();
            Console.Write("... Lista de contas ordenadas ...");
            Console.ReadKey();
        }

       public void RemoverContas()
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("============         REMOVER CONTAS       ==========");
            Console.WriteLine("====================================================");
            Console.WriteLine("\n");
            Console.WriteLine("Informe o número da conta: ");
            string numeroDaConta = Console.ReadLine();
            ContaCorrente conta = null;

            foreach (var item in _listaDecontas)
            {
                if (item.Conta.Equals(numeroDaConta))
                {
                    conta = item;
                }
            }

            if (conta != null)
            {
                _listaDecontas.Remove(conta);
                Console.WriteLine("... Conta removida da lista ...");
            }
            else
            {
                Console.WriteLine("... Conta para remoção não encontrada ...");
            }

            Console.ReadKey();
            AtendimentoCliente();
        }

       public void ListarContas()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("========           Lista de contas          ========");
            Console.WriteLine("====================================================");
            Console.WriteLine("\n");
            if (_listaDecontas.Count <= 0)
            {
                Console.WriteLine("... Não há contas cadastradas! ...");
            }

            foreach (var item in _listaDecontas)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            AtendimentoCliente();

        }

       public void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("============      CADASTRO DE CONTAS      ==========");
            Console.WriteLine("====================================================");
            Console.WriteLine("\n");
            Console.WriteLine("============   Informe os dados da conta  ==========");

            Console.WriteLine("Numero agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            //Console.WriteLine("Numero da conta: ");
            //string numeroDaConta = Console.ReadLine();

            //ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroDaConta);
            ContaCorrente conta = new ContaCorrente(numeroAgencia);
            Console.WriteLine($"Número da conta: {conta.Conta}\n");

            Console.WriteLine("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.WriteLine("Informe a profissão do Titular : ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDecontas.Add(conta);
            Console.WriteLine("... Conta cadastrada com sucesso! ...");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            AtendimentoCliente();
        }
    }
}
