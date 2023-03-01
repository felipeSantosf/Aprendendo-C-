using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criar um vetor A com 10 elementos inteiros. " +
            "Implementar um programa \r\nque determine a soma dos elementos armazenados neste vetor que \r\nsão múltiplos de 5.");
        int[] a = {1,2,3,4,5,6,7,8,9,10};
        int somaMultiplosDeCinco = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 5 == 0)
            {
                somaMultiplosDeCinco += a[i];
            }
        }

        Console.WriteLine("Resultado da soma dos valores de multiplos de 5: " + somaMultiplosDeCinco);
        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}