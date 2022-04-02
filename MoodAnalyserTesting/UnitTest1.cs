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
            moodAnalayser = new MoodAnalayser();
        }
        /// <summary>
        /// TC-1.1 Given"I am in Sad Mood" message Should Return SAD
        /// </summary>
        [Test]
        public void GivenMassage_When_ShouldReturnSad()
        {
            string message = moodAnalayser.AnalyserMood("I an in SAD Mood");
                Assert.AreEqual("SAD", message); 
        }
        /// <summary>
        /// TC-1.2 Given"I am in Any Mood" message Should Return HAPPY
        /// </summary>
        [Test]
        public void GivenMassage_When_ShouldReturnHappy()
        {
            string message = moodAnalayser.AnalyserMood("I an in Any Mood");
                Assert.AreEqual("HAPPY", message); 
        }
    }
}