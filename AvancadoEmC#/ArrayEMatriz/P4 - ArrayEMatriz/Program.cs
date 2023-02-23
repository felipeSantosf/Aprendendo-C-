using System;

class Program
{
    static void Main(string[] args)
    {
        double[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        double[] b = new double[a.Length];

        for (int i = 0; i < b.Length; i++)
        {

            b[i] = Math.Sqrt(a[i]);
            Console.WriteLine(b[i]);
        }
    }
}