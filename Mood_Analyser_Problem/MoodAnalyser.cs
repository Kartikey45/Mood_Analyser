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

        //METHOD TO CHECK THE MOOD
        public string analyseMood()
        {
            if (message.Contains("sad"))
            {
                message = "sad";
            }
            else
            {
                message = "happy";
            }
            return message;
        }

        //MAIN METHOD
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser.");
            Console.ReadKey();
        }

    }
}
