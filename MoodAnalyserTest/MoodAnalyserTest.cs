using NUnit.Framework;
using Mood_Analyser_Problem;

namespace MoodAnalyserTest
{
    
    public class Tests
    {
        [Test]
        public void Test()
        {
            MoodAnalyser moodanalyser = new MoodAnalyser();
            string value = moodanalyser.analyseMood("i am sad");
            Assert.AreEqual(value,"SAD");
        }

        [Test]
        public void Test2()
        {
            MoodAnalyser moodanalyser = new MoodAnalyser();
            string value = moodanalyser.analyseMood("i am in any mood");
            Assert.AreEqual(value, "HAPPY");
        }
    }
}