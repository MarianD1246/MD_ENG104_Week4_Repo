using System;

namespace Recursion;

public class Program
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine(SumLoop(5));
        Console.WriteLine(SumRecursive(5)); //A
    }

    private static int SumLoop(int n)
    {
        int sum = 0;
        for (int i = 1 ; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    private static int SumRecursive(int n)
    {
        if (n == 1) return 1; // if we don't have this base case , we have infinite recursion and get stack overflow
        int prev = SumRecursive(n - 1); //B
        int sum = n + prev;
        return sum;
    }
}