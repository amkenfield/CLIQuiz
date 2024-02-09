using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIQuiz
{
    public class Game
    {
        public string PlayerName { get; }
        public List<Question> QuestionBank {  get; }
        public int CorrectAnswers { get; }
        public int IncorrectAnswers { get; }

        public Game(string playerName, List<Question> questions)
        {
            PlayerName = playerName;
            QuestionBank = questions;
            CorrectAnswers = 0;
            IncorrectAnswers = 0;
        }
        
    }


}
