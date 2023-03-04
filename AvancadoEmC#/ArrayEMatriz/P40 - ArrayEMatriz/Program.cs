using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Criar dois vetores A e B cada um com 10 elementos inteiros. " +
            "\r\nDesenvolver um programa que crie um vetor C que é a diferença dos \r\nconjuntos formados pelos elementos dos vetores A e B. " +
            "Diferença de \r\nconjuntos = todos os elementos do conjunto A que não existem no \r\nconjunto B. \n\n");

        int[] a = new int[10];
        int[] b = new int[a.Length];
        int[] c = new int[b.Length];
        int index = 0;
        int diferente = 0;


        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(1, 10);
            b[i] = random.Next(1, 10);
            Console.WriteLine("Vetor A[" + i + "] : " + a[i]);
            Console.WriteLine("Vetor B[" + i + "] : " + b[i]);
            Console.WriteLine("-----------------------------");
        }


        for (int j = 0; j < a.Length; j++)
        {


            for (int l = 0; l < a.Length; l++)
            {
                if (a[j] == b[l])
                {
                    diferente++;
                }
            }

            if (diferente == 0)
            {
                c[index] = a[j];
            }

            index++;
            diferente = 0;
        }

        for (int k = 0; k < c.Length; k++)
        {
            for (int m = 0; m < k; m++)
            {
                if (c[k] == c[m])
                {
                    c[k] = 0;
                }
            }

            if (c[k] != 0)
            {
                Console.WriteLine("Vetor C[" + k + "] : " + c[k]);

            }
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();


    }
}