using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 16: Criar um vetor A com 11 elementos, indexados de 0 até 10. \n" +
            "Sendo que cada elemento do vetor A é formado pela potência de base 2 elevado ao expoente igual a posição do respectivo elemento, ou seja: \n" +
            "A[i] = 2i. Sugestão int A[11]; \n");

        Random random = new Random();
        int[] a = new int[11];

        Console.WriteLine("-------------------------------------------------------");

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(1, 45);
            Console.WriteLine(a[i]);
        }

        Console.WriteLine("-------------------------------------------------------");

        for (int j = 0; j < a.Length; j++)
        {
            Console.WriteLine("a[" + j + "] : ^ " + j + " ==== " + a[j] + " ^ " + j + " = " + Math.Pow(a[j], j));
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();


    }
}