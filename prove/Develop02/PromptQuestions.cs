using System;

namespace RandomQuestionGenerator
{
    public class PromptQuestions
    {
        private static string[] _questions =
        {"What was the best part of my day?",
        "How idd I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I coudl do over today, what would it be?",
        "Who was the most interesting person I interacted with today?",
        "What did you eat today?",
        "If you could have a do-over of today, what woudl you want to improve?",
        "Where have you been today?",
        "Who did you serve today?",
        "Who served you today?"};

        public static string _randomQuestionsPrompt()
        {
            var rand = new Random();
            string randomQuestion = _questions[rand.Next(_questions.Length)];

            return randomQuestion;
        }
    }
}