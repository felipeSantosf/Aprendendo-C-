using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        int[] b = new int[a.Length];

        for (int i = 0; i < b.Length; i++)
        {
            b[i] = a[i] * a[i];
            Console.WriteLine(b[i]);
        }
    }
}