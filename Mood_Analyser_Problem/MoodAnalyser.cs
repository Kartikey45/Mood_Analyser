using System;

namespace Mood_Analyser_Problem
{
    public class MoodAnalyser
    {
        String message;

        public String analyseMood(String message)
        {
            if (message.Contains("sad"))
            {
                return "SAD";
            }
            else 
            {
                return "HAPPY";       
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser");
            Console.ReadKey();
        }
    }
}
