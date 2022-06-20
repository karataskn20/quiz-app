using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram.qa
{
    public class Question
    {
        public string description;
        public Type questionType;
        public List<Answer> answers;

        public Question(string _description, List<Answer> _answers)
        {
            this.description = _description;
            this.answers = _answers;
        }

        private void GetType()
        {
            if (answers.Count == 1)
            {
                this.questionType = Type.SingleAnswer;
            }
            else if (answers.Count > 1)
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
            string tempType;
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
                return "";
            }
        }
    }

}
