using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace ScrabbleTests
{
    [TestClass]
    public class ScorePointsTests
    {
        //[TestMethod]
        //public void ScrabblePoints_ReturnsLetterWithValue_LetterAndValue()
        //{
        //    ScorePoints testScorePoints = new ScorePoints();

        //    //if (dictionary.ContainsKey('a'))
        //    //{
        //    //int value = dictionary["apple"];
        //    Assert.AreEqual("TEST", testScorePoints.ScrabblePoints());
        //}
        [TestMethod]
        public void BreakUpWord_SplitWordIntoCharArray_BrokenWord()
        {
            string userInput = "dog";
            ScorePoints testScorePoints = new ScorePoints();
            CollectionAssert.AreEqual(new char[] { 'd', 'o', 'g' }, testScorePoints.BreakUpWord(userInput));
        }
    }
}