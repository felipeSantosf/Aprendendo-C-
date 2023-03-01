using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Console.WriteLine("Exercício 20 e 21: Implementar um programa que obtenha a cotação do dólar (U$) em \r\nrelação ao real (R$) e" +
            " a seguir armazene em vetor A com 20 \r\nelementos as seguintes conversões:" +
            "\r\n21.A[i] = cotação do dolar * i, para todo i variando de 1 até 20.");

        double[] dolar = new double[20];
        double[] valorReal = new double[dolar.Length];

        for (int i = 0; i < dolar.Length; i++)
        {
            dolar[i] = rnd.NextDouble() * 20;
        }

        Console.WriteLine("Valor do dolar hoje: 5.22 BRL ");

        for (int i = 0; i < dolar.Length; i++)
        {
            valorReal[i] = dolar[i] * 5.22;
            Console.WriteLine("US$:" + dolar[i].ToString("F2") + " BRL$: " + valorReal[i].ToString("F2"));
        }


        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();

    }
}