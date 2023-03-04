using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio 41: Ler 10 elementos inteiros em um vetor A. " +
            "Montar uma rotina de busca, \r\npara pesquisar se um dado elemento X está armazenado em A.");

        Random random = new Random();
        int[] a = new int[10];
        string elemento;
        int elementoConvertido;
        int elementoEncontrado = -1;

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(1, 10);
        }

        Console.WriteLine("Insira o elemento a ser procurado no array: ");
        elemento = Console.ReadLine();
        elementoConvertido = Convert.ToInt32(elemento);

        for (int j = 0; j < a.Length; j++)
        {
            if (elementoConvertido == a[j])
            {
                elementoEncontrado = j;
            }


        }

        if (elementoEncontrado != -1)
        {
            Console.WriteLine("Elemento encontrado, posição [" + elementoEncontrado + "] do vetor! \n ");
        }
        else
        {
            Console.WriteLine("Elemento não encontrado! \n ");
        }

        for (int k = 0; k < a.Length; k++)
        {
            Console.WriteLine("VetA[" + k + "] : " + a[k]);
            Console.WriteLine("--------------------------------------------------------");
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();

    }
}