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
            if (Message.Contains("SAD"))
                return "SAD";
            else return "HAPPY";
        }
        static void Main(string[]args)
        {

        }
    }
}