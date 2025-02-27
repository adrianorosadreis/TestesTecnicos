using System;

class Program
{
    static void Main()
    {
        /* PS: Poderia ser resolvido diretamente em memória utilizando unsafe code(com ponteiros). 
        Porém não é aconselhável devido à riscos com segurança. */

        // Solicita ao usuário que insira uma string
        Console.WriteLine("Digite uma string para inverter:");
        string input = Console.ReadLine();

        // Inverte a string 
        string invertedString = InvertString(input);

        // Exibe a string invertida
        Console.WriteLine("String invertida:");
        Console.WriteLine(invertedString);        
    }

    static string InvertString(string str)
    {
        // Usa Span<char> para manipulação direta e eficiente da memória
        Span<char> chars = str.ToCharArray().AsSpan();

        // Inverte os caracteres no Span
        ReverseSpan(chars);

        // Converte o Span de volta para uma string
        return new string(chars);
    }

    static void ReverseSpan(Span<char> span)
    {
        int length = span.Length;
        for (int i = 0; i < length / 2; i++)
        {
            // Troca os caracteres de forma eficiente
            (span[i], span[length - 1 - i]) = (span[length - 1 - i], span[i]);
        }
    }
}