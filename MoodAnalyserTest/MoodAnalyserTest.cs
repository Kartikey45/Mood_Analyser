using NUnit.Framework;
using Mood_Analyser_Problem;

namespace MoodAnalyserTest
{
    
    public class Tests
    {
        [Test]
        public void Test1()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in sad mood");
            string value = mood.analyseMood();
            Assert.AreEqual("sad", value);
        }

        [Test]
        public void Test2()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in happy mood");
            string value = mood.analyseMood();
            Assert.AreEqual("happy", value);
        }
    }
}