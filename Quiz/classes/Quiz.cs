using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram.qa
{
    public class Quiz
    {
        private string quizName;
        private int quizSize;
        public int quizScore;
        private List<Question> quizQuestions = new List<Question>();
        private List<Answer> quizAnswers = new List<Answer>();

        public Quiz(string _quizName, List<Question> _quizQuestions)
        {
            this.quizName = _quizName;
            this.quizQuestions = _quizQuestions;
            this.quizSize = quizQuestions.Count;
        }

        public void QuizInfo()
        {
            Console.WriteLine($"\nWelcome to quiz {quizName}\n" + "-----\n" + $"This Quiz has {quizSize} questions which has either a single answer or multiple answers.");
        }

        public void PrintQuestion(Question _question, int _quizID, string _questionDescription)
        {
            string tempType = _question.TempType();

            Console.WriteLine($"\nQuestion with {tempType}.\n" + $"Question {_quizID}: {_questionDescription}");
        }

        public void QuestionCheck(Question _question, List<Answer> _answers)
        {
            string input = Console.ReadLine();

            foreach(Answer _answer in _answers)
            {
                if (input == _answer.answerDesc && _answer.isTrue)
                {
                    quizScore++;
                    break;
                }
            }
        }
    }

}
