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

        //METHOD TO CHECK THE CONDITIONS
        public string analyseMood()
        {
            try
            {
                if (message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
                return "happy";
            }
        }

        //MAIN METHOD
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser.");
            Console.ReadKey();
        }
    }
}
