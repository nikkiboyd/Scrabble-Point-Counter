using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace ScrabbleTests
{
    [TestClass]
    public class ScorePointsTests
    {
        [TestMethod]
        public void GrabValue_LoopArrayToGetValue_totalPoints()
        {   
            string userInput = "dog";
            ScorePoints testScorePoints = new ScorePoints();
            CollectionAssert.AreEqual(new List<int> {2,1,2}, testScorePoints.GrabValues(userInput));
        }
        [TestMethod]
        public void AddPoints_AddingPointsFromList_FinalPoints()
        {
            List<int> finalPoints = new List<int>{ 2, 1, 2 };
            ScorePoints testScorePoints = new ScorePoints();
            Assert.AreEqual(5, testScorePoints.AddPoints(finalPoints));
        }
    }
}