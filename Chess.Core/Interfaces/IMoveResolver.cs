using Chess.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Interfaces
{
    interface IMoveResolver
    {
        List<string> GetPossibleMoves(ChessPiece me, List<ChessPiece> board);
    }
}
