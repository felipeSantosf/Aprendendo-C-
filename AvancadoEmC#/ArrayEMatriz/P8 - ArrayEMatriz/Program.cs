using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 8: Criar dois vetores A e B cada um com 10 elementos inteiros. Construir \r\num vetor C, " +
            "onde cada elemento de C é a multiplicação dos \r\nrespectivos elementos em A e B, ou seja:\r\nC[i] = A[i] * B[i]");

        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] b = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] c = new int[b.Length];

        for (int i = 0; i < c.Length; i++)
        {
            c[i] = a[i] * b[i];
            Console.WriteLine("Vetor C posição: " + i + " valor: " + c[i]);
        }

        Console.WriteLine("Programa finalizado, tecle enter para continuar...");
        Console.ReadLine();
    }
}