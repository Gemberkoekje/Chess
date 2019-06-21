using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Classes
{
    internal class Game : IGame
    {
        private List<IChessPiece> _board;

        internal Game(IGameSetup gameSetup)
        {
            _board = gameSetup.GetSetup();
            
        }

        public List<IChessPiece> GetBoard()
        {
            var retval = new List<IChessPiece>();
            retval.AddRange(_board);
            return retval;
        }
    }
}
