using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIQuiz
{
    public class Answer
    {
        public string AnswerText { get; }
        public bool isCorrect { get; }

        public Answer(string AnswerText, bool isCorrect)
        {
            this.AnswerText = AnswerText;
            this.isCorrect = isCorrect;
        }
    }
}
