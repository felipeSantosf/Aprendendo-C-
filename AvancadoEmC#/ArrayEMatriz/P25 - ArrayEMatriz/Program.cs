using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criar um vetor A com 10 elementos inteiros. " +
            "Construir um vetor B de \r\nmesmo tipo e tamanho, obedecendo as seguintes regras de formação: " +
            "\r\na) Bi deverá receber 1 quando Ai for par; b) Bi deverá receber 0 \r\nquando Ai for ímpar.");

        Random rnd = new Random();

        int[] a = new int[10];
        int[] b = new int[10];

        for(int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(1,10);

            if (a[i] % 2 == 0)
            {
                b[i] = 1;
            } else
            {
                b[i] = 0;
            }

            Console.WriteLine("Posição: " + i + " Vetor B valor: " + b[i] + ", vetor A valor: " + a[i]);
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();

    }
}