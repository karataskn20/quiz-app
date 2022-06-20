using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram.qa
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
