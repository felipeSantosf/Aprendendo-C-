using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 17: Ler um vetor A com 10 elementos inteiros correspondentes as idades \r\nde um grupo de pessoas. " +
            "Escreva um programa que determine e\r\nescreva a quantidade de pessoas que possuem idade superior a 35 \r\nanos");

        int[] idades = new int[10];
        int qtde = 0; 
        Random rnd = new Random();

        for(int i = 0; i < idades.Length; i++)
        {
            idades[i] = rnd.Next(1, 100); 
        }

        for (int i = 0; i < idades.Length; i++)
        {
            if (idades[i] > 35)
            {
                qtde++;
            }
        }
        Console.WriteLine("Quantidade de pessoas com idade superior a 35 anos: " + qtde);
        Console.WriteLine("Aplicação finalizada, tecle enter para continuar...");
        Console.Read();


    }
}