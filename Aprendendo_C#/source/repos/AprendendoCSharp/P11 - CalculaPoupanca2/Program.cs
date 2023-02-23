using System;

class Program
{
    static void Main(string[] args)
    {
        double investimento = 1000;
        int mes = 6;

        for(int i = 1; i<= mes; i++)
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " + i + " você tem R$ " + investimento);
            
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}