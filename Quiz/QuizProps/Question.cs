namespace QuizProgram.QuizProps
{
    public class Question
    {
        private readonly string description;
        private  int trueAnswers = 0;
        public List<Answer> answers;
        public Type questionType;

        public Question(string _description, List<Answer> _answers)
        {
            this.description = _description;
            this.answers = _answers;
        }

        public void GetType()
        {
            foreach(var answer in answers)
            {
                if (answer.isTrue)
                    trueAnswers++;
            }

            if (trueAnswers == 1)
            {
                this.questionType = Type.SingleAnswer;
            }
            else if (trueAnswers > 1)
            {
                this.questionType = Type.MultipleAnswer;
            }
            else
            {
                this.questionType = Type.Open;
            }
        }

        public string TempType()
        {
            if (questionType == Type.SingleAnswer)
            {
                return "Single Answer";
            }
            else if (questionType == Type.MultipleAnswer)
            {
                return "Multiple Answers";
            }
            else
            {
                return "Open Answer";
            }
        }
    }

}