using System;
namespace MoodAnalyserTesting
{ 
    public class MoodAnalayser
    {
        string Message;
        public MoodAnalayser(string Message)
        {
            this.Message = Message;
        }
        public string AnalyserMood()
        {
            try
            {
                if (Message.Equals(string.Empty))
                    throw new MoodAnalyserCustomeException(MoodAnalyserCustomeException.ExceptionType.EMPTY_MOOD, "Mood should not be empty");
                else if (this.Message.Contains("SAD"))
                    return "SAD";
                else return "HAPPY";
            }
            catch(NullReferenceException)
            {
                return "HAPPY";
            }
        }
        static void Main(string[]args)
        {

        }
    }
}