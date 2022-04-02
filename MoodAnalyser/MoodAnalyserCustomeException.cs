using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserTesting
{ 
    public class MoodAnalyserCustomeException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            EMPTY_MOOD,
            EMPTY_NULL
        }
        public MoodAnalyserCustomeException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}
