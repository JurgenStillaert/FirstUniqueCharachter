using System.Text.RegularExpressions;

namespace FirstUniqueCharacterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a string
            Console.WriteLine("Enter a string to find the first non-repeated character:");
            string input = Console.ReadLine();

            // Create an instance of CharacterFinder and find the first non-repeated character
            CharacterFinder finder = new CharacterFinder();
            char result = finder.FirstNonRepeatedCharacter(input);

            // Display the result
            if (result == '*')
            {
                Console.WriteLine("All characters in the string are repeated.");
            }
            else
            {
                Console.WriteLine($"The first non-repeated character is: {result}");
            }

            // Wait for the user to press a key before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    public class CharacterFinder
    {
        public char FirstNonRepeatedCharacter(string input)
        {
           
            return '*';
        }
    }
}
