using ByteBank.Conta;
using ByteBank.Titular;

//ContaCorrente contaDoFelipe = new ContaCorrente();
//contaDoFelipe.titular = "Felipe Santos";
//contaDoFelipe.numero_agencia = 15;
//contaDoFelipe.conta = "4598-X";
//contaDoFelipe.saldo = 23.77;

//ContaCorrente contaDoFelipe2 = new ContaCorrente();
//contaDoFelipe.titular = "Felipe Santos";
//contaDoFelipe.numero_agencia = 15;
//contaDoFelipe.conta = "4598-X";
//contaDoFelipe.saldo = 23.77;

// TIPAGEM POR REFERÊNCIA
//contaDoFelipe = contaDoFelipe2;

//Console.WriteLine(contaDoFelipe == contaDoFelipe2);


//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Silveisa";
//contaDaMaria.numero_agencia = 58;
//contaDaMaria.conta = "6699-X"; 
//contaDaMaria.saldo = 80.66;

//Console.WriteLine("Saldo da conta do Felipe =  " + contaDoFelipe.saldo);

//contaDoFelipe.Depositar(155.63);

//Console.WriteLine("Saldo da conta do Felipe após depósito =  " + contaDoFelipe.saldo);
//Console.WriteLine("\n\n\n");

//contaDoFelipe.exibirInformacoesConta();

//if (contaDoFelipe.Sacar(50))
//{
//    Console.WriteLine("Saldo da conta do Felipe após saque =  " + contaDoFelipe.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para saque.");
//}


//if (contaDoFelipe.Transferir(60.98, contaDaMaria))
//{
//    Console.WriteLine("Tranferência realizada com sucesso, saldo após transferência = " + contaDoFelipe.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente, não foi possível realizar a solicitação");
//}

// TIPAGEM POR VALOR
//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor == valor2);
//Console.WriteLine(valor);
//Console.WriteLine(valor2);




//Cliente cliente = new Cliente("Felipe José", "1234568903", "Frentista");
//Console.WriteLine(cliente.nome);
//Console.WriteLine(cliente.CPF);
//Console.WriteLine(cliente.profissao);
//Console.WriteLine(Cliente.quantidadeClientes);
//Console.WriteLine("-------------");


//Cliente cliente2 = new Cliente("Felipe José", "1234568903", "Frentista");
//Console.WriteLine(cliente2.nome);
//Console.WriteLine(cliente2.CPF);
//Console.WriteLine(cliente2.profissao);
//Console.WriteLine(Cliente.quantidadeClientes);
//Console.WriteLine("-------------");

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.Numero_Conta = "1342-X";
//conta.numero_agencia = 1;
//conta.DefinirSaldo(100);

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.CPF);
//Console.WriteLine("Profissao = " + conta.titular.profissao);
//Console.WriteLine("N° Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.ObterSaldo());
//Console.WriteLine("N° agência = " + conta.numero_agencia);


//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "Maria Joaquina";
//conta2.titular.profissao = "Analista";
//conta2.titular.CPF = "8473269821";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 89;
//conta2.DefinirSaldo(900);

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta4 = new ContaCorrente(2,"456-X");
//conta4.DefinirSaldo(500);
//Console.WriteLine(ContaCorrente.quantidadeContasCriadas);



//ContaCorrente conta5 = new ContaCorrente(2, "456-X");
//conta4.DefinirSaldo(500);
//Console.WriteLine(ContaCorrente.quantidadeContasCriadas);

// propriedade/ método estático é vinculada a classe e não ao objeto