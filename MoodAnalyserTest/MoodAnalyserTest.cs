using NUnit.Framework;
using Mood_Analyser_Problem;

namespace MoodAnalyserTest
{   
    public class Tests
    {
        [Test]
        public void Test1()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            string value = mood.analyseMood();
            Assert.AreEqual("happy", value);
        }
    }
}