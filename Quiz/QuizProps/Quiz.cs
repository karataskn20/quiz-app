namespace QuizProgram.QuizProps
{
    public class Quiz
    {
        private string quizName;
        private int quizSize;
        public int quizScore;
        private List<Question> quizQuestions = new List<Question>();
        private readonly List<Answer> quizAnswers = new List<Answer>();

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
    }

    public static class QuestionManager
    {

        public static void PrintQuestion(Question _question, int _quizID, string _questionDescription)
        {
            _question.GetQuestionType();
            string tempType = _question.GetStringType();

            Console.WriteLine($"\nQuestion with {tempType}.\n" + $"Question {_quizID}: {_questionDescription}");
        }

        public static void QuestionCheck(Quiz _quiz, List<Answer> _answers)
        {
            string? input = Console.ReadLine();

            foreach (Answer _answer in _answers)
            {
                if (input == _answer.answerDesc && _answer.isTrue)
                {
                    _quiz.quizScore++;
                    break;
                }
            }
        }
    }

}