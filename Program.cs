using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor digite a palavra: ");
            var word = Console.ReadLine().ToLower();

            var result = Palindrome.IsPalindrome(word);

            if (result == true)
            {
                Console.WriteLine("A palavra é um Palindrome!");
            }
            else
            {
                Console.WriteLine("Não é um Palindrome!");
            }
        }
    }
}
