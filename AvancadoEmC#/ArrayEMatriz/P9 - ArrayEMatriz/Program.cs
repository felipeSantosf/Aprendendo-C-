using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Exercicio 9: Criar dois vetores A e B cada um com 10 elementos inteiros. " +
            "Construir \r\num vetor C, onde cada elemento de C é a divisão dos respectivos \r\nelementos em A e B, ou seja:\r\nC[i] = A[i] / float(B[i]).\r\n");

        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] b = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] c = new int[b.Length];

        for (int i = 0; i < c.Length; i++)
        {
            c[i] = a[i] / b[i];
            Console.WriteLine(a[i] + " / " + b[i] + " = " + c[i] + " resto da divisão: " + a[i] % b[i]);
            Console.WriteLine("Vetor C posição: " + i + " valor: " + c[i]);
        }
        Console.WriteLine("Programa finalizado, tecle enter para continuar...");
        Console.Read();
     }
}