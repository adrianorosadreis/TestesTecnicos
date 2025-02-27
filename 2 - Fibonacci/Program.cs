using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        if (IsFibonacci(numero))
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool IsFibonacci(int n)
    {
        // Verifica se 5*n^2 + 4 ou 5*n^2 - 4 é um quadrado perfeito
        return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
    }

    static bool IsPerfectSquare(int x)
    {
        int s = (int)Math.Sqrt(x);
        return s * s == x;
    }
}