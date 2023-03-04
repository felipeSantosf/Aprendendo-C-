using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio 33: Criar um vetor A com 10 elementos inteiros. " +
            "Escreva um programa que \r\nimprima cada elemento do vetor A e uma mensagem indicando se o \r\nrespectivo elemento é um número primo ou não");

        Random rnd = new Random();
        int[] a = new int[10];
        int primo = 0;
        
        for(int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(1,100);
            Console.WriteLine("A[" + i + "] = = " + a[i]);
        }

        Console.WriteLine("---------------------------------------------------");

        for (int i = 0; i < a.Length; i++)
        {  
            for (int j = a[i]; j >= 1; j--)
            {
                if (a[i] % j == 0)
                {
                    primo++;
                    
                }
            }

            if(primo == 2)
            {
                Console.WriteLine(a[i] + " é um número primo!");
            }

            primo = 0;
        }

        Console.WriteLine("Programa finalizado, pressione enter para continuar...");
        Console.Read();
    }
}