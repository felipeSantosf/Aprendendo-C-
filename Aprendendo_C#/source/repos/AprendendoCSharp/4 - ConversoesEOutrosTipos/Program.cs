using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.69;

        Console.WriteLine(salario); 

        int salarioInteiro;
        salarioInteiro = (int)salario;

        Console.WriteLine(salarioInteiro);

        int x;
        //x = 90000000000000000000000000000000000;

        
        // Long é um tipo de variável de 64 bits
        long z;
        z = 200000000000;
        
        Console.WriteLine(z);

        short y;
        y = 15000;

        Console.WriteLine(y);   

        float altura;
        altura = 1.62f;

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}