using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Números palíndromos são aqueles que escritos da direita para a \r\nesquerda têm o mesmo valor quando escritos da esquerda para a \r\ndireita." +
            " Exemplo: 545; 789987; 97379; 123454321; etc. Escreva um \r\nprograma que verifique se um dado vetor A de 10 elementos inteiros é \r\num palíndromo, ou seja," +
            " se o primeiro elemento do vetor e igual ao \r\núltimo, se o segundo elemento do vetor é igual ao penúltimo e assim \r\npor diante até verificar todos os elementos" +
            " ou chegar a conclusão que \r\no vetor não é um palíndromo");

        int[] vetA = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
        int[] vetB = { 1, 2, 3, 4, 5, 4, 3, 5, 1 };
        bool ePalindro = true;
        
        for (int i = 0; i< vetB.Length; i++)
        {
            //Console.WriteLine("vetB[" + i + "] value = " + vetB[i] + " : vetB[" + (vetB.Length - 1 - i) + "] value = " + vetB[vetB.Length - 1 - i]);

            if (vetB[i] == vetB[vetB.Length - 1 - i])
            {
                Console.WriteLine("vetB[" + i + "] value = " + vetB[i] + " : vetB[" + (vetB.Length - 1 - i) + "] value = " + vetB[vetB.Length - 1 - i] + " result: ok!");
            } else
            {
                Console.WriteLine("vetB[" + i + "] value = " + vetB[i] + " : vetB[" + (vetB.Length - 1 - i) + "] value = " + vetB[vetB.Length - 1 - i] + " result: not ok!");
                ePalindro = false; 
                   
            }
        }

        Console.WriteLine("É palindro? " + ePalindro);
        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}