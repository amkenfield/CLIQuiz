using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIQuiz
{
    public class Question
    {
        public int Id { get; }
        public string Prompt { get; }
        // for now, will separate answers into individual items;
        // but would a List<string> make more sense?

        // also, need to account for correct vs. incorrect answers;
        // initial inclination is to always have Answer1 be correct,
        // and then shuffle the four when displayed in game
        public Answer Answer1 { get; }
        public Answer Answer2 { get; }
        public Answer Answer3 { get; }
        public Answer Answer4 { get; }

        public Question(int id, string prompt, Answer answer1, Answer answer2, Answer answer3, Answer answer4)
        {
            Id = id;
            Prompt = prompt;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
        }
    }
}
