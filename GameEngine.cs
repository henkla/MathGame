using MathGame.Modes;
using System;
using System.Diagnostics;

namespace MathGame
{
    public class GameEngine : IEngine
    {
        private int _maxQuestions = 3;
        private bool choiceIsMade => playerChoice > 0;
        private int playerChoice = -1;

        public void Execute()
        {
            Console.WriteLine("Välkommen till matematikspelet");
            Console.WriteLine("Tryck på ENTER när du vill börja!");
            Console.ReadKey();
            Clear();

            var currentMode = GetCurrentMode();
            currentMode.Execute(_maxQuestions);
        }

        private IMode GetCurrentMode()
        {
            var gameMode = ParseUserGameChoice();
            switch (gameMode)
            {
                case GameMode.Addition:
                    return new AdditionMode();
                case GameMode.Subtraction:
                    return new SubtractionMode();
                case GameMode.Division:
                    return new DivisionMode();
                case GameMode.Multiplication:
                    return new MultiplicationMode();
                case GameMode.MultiplicationMixed:
                    return new MultiplicationMixedMode();
                default:
                case GameMode.ExitGameMode:
                    return new ExitGameMode();
            }
        }

        private IMode GetMultiplicationMode()
        {
            return ParseUserMultiplicationTableChoice();
        }

        public void Addition()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Clear();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            while (totalQuestions != 20)
            {
                bool isUserAnswer = false;
                int userAnswer;
                Random random = new Random();
                int numberOne = random.Next(1, 21);
                int numberTwo = random.Next(1, 21);
                int problem = numberOne + numberTwo;

                if (numberOne > numberTwo)
                {

                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " + " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Clear();
                    if (userAnswer == problem)
                    {
                        Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else
                    numberOne = random.Next(1, 21);
            }
            stopwatch.Stop();
            Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Clear();
        }
        public void Subtraction()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Clear();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (totalQuestions != 20)
            {
                bool isUserAnswer = false;
                int userAnswer;
                Random random = new Random();
                int numberOne = random.Next(1, 21);
                int numberTwo = random.Next(1, 21);
                int problem = numberOne - numberTwo;

                if (numberOne > numberTwo)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " - " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Clear();
                    if (userAnswer == problem)
                    {
                        Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else
                    numberOne = random.Next(1, 21);
            }
            stopwatch.Stop();
            Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Clear();
        }
        public void Division()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Clear();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (totalQuestions != 20)
            {
                bool isUserAnswer = false;
                int userAnswer;
                Random random = new Random();
                int numberOne = random.Next(1, 16);
                int numberTwo = random.Next(1, 16);
                int problem = numberOne / numberTwo;
                int problemControl = numberOne % numberTwo;

                if (problemControl == 0)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " / " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Clear();
                    if (userAnswer == problem)
                    {
                        Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else
                    numberOne = random.Next(1, 16);
            }
            stopwatch.Stop();
            Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Clear();
        }
        public void MultiplicationTableMixed()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Clear();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (totalQuestions != 20)
            {
                bool isUserAnswer = false;
                int userAnswer;
                Random random = new Random();
                int numberOne = random.Next(0, 9);
                int numberTwo = random.Next(0, 9);
                int problem = numberOne * numberTwo;

                Console.WriteLine("Antal frågor: " + totalQuestions);
                Console.WriteLine("Antal rätt: " + rightAnswers);
                Console.WriteLine("Antal fel: " + wrongAnswers);
                Console.WriteLine("");
                Console.WriteLine(numberOne + " * " + numberTwo);
                isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                Clear();
                if (userAnswer == problem)
                {
                    Clear();
                    rightAnswers++;
                    totalQuestions++;
                }
                else
                {
                    Clear();
                    wrongAnswers++;
                    totalQuestions++;
                }
            }
            stopwatch.Stop();
            Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Clear();
        }



        private GameMode ParseUserGameChoice()
        {
            Console.WriteLine("Välj vilket räknesätt du vill jobba med");
            Console.WriteLine("genom att skriva siffran för ditt val.");
            Console.WriteLine("Tryck sedan ENTER!");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplikation");
            Console.WriteLine("");
            Console.WriteLine("Ditt val:");

            int.TryParse(Console.ReadLine(), out int parsedValue);
            return (GameMode)parsedValue;
        }
        private IMode ParseUserMultiplicationTableChoice()
        {
            int multiplicationLevelChosen = -1;

            Clear();
            Console.WriteLine("Välj vilken multiplikationstabell du vill arbeta med");
            Console.WriteLine("genom att välja en siffra mellan 1-9 och sedan trycka ENTER.");
            Console.WriteLine("Vill du spela blandat skall du trycka på siffran NOLL (0) och sedan ENTER");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Ditt val (0-9):");
            } while (!int.TryParse(Console.ReadLine(), out multiplicationLevelChosen));
            Clear();

            if (multiplicationLevelChosen == 0)
            {
                return new MultiplicationMixedMode();
            }
            else
            {
                return new MultiplicationMode();
            }

            ParseUserMultiplicationTableChoice();
        }

        private void Clear()
        {
            Console.Clear();
        }
    }
}
