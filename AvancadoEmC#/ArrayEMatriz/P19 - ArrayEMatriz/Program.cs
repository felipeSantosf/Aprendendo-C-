using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        Console.WriteLine("Ler as duas notas bimestrais para um conjunto de 10 alunos. " +
            "\r\nArmazenar as notas informadas em dois vetores “Nota1” e “Nota2” do \r\ntipo real. " +
            "Escreva um programa que calcule a média aritmética simples \r\ndas notas informadas armazenando o resultado em um vetor “Result” \r\nde mesmo tipo e tamanho. " +
            "Ao mostrar os resultados exibir a situação \r\nde cada aluno. " +
            "Se a média calculada for superior ou igual a 7 o aluno \r\nestará “aprovado”, caso contrário, a situação do aluno será \r\n“reprovado”");

        string[] alunos = { "Felipe", "João", "Pedro", "Reginaldo", "Lucas", "Ana", "Renata", "Maria", "Fábio" };
        int[] nota1 = new int[9];
        int[] nota2 = new int[9];
        double[] result = new double[alunos.Length];

        for(int i = 0; i < nota1.Length; i++)
        {
            nota1[i] = rnd.Next(0,10);
            nota2[i] = rnd.Next(0,10);
        }

        for ( int i = 0; i < alunos.Length; i++)
        {
            result[i] = (nota1[i] + nota2[i]) / 2;
            if (result[i] >= 7)
            {
                Console.WriteLine("Aluno: " + alunos[i] + " aprovado, média: " + result[i]);
            } else
            {
                Console.WriteLine("Aluno: " + alunos[i] + " reprovado, média: " + result[i]);
            }
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.ReadLine();
        
    }
}