using MathGame;
using System;
using System.Diagnostics;

namespace Matematikspelet
{
    class Program
    {
        private static IEngine _gameEngine;

        static public void Main(string[] args)
        {
            _gameEngine = new GameEngine();
            _gameEngine.Execute();
        }
    }
}
