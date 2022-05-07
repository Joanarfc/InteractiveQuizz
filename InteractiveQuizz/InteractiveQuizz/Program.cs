using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveQuizz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();


            string[] questions = new string[] { "Spanish is the native language in Portugal", "Switzerland is a member of the European Free Trade Area (EFTA).", "In Brazil, the native language is Brazilian" };
            bool[] correctAnswers = new bool[] { false, true, false };

            RunQuiz(questions, correctAnswers);


        }

        static void RunQuiz(string[] questions, bool[] answers )
        {
            bool[] responses = new bool[questions.Length];

            if (responses.Length != answers.Length)
            {
                Console.WriteLine("WARNING! There is no match between questions and answers!");
            }

            int askingIndex = 0;


            foreach (string question in questions)
            {
                string reply;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                reply = Console.ReadLine();

                isBool = Boolean.TryParse(reply, out inputBool);

                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    reply = Console.ReadLine();
                    isBool = Boolean.TryParse(reply, out inputBool);


                    continue;

                }

                responses[askingIndex] = inputBool;
                askingIndex++;

            }


            int scoringIndex = 0;
            int score = 0;
            bool inputResponses;

            foreach (var answer in answers)
            {
                inputResponses = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. User response: {inputResponses} | Correct answer: {answers[scoringIndex]}");
                if (inputResponses == answers[scoringIndex])
                {
                    score++;
                }
                scoringIndex++;

            }

            Console.WriteLine($"You've got {score} correct answers out of {questions.Length}!");
        }
    }
}
