using System;
using Scrabble;

namespace ScrabbleMain
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a word to see the Scrabble points it is worth");
            string userInput = Console.ReadLine();
            ScorePoints ScorePoints = new ScorePoints();
            Console.WriteLine(ScorePoints.GrabValues(userInput)); 
        }
    }
}
