using QuizProgram;

class Program
{
    
    static void Main()
    {
        bool game = false;

        List<Question> quiz1Questions = new List<Question>()
        {
            new Question(Storage.q1q1, Storage.q1a1),
            new Question(Storage.q1q2, Storage.q1a2),
            new Question(Storage.q1q3, Storage.q1a3)
        };

        Quiz quiz1 = new Quiz("Quiz 1", quiz1Questions);

        //Quiz quiz2 = new Quiz("Quiz 2", quiz2Questions);

        Console.WriteLine("Select quiz 1 or 2.\n");
        string selection = Console.ReadLine();

        quiz1Questions[0].GetType();
        quiz1Questions[1].GetType();
        quiz1Questions[2].GetType();


        if (selection == "1")
        {
            AskQuestion1();
            game = true;
        }

        else if (selection == "2")
        {
            Console.WriteLine("There is no question 2 yet!");
        }
        else
        {
            Console.WriteLine("No such quiz.");
        }

        if (game)
        Console.WriteLine($"Your score is {quiz1.quizScore} out of 3.");

        void AskQuestion1()
        {
            quiz1.QuizInfo();
            quiz1.PrintQuestion(quiz1Questions[0], 1, Storage.q1q1);
            quiz1.QuestionCheck(quiz1Questions[0], Storage.q1a1);
            quiz1.PrintQuestion(quiz1Questions[0], 2, Storage.q1q2);
            quiz1.QuestionCheck(quiz1Questions[0], Storage.q1a2);
            quiz1.PrintQuestion(quiz1Questions[0], 3, Storage.q1q3);
            quiz1.QuestionCheck(quiz1Questions[0], Storage.q1a3);
        }
    }
}