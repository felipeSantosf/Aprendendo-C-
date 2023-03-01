using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 18: Ler um vetor A com 10 elementos inteiros correspondentes as idades \r\nde um grupo de pessoas. " +
            "Escreva um programa que determine e \r\nescreva a menor e a maior idades e suas respectivas posições\n\n");

        Random rnd = new Random();
        int[] idades = new int[10];
        int maiorIdade = 0;
        int menorIdade = 0;

        for (int i = 0; i < idades.Length; i++)
        {
            idades[i] = rnd.Next(1, 70);
        }

        for (int i = 0; i < idades.Length; i++)
        {
            Console.WriteLine("Array de idades, posição: [" + i + "] valor: " + idades[i]);

            if (menorIdade > idades[i] || menorIdade == 0)
            {
                menorIdade = idades[i];
            }
            else if (maiorIdade < idades[i])
            {
                maiorIdade = idades[i];
            }

        }

        Console.WriteLine("Maior idade: " + maiorIdade);
        Console.WriteLine("Menor idade: " + menorIdade);
        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();



    }
}