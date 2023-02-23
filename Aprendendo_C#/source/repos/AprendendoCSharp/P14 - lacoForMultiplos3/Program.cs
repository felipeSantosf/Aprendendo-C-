using System;

class Program
{
    static void Main(string[] args)
    {
        for (int numero = 2; numero <= 100; numero++)
        {
            for(int numeroDivisor = 2; numeroDivisor <= numero; numeroDivisor++  )
            {
               
                if (numero / numeroDivisor == 1)
                {
                    Console.WriteLine("O número: " + numero + " é primo!");
                }
               
                
            }
            Console.WriteLine();
            
        }
    }
}