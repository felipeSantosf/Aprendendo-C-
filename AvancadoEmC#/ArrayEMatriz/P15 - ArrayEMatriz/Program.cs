using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 15: Criar um vetor A com 10 elementos inteiros. " +
            "Escrever um programa \r\nque calcule e escreva: " +
            "a) a soma de elementos armazenados neste \r\nvetor que são inferiores a 15; " +
            "b) a quantidade de elementos \r\narmazenados no vetor que são iguais a 15; " +
            "e c) a média dos \r\nelementos armazenados no vetor que são superiores a 15.\n\n\n\n\n");

        int[] a = new int[10];
        int somaElemInf15 = 0;
        int qtdeElemIgual15 = 0;
        int somaElemSup15 = 0;
        int qtdeElmSup15 = 0;
        int mediaElemSup15 = 0;
        

        Random rnd = new Random();


        //Popular o array
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(1, 100);
            Console.WriteLine("A["+ i+ "] =  " + a[i]);
        }

        Console.WriteLine("\n\n");

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < 15)
            {
                somaElemInf15 += a[i];
            }
            else if (a[i] == 15)
            {
                qtdeElemIgual15++;
            }
            else
            {
                somaElemSup15 += a[i];
                qtdeElmSup15++;
            }
        }

        mediaElemSup15 = somaElemSup15 / qtdeElmSup15;

        Console.WriteLine("1 - Soma de elementos armazenados no vetor A que são inferiores a 15: " + somaElemInf15);
        Console.WriteLine("2 - Quantidade de elementos armazenados no vetor que são iguais a 15: " + qtdeElemIgual15);
        Console.WriteLine("3 - Média dos elementos armazenados no vetor que são superiores a 15: " + mediaElemSup15);
        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}