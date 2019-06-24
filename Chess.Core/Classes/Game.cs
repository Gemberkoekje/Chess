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
            CheckDuplications(_board);
        }

        private void CheckDuplications(List<IChessPiece> board)
        {
            List<string> uniqueLocations = new List<string>();
            foreach (var piece in board)
            {
                var rankandfile = string.Format("{0}{1}", piece.GetFile(), piece.GetRank());
                if (uniqueLocations.Exists(l => l == rankandfile))
                    throw new Exception(string.Format("You cannot place more than one piece on a square at any time. Duplicate on {0}",rankandfile));
                uniqueLocations.Add(rankandfile);
            }
        }

        public List<IChessPiece> GetBoard()
        {
            var retval = new List<IChessPiece>();
            retval.AddRange(_board);
            return retval;
        }
    }
}
