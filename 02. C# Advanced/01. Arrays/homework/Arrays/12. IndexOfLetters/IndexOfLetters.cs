namespace _12.IndexOfLetters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            foreach (char symbol in str)
            {
                if (char.IsLetter(symbol))
                {
                    Console.WriteLine(char.ToLower(symbol) - 'a');
                }
            }
        }
    }
}

// Write a program that creates an array containing all letters from the alphabet (a-z). 
// Read a word from the console and print the index of each of its letters in the array.
// Personal notes: The task is about using array's, but i find it stuped in this case...