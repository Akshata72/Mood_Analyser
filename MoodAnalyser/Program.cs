using System;
namespace MoodAnalyserTesting
{ 
    public class MoodAnalayser
    {
        public MoodAnalayser()
        {
            
        }
        public string AnalyserMood(string Message)
        {
            if (Message.Contains("SAD"))
                return "SAD";
            else return "HAPPY";
        }
        static void Main(string[]args)
        {

        }
    }
}