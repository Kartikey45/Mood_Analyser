using NUnit.Framework;
using Mood_Analyser_Problem;

namespace MoodAnalyserTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            try
            {
                moodAnalyser.analyzeMood(null);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.ENTERED_NULL, e.type);
            }
        }
    }
}