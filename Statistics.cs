using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MathGame
{
    class Statistics
    {
        public Stopwatch stopwatch = new Stopwatch();
        public int totalQuestions = 0;
        public int rightAnswers = 0;
        public int wrongAnswers = 0;
        

        public void FinalStats()
        {
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
