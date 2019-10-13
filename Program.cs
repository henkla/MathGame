using System;
using System.Diagnostics;

namespace Matematikspelet
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Välkommen till matematikspelet");
            Console.WriteLine("Tryck på ENTER när du vill börja!");
            Console.ReadKey();
            Console.Clear();

            GameChoice();

            Main(args);
        }

        static public void GameChoice()
        {
            bool isPlayerChoice = false;
            int playerChoice = 0;

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
            Console.WriteLine("Ditt val");
            isPlayerChoice = int.TryParse(Console.ReadLine(), out playerChoice);
            Console.Clear();
            if (playerChoice == 1)
            {
                Addition();
                Console.Clear();
            }
            else if (playerChoice == 2)
            {
                Subtraction();
                Console.Clear();
            }
            else if (playerChoice == 3)
            {
                Division();
                Console.Clear();
            }
            else if (playerChoice == 4)
            {
                MultiplicationTableChoice();
                Console.Clear();
            }
            else
            {
                GameChoice();
            }
        }

        static public void Addition()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

            Stopwatch stopwatch = new Stopwatch();
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
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else
                    numberOne = random.Next(1, 21);
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void Subtraction()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else
                    numberOne = random.Next(1, 21);
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void Division()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else
                    numberOne = random.Next(1, 16);
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void MultiplicationTableChoice()
        {
            bool isMultiChoice = false;
            int multiPlayerChoice = 0;

            Console.WriteLine("Välj vilken multiplikationstabell du vill arbeta med");
            Console.WriteLine("genom att välja en siffra mellan 1-9 och sedan trycka ENTER.");
            Console.WriteLine("Vill du spela blandat skall du trycka på siffran NOLL (0) och sedan ENTER");
            Console.WriteLine("");
            Console.WriteLine("Ditt val:");
            isMultiChoice = int.TryParse(Console.ReadLine(), out multiPlayerChoice);
            Console.Clear();
            if (multiPlayerChoice == 0)
            {
                MultiplicationTableMixed();
                Console.Clear();
            }
            else if (multiPlayerChoice == 1)
            {
                MultiplicationTableOne();
                Console.Clear();
            }
            else if (multiPlayerChoice == 2)
            {
                MultiplicationTableTwo();
                Console.Clear();
            }
            else if (multiPlayerChoice == 3)
            {
                MultiplicationTableThree();
                Console.Clear();
            }
            else if (multiPlayerChoice == 4)
            {
                MultiplicationTableFour();
                Console.Clear();
            }
            else if (multiPlayerChoice == 5)
            {
                MultiplicationTableFive();
                Console.Clear();
            }
            else if (multiPlayerChoice == 6)
            {
                MultiplicationTableSix();
                Console.Clear();
            }
            else if (multiPlayerChoice == 7)
            {
                MultiplicationTableSeven();
                Console.Clear();
            }
            else if (multiPlayerChoice == 8)
            {
                MultiplicationTableEight();
                Console.Clear();
            }
            else if (multiPlayerChoice == 9)
            {
                MultiplicationTableNine();
                Console.Clear();
            }
            else
            {
                MultiplicationTableChoice();
            }

        }

        static public void MultiplicationTableOne()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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

                if (numberOne == 1)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else if (numberTwo == 1)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void MultiplicationTableTwo()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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

                if (numberOne == 2)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else if (numberTwo == 2)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void MultiplicationTableThree()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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

                if (numberOne == 3)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else if (numberTwo == 3)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void MultiplicationTableFour()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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

                if (numberOne == 4)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else if (numberTwo == 4)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void MultiplicationTableFive()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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

                if (numberOne == 5)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else if (numberTwo == 5)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void MultiplicationTableSix()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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

                if (numberOne == 6)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else if (numberTwo == 6)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void MultiplicationTableSeven()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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

                if (numberOne == 7)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else if (numberTwo == 7)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void MultiplicationTableEight()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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

                if (numberOne == 8)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else if (numberTwo == 8)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void MultiplicationTableNine()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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

                if (numberOne == 9)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
                else if (numberTwo == 9)
                {
                    Console.WriteLine("Antal frågor: " + totalQuestions);
                    Console.WriteLine("Antal rätt: " + rightAnswers);
                    Console.WriteLine("Antal fel: " + wrongAnswers);
                    Console.WriteLine("");
                    Console.WriteLine(numberOne + " * " + numberTwo);
                    isUserAnswer = int.TryParse(Console.ReadLine(), out userAnswer);
                    Console.Clear();
                    if (userAnswer == problem)
                    {
                        Console.Clear();
                        rightAnswers++;
                        totalQuestions++;
                    }
                    else
                    {
                        Console.Clear();
                        wrongAnswers++;
                        totalQuestions++;
                    }
                }
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
        static public void MultiplicationTableMixed()
        {
            int rightAnswers = 0;
            int wrongAnswers = 0;
            int totalQuestions = 0;

            Console.WriteLine("När du trycker på ENTER startar tidtagningen och första talet visas!");
            Console.ReadKey();
            Console.Clear();

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
                Console.Clear();
                if (userAnswer == problem)
                {
                    Console.Clear();
                    rightAnswers++;
                    totalQuestions++;
                }
                else
                {
                    Console.Clear();
                    wrongAnswers++;
                    totalQuestions++;
                }
            }
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Bra jobbat! Nedan ser du dina resultat");
            Console.WriteLine();
            Console.WriteLine("Antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + rightAnswers);
            Console.WriteLine("Antal fel: " + wrongAnswers);
            Console.WriteLine("Tid: {0:mm\\:ss}", stopwatch.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("Vill du spela igen skall du trycka på ENTER!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
