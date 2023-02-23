using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 5: Criar um vetor A com 10 elementos inteiros. " +
            "Construir um vetor B de \r\nmesmo tipo e tamanho, sendo que cada elemento do vetor B deverá \r\nser o respectivo elemento de A multiplicado por sua posição (ou \r\níndice)," +
            " ou seja:\r\nB[i] = A[i] * i.");
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] b = new int[a.Length];

        for (int i = 0; i < b.Length; i++)
        {
            b[i] = a[i] * i;
            Console.WriteLine(b[i]);
        }

        Console.WriteLine("Programa finalizado, tecle enter para fechar");
        Console.ReadLine();
    }
}