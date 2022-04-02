using MoodAnalyserTesting;
using NUnit.Framework;

namespace MoodAnalyserTesting
{
    public class Tests
    {
        MoodAnalayser moodAnalayser;
        [SetUp]
        public void Setup()
        {
            string res = "";
            //Arrange
            moodAnalayser = new MoodAnalayser(res);
        }
        /// <summary>
        /// TC-1.1 Given"I am in Sad Mood" message Should Return SAD
        /// </summary>

        //[Test]
        //public void GivenMassage_When_ShouldReturnSad()
        //{
        //    string message = moodAnalayser.AnalyserMood("I am in SAD Mood");
        //    Assert.AreEqual("SAD", message);
        //}
        /// <summary>
        /// TC-1.2 Given "I am in Any Mood" message Should Return HAPPY"
        /// </summary>

        //[Test]
        //public void GivenMassage_When_ShouldReturnHappy()
        //{
        //    string message = moodAnalayser.AnalyserMood("I am in Any Mood");
        //    Assert.AreEqual("HAPPY", message);
        //}

        /// <summary>
        /// Refacor - Refactor the code to take the mood message in Constructor
        /// </summary>
        /// Repeat TC 1.1- Given"I am in Sad Mood" message in Constructor Should Return SAD
        [Test]
        public void GivenMassage_When_ShouldReturnSad()
        {
            moodAnalayser = new MoodAnalayser("I am in SAD Mood");
            string message = moodAnalayser.AnalyserMood();
            Assert.AreEqual("SAD", message);
        }

        /// <summary>
        /// Refacor - Refactor the code to take the mood message in Constructor
        /// </summary>
        ///  Repeat TC 1.2- Given"I am in Any Mood" message in Constructor Should Return HAPPY
        [Test]
        public void GivenMassage_When_ShouldReturnHappy()
        {
            moodAnalayser = new MoodAnalayser("I am in Any Mood");
            string message = moodAnalayser.AnalyserMood();
            Assert.AreEqual("HAPPY", message);
        }

        /// <summary>
        /// Handle Exception if User Provides Invalid Mood
        /// </summary>
        [Test]
        public void GivenMessage_WhenNull_ShouldReturnHappy()
        {
            moodAnalayser = new MoodAnalayser(" ");
            //Act
            string message = moodAnalayser.AnalyserMood();
            //Assert
            Assert.AreEqual("HAPPY", message);
        }
    }
}