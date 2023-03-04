using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ler 10 elementos inteiros em um vetor A e colocá-los em ordem \r\ncrescente e apresentar os elementos ordenados.");

        Random rnd = new Random();
        int[] a = new int[10];
        int temp;

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(1, 50);
            Console.WriteLine(a[i]);    
        }


        Console.WriteLine("-----------------------------------------------------");
        for(int j = 0; j < a.Length; j++) 
        {
            for (int k = 0; k < a.Length; k++)
            {
                if (a[k] > a[j])
                {
                    temp = a[j];
                    a[j] = a[k];
                    a[k] = temp;  
                }
            }

        }

        for(int k = 0; k < a.Length; k++ )
        {
            Console.WriteLine(a[k]);
        }

        Console.WriteLine("Aplicaçãop finalizada, pressione enter para continuar...");
        Console.ReadLine();


    }
}