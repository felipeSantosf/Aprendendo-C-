using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ler dois vetores A e B com 10 elementos cada. " +
            "Construir um vetor C, \r\nsendo este a junção dos dois outros vetores. " +
            "Os primeiros 10 \r\nelementos de C deverão receber os elementos de A e os últimos \r\nelementos C deverão receber os elementos de B. " +
            "Desta forma, C \r\ndeverá ter o dobro de elementos de A e B, ou seja, 20 elementos.");

        Random rnd = new Random();
        int[] a = new int[10];
        int[] b = new int[10];
        int[] c = new int[a.Length + b.Length];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(0, 10);
            b[i] = rnd.Next(0, 10);
        }

        for (int i = 0; i < c.Length; i++)
        {
            if (i < a.Length)
            {
                c[i] = a[i];
                Console.WriteLine("Posição: " + i + " valor vetorA: " + a[i] + " valor vetorC: " + c[i]);
            }
            else
            {
                c[i] = b[i - a.Length];
                Console.WriteLine("Posição: " + i + " valor vetorB: " + b[i - a.Length] + " valor vetorC: " + c[i]);
            }
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();

        
    }
}