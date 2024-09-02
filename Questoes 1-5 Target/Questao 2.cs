//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
//
//IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe um número:");
        int num = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        if (num == a || num == b)
        {
            Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
            return;
        }

        int prox = a + b;

        while (prox <= num)
        {
            if (prox == num)
            {
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
                return;
            }

            a = b;
            b = prox;
            prox = a + b;
        }

        Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
    }
}