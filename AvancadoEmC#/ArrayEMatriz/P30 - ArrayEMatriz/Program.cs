using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio 30: Ler um vetor A com 20 elementos. " +
            "Construir dois vetores B e C, sendo \r\nque nos vetor B e C serão armazenados o valores pares e ímpares de \r\nA, respectivamente.");

        Random rnd = new Random();

        int[] a = new int[20];
        int[] b = new int[a.Length];
        int[] c = new int[a.Length];
        int impar = 0;
        int par = 0;

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(1, 20);
        }

        for (int j = 0; j < a.Length; j++)
        {
            if (a[j] % 2 == 0)
            {
                b[par] = a[j];
                par++;
            }
            else
            {
                c[impar] = a[j];
                impar++;
            }
        }

        Console.WriteLine("----------------------------------------------------");


        for (int x = 0; x < a.Length; x++)
        {
            Console.WriteLine("Vetor A, posição: " + x + " valor: " + a[x]);

        }

        Console.WriteLine("----------------------------------------------------");

        for (int l = 0; l < a.Length; l++)
        {
            if (b[l] != 0)
            {
                Console.WriteLine("Vetor B, posição: " + l + " valor: " + b[l]);
            }
        }

        Console.WriteLine("----------------------------------------------------");


        for (int m = 0; m < a.Length; m++)
        {
            if (c[m] != 0)
            {
                Console.WriteLine("Vetor B, posição: " + m + " valor: " + c[m]);
            }
        }

        Console.WriteLine("----------------------------------------------------");


        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}