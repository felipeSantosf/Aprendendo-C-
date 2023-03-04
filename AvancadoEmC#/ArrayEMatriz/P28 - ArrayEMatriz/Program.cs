using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ler um vetor A com 10 elementos e construir um vetor B de mesmo \r\ntipo e tamanho e com os mesmos elementos de A, " +
            "sendo que estes \r\ndeverão estar invertidos, ou seja, o primeiro elemento de A passa a \r\nser o último de B, " +
            "o segundo elemento de A passa a ser o penúltimo \r\nde B e assim por diante");

        Random rnd = new Random();
        int[] a = new int[10];
        int[] b = new int[a.Length];

        for( int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(0, 10);
        }

        for (int i = 0; i < a.Length; i++)
        {
            b[i] = a[a.Length  - 1 - i];

            Console.WriteLine("Valor vetorA: " + a[i] + " valor vetorB " + b[i]);
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}