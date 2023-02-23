using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for(int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                if (contadorLinhas <= contadorColunas)
                    break;
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    
}
