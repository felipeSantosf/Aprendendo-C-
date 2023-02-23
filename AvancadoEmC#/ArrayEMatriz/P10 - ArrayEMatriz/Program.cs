using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criar um vetor A com 10 elementos inteiros. Construir um vetor B de \r\nmesmo tipo e tamanho, " +
            "sendo que cada elemento do vetor B deverá \r\nser o resto da divisão do respectivo elemento de A por 2 (dois), ou \r\nseja: B[i] := A[i] % 2");

        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int[] b = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] c = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            c[i] = a[i] % 2;
            Console.WriteLine("Vetor C, resto da divisão de: " + a[i] + " por 2 = " + c[i]);
        }

        Console.WriteLine("Programa finalizado, tecle enter para contiunuar...");
        Console.ReadLine();
    }
}

