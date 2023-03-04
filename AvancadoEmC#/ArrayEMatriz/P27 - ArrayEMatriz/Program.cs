using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criar um vetor A com 10 elementos inteiros. " +
            "Construir um vetor B de mesmo tipo e tamanho, obedecendo as seguintes regras de formação: \n" +
            "a) Bi deverá receber 'a' quando Ai for menor que 7; \n" +
            "b) Bi deverá receber 'b' quando Ai for igual a 7; \n" +
            "c) Bi deverá receber 'c' quando Ai for maior que 7 e menor que 10; \n" +
            "d) Bi deverá receber 'd' quando Ai for igual a 10; \n" +
            "e e) Bi deverá receber 'e' quando Ai for maior que 10. Sugestão: char B[10] \n");

        Random rnd = new Random();

        int[] a = new int[10];
        char[] b = new char[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(0, 20);

            if (a[i] < 7)
            {
                b[i] = 'a';
            }
            else if (a[i] == 7)
            {
                b[i] = 'b';
            }
            else if (a[i] > 7 && a[i] < 10)
            {
                b[i] = 'c';
            }
            else if (a[i] == 10)
            {
                b[i] = 'd';
            }
            else
            {
                b[i] = 'e';
            }
        }

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Posição: " + i + " vetor A valor: " + a[i] + ", vetor B valor: " + b[i]);
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}