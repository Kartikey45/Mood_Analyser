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
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            try
            {
                moodAnalyser.analyzeMood(null);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.ENTERED_NULL, e.type);
            }
        }

        [Test]
        public void Test2()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            try
            {
                moodAnalyser.analyzeMood("");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.ENTERED_EMPTY, e.type);
            }
        }
    }
}
