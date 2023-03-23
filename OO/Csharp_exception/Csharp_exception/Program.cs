using Csharp_exception;
using Csharp_exception.Contas;


LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
try
{  
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    
} 
catch (IOException err)
{
    Console.WriteLine("Leitura de arquivo interrompida");
    Console.WriteLine(err.StackTrace);
}  
finally 
{
    leitor.Fechar();
}

//try
//{
//    ContaCorrente conta1 = new ContaCorrente(0, "43743-X");
//    conta1.Sacar(50);
//    Console.WriteLine(conta1.GetSaldo());
//    conta1.Sacar(22);
//    Console.WriteLine(conta1.GetSaldo());

//}
//catch (ArgumentException err)
//{
//    Console.WriteLine("Parâmetro com erro: " +
//        err.ParamName);
//    Console.WriteLine("Não é possível criar uma conta com o número de agencia menor ou igual a 0");
//    Console.WriteLine(err.Message);
//    Console.WriteLine(err.StackTrace);
//}
//catch (SaldoInsuficienteException err)
//{
//    Console.WriteLine("Operação negada, saldo insuficiente!");
//    Console.WriteLine(err.Message);
//}
