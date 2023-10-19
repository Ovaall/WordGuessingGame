

using System.Numerics;

namespace AWordGuessingGame
{
    internal class Utilities
    {
        public static string GetRandomWord()
        {
            
            string[] words = {"krakow", "located", "southern","Poland", "following", "communes", "border"};

            
            Random random = new Random();
            int index = random.Next(words.Length);

            
            return words[index];
        }
    }
}
