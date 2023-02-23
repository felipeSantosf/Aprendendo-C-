using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");
        
        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês
        int mes = 6;

        while (mes <= 12)
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " + mes + "você tem R$ " + investimento);
            mes++;
        }

        Console.WriteLine(investimento);


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}