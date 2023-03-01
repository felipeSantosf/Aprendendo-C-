using System;

class Program
{
    static void Main(string[] args) {
        Random rnd = new Random();
        int[] zeroEUm = new int[10];
        int zero = 0;
        int um = 0;

        Console.WriteLine("Gerar aleatoriamente um vetor A com 10 elementos inteiros e iguais a \r\n0 e 1, " +
            "sugestão: A[i] = (int)Math.round(Math.random() * 1); " +
            "Pede-se \r\npara implementar um programa que determine o percentual de \r\nnúmeros 0's e 1's existentes no vetor A");

        for(int i = 0; i < zeroEUm.Length; i++)
        {
            zeroEUm[i] = rnd.Next(0,2);
            Console.WriteLine(zeroEUm[i]);
            if (zeroEUm[i] == 1)
            {
                um++;
            } else
            {
                zero++;
            }
        }

        Console.WriteLine("Percentual de zero: " + (zero / zeroEUm.Length * 100));
        Console.WriteLine("Percentual de um: " + (um / zeroEUm.Length * 100));
        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();


    }
}