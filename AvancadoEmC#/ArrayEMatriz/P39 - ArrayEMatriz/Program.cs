using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criar dois vetores A e B cada um com 10 elementos inteiros. " +
            "\nDesenvolver um programa que realize a interseção dos vetores A e B para produzir um vetor C. \n" +
            "Interseção de conjuntos = todos os elementos que existem em A e também existem em B.");

        Random rnd = new Random();
        int[] a = new int[10];
        int[] b = new int[a.Length];
        int[] c = new int[b.Length];

        for (int i = 0; i < a.Length; i++)
        {

            a[i] = rnd.Next(0, 10);
            b[i] = rnd.Next(0, 10);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Conjunto A, posição: " + i + " valor: " + a[i]);
            Console.WriteLine("Conjunto B, posição: " + i + " valor: " + b[i]);
        }

        Console.WriteLine("-----------------------------------------");

        for (int j = 0; j < c.Length; j++)
        {
            for (int k = 0; k < c.Length; k++)
            {
                if (a[j] == b[k])
                {

                    c[j] = b[k];

                }
            }
        }

        for (int l = 0; l < c.Length; l++)
        {
            if (c[l] != 0)
            {
                Console.WriteLine("Conjunto C, valor: " + c[l]);
            }
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}