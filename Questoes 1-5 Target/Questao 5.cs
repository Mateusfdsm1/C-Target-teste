//5) Escreva um programa que inverta os caracteres de um string.

//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;

using System;

class Program
{
    static void Main()
    {

        string input = "Exemplo de string a ser invertida";

        char[] charArray = input.ToCharArray();

        int length = charArray.Length;

        for (int i = 0; i < length / 2; i++)
        {
            char temp = charArray[i];
            charArray[i] = charArray[length - 1 - i];
            charArray[length - 1 - i] = temp;
        }

        string invertedString = new string(charArray);

        Console.WriteLine("String original: " + input);
        Console.WriteLine("String invertida: " + invertedString);
    }
}