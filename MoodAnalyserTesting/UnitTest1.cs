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
        /// UC 2- Handle Exception if User Provides Invalid Mood
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

        /// <summary>
        /// UC 3- Inform user if entered Invalid Mood
        /// </summary>
        /// UC 3.1- Given NULL Mood Should Throw MoodAnalysisException

        [Test]
        public void GivenMessage_WhenNull_CustomeException()
        {
            string message = " ";
            string expected = "Mood should not be null";
            try
            {
                moodAnalayser = new MoodAnalayser(message);
            }
            catch(MoodAnalyserCustomeException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// UC 3- Inform user if entered Invalid Mood
        /// </summary>
        /// UC 3.2- Given Empty Mood Should Throw MoodAnalysisException
        [Test]
        public void GivenMessage_WhenEmpty_CustomeException()
        {
            string message = null;
            string expected = "Mood should not be empty";
            try
            {
                // Act
                moodAnalayser = new MoodAnalayser(message);
            }
            catch (MoodAnalyserCustomeException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// UC 4-Use Reflection to Create MoodAnalyser with default Constructor
        /// </summary>
        MoodAnalyseFactory moodAnalyseFactory;
        [SetUp]
        public void Setup1()
        {
            moodAnalyseFactory = new MoodAnalyseFactory();
        }
        /// <summary>
        /// UC 4.1-Given MoodAnalyser Class Name Should Return MoodAnalyser Object 
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_WhenProper_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyseFactory();
            object result = MoodAnalyseFactory.GetMoodAnalyserObject("MoodAnalyserTesting.MoodAnalyseFactory", "MoodAnalyseFactory");
            expected.Equals(result);
        }

        /// <summary>
        /// UC 4.2-Given Class Name When Improper Should Throw MoodAnalysis Exception
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_WhenImproper_ShouldThrowMoodAnalysisException()
        {
            string excepted = "Class not found";
            try
            {
                object result = MoodAnalyseFactory.GetMoodAnalyserObject("MoodAnalyserTesting.MoodAnalyseFactory", "MoodAnalyseFactory");
            }
            catch (MoodAnalyserCustomeException exception)
            {
                Assert.AreEqual(excepted, exception.Message);
            }
        }

        /// <summary>
        /// UC 4.3-Given Class When Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_WhenConstructorNameIsImproper_ShouldThrowMoodAnalysisException()
        {
            string excepted = "constructor not found";
            try
            {
                object result = MoodAnalyseFactory.GetMoodAnalyserObject("MoodAnalyserTesting.MoodAnalyseFactory", "MoodAnalyseFactory");
            }
            catch (MoodAnalyserCustomeException exception)
            {
                Assert.AreEqual(excepted, exception.Message);
            }
        }
    }
}