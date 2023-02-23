﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Investindo a Longo prazo");

        double investimento = 1000.69;
        double fatorRendimento = 1.056;

        for (int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++) 
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.0001;
        }

        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}