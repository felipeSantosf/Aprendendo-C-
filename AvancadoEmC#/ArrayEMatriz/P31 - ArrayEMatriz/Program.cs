using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio 31: Ler um vetor A com 20 elementos. " +
            "Separar os elementos pares e \r\nímpares de A utilizando apenas um vetor extra B. " +
            "Sugestão: no início \r\ndo vetor B armazene os elementos pares de A e nas posições \r\nrestantes do vetor B armazene os elementos de A que são ímpares");

        int[] a = new int[20];
        int[] b = new int[a.Length];
        int contador = 0;
        int menorNumero = 0;
        Random random = new Random();

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(1, 20);

        }

        for (int h = 0; h < a.Length; h++)
        {
            if (a[h] % 2 == 0)
            {

                b[contador] = a[h];
                contador++;
            }

        }



        for (int j = 0; j < a.Length; j++)
        {
            if (a[j] % 2 != 0)
            {
                b[contador] = a[j];
                contador++;
            }
        }

        Console.WriteLine("----------------------------------------------------------------------------");

        for (int k = 0; k < a.Length; k++)
        {
            Console.WriteLine("Posição: " + k + " Vetor A - valor: " + a[k] + "                     Vetor B - valor: " + b[k]);
        }

        Console.WriteLine("----------------------------------------------------------------------------");

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();

    }
}