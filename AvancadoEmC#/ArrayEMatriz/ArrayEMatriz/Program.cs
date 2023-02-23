using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5 };
        int[] b = a;

        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine(b[i]);
        }
    }

}