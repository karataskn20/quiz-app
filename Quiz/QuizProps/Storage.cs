namespace QuizProgram.QuizProps
{
    public static class Storage
    {
        public static string q1q1 = "What is 91 / 7?" + "\na. 8 + 6" + "\nb. 52/4" + "\nc. 39/3";

        public static List<Answer> q1a1 = new List<Answer>()
        {
            new Answer("bc", true), new Answer("cb", true), new Answer("b c", true), new Answer("c, b", true)
        };

        public static string q1q2 = "Who invented C?" + "\na. Dennis Ritchie" + "\nb. Alan Turing" + "\nc. Abradolf Lincler ";

        public static List<Answer> q1a2 = new List<Answer>()
        {
            new Answer("a", true)
        };

        public static string q1q3 = "What year did WW2 start?" + "\na. 1914" + "\nb. 1928" + "\nc. 1939" + "\nd. 1945 ";

        public static List<Answer> q1a3 = new List<Answer>()
        {
            new Answer("c", true)
        };
    }
}
