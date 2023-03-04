using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 38: Ler um vetor A com 10 elementos. \n" +
            "Construir um vetor B de mesmo tipo e tamanho, sendo que cada elemento de B deverá ser o seguinte somatório: " +
            "\nBi = Somatório de Aj, para todo j variando de i até 10.");

        Random rnd = new Random();
        int[] a = new int[10];
        int[] b = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(0, 10);
        }

        for(int j = 0; j < a.Length; j++)
        {
            int temp = 0;
            for(int k = 0; k <= a[j]; k++)
            {
                temp += k;
                b[j] = temp;
            }
        }

        for(int l = 0; l < a.Length; l++)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Vetor A posição: " + l + " valor: " + a[l]);
            Console.WriteLine("Vetor B posição: " + l + " valor: " + b[l]);
        };

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}