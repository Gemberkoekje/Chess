using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Classes
{
    class BishopMoveResolver : IMoveResolver
    {
        public List<string> GetPossibleMoves(ChessPiece me, List<ChessPiece> board)
        {
            var retval = new List<string>();

            return retval;
        }
    }
}
