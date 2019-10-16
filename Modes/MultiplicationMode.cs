using System;
using System.Diagnostics;

namespace MathGame.Modes
{
    public class MultiplicationMode : IMode
    {
        public void Execute(int numberOfQuestion)
        {
            var rightAnswers = 0;
            var wrongAnswers = 0;
            var currentQuestion = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            while (currentQuestion < numberOfQuestion)
            {
                int providedAnswer = -1;
                var random = new Random();
                var lhs = level;
                var rhs = random.Next(0, 9);
                var correctAnswer = lhs * rhs;

                Clear();
                Console.WriteLine($"Antal frågor: {currentQuestion}");
                Console.WriteLine($"Antal rätt: {rightAnswers}");
                Console.WriteLine($"Antal fel: {wrongAnswers}");
                Console.WriteLine();
                Console.WriteLine($"{lhs} * {rhs}");

                do
                {
                    Console.WriteLine("Ange ett heltal:");
                }
                while (!int.TryParse(Console.ReadLine(), out providedAnswer));

                if (providedAnswer == correctAnswer)
                {
                    rightAnswers++;
                }
                else
                {
                    wrongAnswers++;
                }

                currentQuestion = rightAnswers + wrongAnswers;
            }


            stopwatch.Stop();
            Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine($"Antal frågor: {currentQuestion}");
            Console.WriteLine($"Antal rätt: {rightAnswers}");
            Console.WriteLine($"Antal fel: {wrongAnswers}");
            Console.WriteLine($"Tid: {{0:mm\\:ss}}: {stopwatch.Elapsed}");
            Console.WriteLine();
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Clear();
        }

        private void Clear()
        {
            Console.Clear();
        }
    }
}