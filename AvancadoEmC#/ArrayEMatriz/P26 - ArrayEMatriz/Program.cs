using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criar dois vetores A e B cada um com 10 elementos inteiros. " +
            "Construir \r\num vetor C de mesmo tipo e tamanho, obedecendo as seguintes \r\nregras de formação: " +
            "a) Ci deverá receber 1 quando Ai for maior que Bi; \r\n" +
            "b) Ci deverá receber 0 quando Ai for igual a Bi; " +
            "c) Ci deverá receber -1 \r\nquando Ai for menor que Bi \n\n");

        Random rnd = new Random();
        int[] a = new int[10];
        int[] b = new int[a.Length];
        int[] c = new int[b.Length];

        for (int i = 0; i < a.Length; i++ )
        {
            a[i] = rnd.Next(1, 10);
            b[i] = rnd.Next(1, 10);

            if (a[i] > b[i])
            {
                c[i] = 1;
            }
            else if (a[i] == b[i])
            {
                c[i] = 0;
            }
            else
            {
                c[i] = -1;
            }
        }

        for(int i = 0; i < a.Length; i++ )
        {
            Console.WriteLine("Posição " + i + " valor vetA: " + a[i] + " valor vetB: " + b[i] + " valor vetC: " + c[i]);
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}