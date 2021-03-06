using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace MoodAnalyserTesting
{
    public class MoodAnalyseFactory
    {
        public static object GetMoodAnalyserObject(string ClassName, string ConstructorName)
        {
            string pattern = @"." + ConstructorName + "$";
            Match result = Regex.Match(ClassName, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type MoodAnalyserType = assembly.GetType(ClassName);
                    return Activator.CreateInstance(MoodAnalyserType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserCustomeException(MoodAnalyserCustomeException.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }
            else
                throw new MoodAnalyserCustomeException(MoodAnalyserCustomeException.ExceptionType.NO_SUCH_METHOD, "constructor not found");
        }
    }
}
