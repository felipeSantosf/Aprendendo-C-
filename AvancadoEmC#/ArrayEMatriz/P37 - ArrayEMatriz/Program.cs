using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Criar um vetor A com 15 elementos inteiros. " +
            "Construir um vetor B de \r\nmesmo tamanho, sendo que cada elemento do vetor B seja o fatorial \r\ndo elemento correspondente em A");

        int[] a = new int[15];
        int[] b = new int[a.Length];

        Random random = new Random();

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(1, 11);
        }

        for (int j = 0; j < b.Length; j++)
        {
            int temp = 1;
            for (int k = 1; k <= a[j]; k++)
            {
                temp *= k;
                b[j] = temp;
            }
            Console.WriteLine("------------");
        }

        for (int l = 0; l < b.Length; l++)
        {
            Console.WriteLine("Vetor a[" + l + "]" + " valor: " + a[l] + "! fatorial: " + b[l]);
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}