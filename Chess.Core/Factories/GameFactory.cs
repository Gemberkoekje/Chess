using Chess.Core.Classes;
using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Factories
{
    public static class GameFactory
    {
        public static IGame NewGame()
        {
            var gameSetup = new DefaultGameSetup();
            var retval = new Game(gameSetup);
            return retval;
        }
        public static IGame NewCustomGame(string board)
        {
            var gameSetup = new CustomGameSetup(board);
            var retval = new Game(gameSetup);
            return retval;
        }
    }
}
