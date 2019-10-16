using System;

namespace MathGame.Helpers
{
    public class UserInputParser
    {
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

            Writer.Clear();
            Writer.Line("Välj vilken multiplikationstabell du vill arbeta med");
            Writer.Line("Välj vilken multiplikationstabell du vill arbeta med");
            Writer.Line("genom att välja en siffra mellan 1-9 och sedan trycka ENTER.");
            Writer.Line("Vill du spela blandat skall du trycka på siffran NOLL (0) och sedan ENTER");
            Writer.Line();

            do
            {
                Console.WriteLine("Ditt val (0-9):");
            } while (!int.TryParse(Console.ReadLine(), out multiplicationLevelChosen));
            Writer.Clear();

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
    }
}
