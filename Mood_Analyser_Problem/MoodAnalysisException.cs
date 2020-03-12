using System;
using System.Collections.Generic;
using System.Text;
using Mood_Analyser_Problem;

namespace Mood_Analyser_Problem
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY
        }
        public ExceptionType type;

        public MoodAnalysisException(ExceptionType type)
        {
            this.type = type;
        }
        public MoodAnalysisException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}
