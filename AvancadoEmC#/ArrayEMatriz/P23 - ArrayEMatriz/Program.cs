using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criar um vetor A com 10 elementos inteiros. " +
            "Desenvolver um programa \r\nque verifique se \"todos\" os elementos do vetor A são pares. " +
            "Se pelo \r\nmenos um elemento do vetor não for par o processo de repetição para \r\npercorrer os elementos do vetor deve ser encerrado, como sugestão: " +
            "\r\nutilize uma variável do tipo flag para atingir este propósito");

        Random rnd = new Random();
        int[] elem = new int[10];

        for (int i = 0; i < elem.Length; i++)
        {
            elem[i] = rnd.Next(1, 100);   
            if (elem[i] % 2 != 0)
            {
                Console.WriteLine("Elemento não é par, valor: " + elem[i]);
                break;
            } 
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}