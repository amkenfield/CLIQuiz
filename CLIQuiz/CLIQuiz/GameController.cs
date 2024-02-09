using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIQuiz
{
    public class GameController
    {
        private Game game;

        public void Run()
        {
            do
            {
                Setup();
                Play();
            } while (PlayAgain());
        }

        private void Setup()
        {
            
            string welcomeMessage = "Welcome to Flash App!";
            Console.WriteLine(welcomeMessage);
            Console.WriteLine(new string('=', welcomeMessage.Length));
            Console.WriteLine();

            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Hello, {playerName}! Let's get started.");

            game = new Game(playerName, PopulateQuestionBank());
        }

        private List<Question> PopulateQuestionBank()
        {
            List<Question> questions = [new Question(1, "Test", new Answer("Eenie", true), new Answer("Meenine", false), new Answer("Meinie", false), new Answer("Moe", false))];

            return questions;
        }

        private void Play()
        {
            for (int i = 0; i < game.QuestionBank.Count; i++)
            {
                AskQuestion(game.QuestionBank[i]);
            }

            GenerateGameReport();
        }

        private void AskQuestion(Question question)
        {
            // TODO: add logic for displaying question and taking input
            Console.WriteLine(question.Prompt);
            Console.WriteLine();
            Console.WriteLine($"A) {question.Answer1.AnswerText}");
            Console.WriteLine($"B) {question.Answer2.AnswerText}");
            Console.WriteLine($"C) {question.Answer3.AnswerText}");
            Console.WriteLine($"D) {question.Answer4.AnswerText}");
            
            bool validInput = false;
            do
            {
                Console.WriteLine();
                Console.Write($"{game.PlayerName}: ");
                var userChoice = Console.ReadLine().ToUpper();
                if ( userChoice == "A" || userChoice == "B" || userChoice == "C" || userChoice == "D") validInput = true;
            } while (!validInput);
            

        }

        // TODO (adv): ShuffleAnswers() helper method

        private void GenerateGameReport()
        {
            var correctAnswers = game.CorrectAnswers;
            var incorrectAnswers = game.IncorrectAnswers;
            var totalAnswers = correctAnswers + incorrectAnswers;

            Console.WriteLine($"{game.PlayerName}, you have:");
            Console.WriteLine(new string('=', 23));
            // the spacing in the below will be brute-forced, for now,
            // but will need to correct the formatting
            Console.WriteLine($"  {correctAnswers} Correct Answers");
            Console.WriteLine($"  {incorrectAnswers} Incorrect Answers");
            Console.WriteLine($"  {totalAnswers} Total Questions");

            // TODO: write helper method to return correctly rounded number
            Console.WriteLine($"{decimal.Round((correctAnswers / totalAnswers) * 100), 1}% Correct");
            Console.WriteLine($"{decimal.Round((incorrectAnswers / totalAnswers) * 100), 1}% Incorrect");
            Console.WriteLine();

            if (correctAnswers / totalAnswers > 0.75)
            {
                Console.WriteLine("Well done!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Maybe better next time!");
                Console.WriteLine();
            }

        }
        private bool PlayAgain()
        {
            Console.Write("Would you like to play again? [y/n]: ");
            return Console.ReadLine().ToUpper().Equals("Y");
        }
    }
}
