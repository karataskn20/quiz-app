namespace QuizProgram.QuizProps
{
    public class Answer
    {
        public string answerDesc;
        public bool isTrue;

        public Answer(string _answer, bool _correct)
        {
            this.answerDesc = _answer;
            this.isTrue = _correct;
        }
    }
}
