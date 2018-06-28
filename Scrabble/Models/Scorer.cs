using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble
{
    public class ScorePoints
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>() { { 'a', 1 }, { 'b', 3 }, { 'c', 3 }, { 'd', 2 }, { 'e', 1 }, { 'f', 4 }, { 'g', 2 }, { 'h', 4 }, { 'i', 1 }, { 'j', 8 }, { 'k', 5 }, { 'l', 1 }, { 'm', 3 }, { 'n', 1 }, { 'o', 1 }, { 'p', 3 }, { 'q', 10 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'u', 1 }, { 'v', 4 }, { 'w', 4 }, { 'x', 8 }, { 'y', 4 }, { 'z', 10 }, };

        public List<int> GrabValues(string userInput)
        {
            List<int> totalPoints = new List<int>();

            foreach (char letter in userInput)
            {
                if (dictionary.ContainsKey(letter))
                {
                  totalPoints.Add(dictionary[letter]);   
                } 
            }
            AddPoints(totalPoints);
            return totalPoints;
        }

        public int AddPoints(List<int> totalPoints)
        {
            int finalPoints = totalPoints.Sum();
            return finalPoints;
        }
    }
}
