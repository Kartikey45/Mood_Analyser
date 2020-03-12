using System;

namespace Mood_Analyser_Problem
{
    public class MoodAnalyser
    {
        //VARIABLE INITIALIZE
        String message;

        //NON-PARAMETERISED CONSTRUCTOR
        public MoodAnalyser()
        {

        }

        //PARAMETERISED CONSTRUCTOR
        public MoodAnalyser(String message)
        {
            this.message = message;
        }

        public String analyzeMood(String message)
        {
            this.message = message;
            return analyzeMood();
        }

        //METHOD TO CHECK THE MOOD
        public String analyzeMood()
        {
            try
            {
                if (message.Length == 0)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_EMPTY, "Please enter proper mood");
                }
                if (message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_NULL, "Please enter proper mood");
            }
        }
    }

    class MainClass
    {
        //MAIN METHOD
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser.");
        }
    }
}
