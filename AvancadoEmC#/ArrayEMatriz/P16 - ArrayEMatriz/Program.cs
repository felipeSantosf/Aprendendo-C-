using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 16: Criar um vetor A com 10 elementos inteiros. " +
            "Desenvolver um programa \r\nque defina o percentual de elementos pares e ímpares, \r\nrespectivamente, armazenados neste vetor");

        Random rnd = new Random();
        int[] a = new int[10];
        double impar = 0;
        double par = 0;
        double percentualImpar;
        double percentualPar;
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(1, 100);
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                par++;
            } else
            {
                impar++;
            }
        }

        percentualPar = ((par * 100) /  a.Length);
        percentualImpar = ((impar * 100) / a.Length);
        Console.WriteLine("Percentual de elementos impares no vetor: " + percentualImpar + "%");
        Console.WriteLine("Percentual de elementos pares no vetor: " + percentualPar + "%");
        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();

    }
}