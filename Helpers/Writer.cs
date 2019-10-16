using System;

namespace MathGame.Helpers
{
    public static class Writer
    {
        public static void Clear()
        {
            Console.Clear();
        }

        internal static void Line(string input)
        {
            Console.WriteLine(input);
        }

        internal static void Line()
        {
            Line("");
        }
    }
}