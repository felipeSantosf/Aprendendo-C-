﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86+1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de tecnologia";
        Console.WriteLine(primeiraFrase + " 2023");

        string vazia = "";
        Console.WriteLine(vazia);

        //char letra = ''; Não pode ter caractere vazio, tem que por pelo menos um espaço, exemplo: char vazia = ' ';


        string cursos = @"Cursos disponíveis: 
- Go, 
- C#, 
- Python, 
- 'Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}