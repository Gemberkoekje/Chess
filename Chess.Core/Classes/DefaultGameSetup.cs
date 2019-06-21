using Chess.Core.Enums;
using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Classes
{
    class DefaultGameSetup : IGameSetup
    {
        public List<IChessPiece> GetSetup()
        {
            var retval = new List<IChessPiece>();

            //The rooks are placed on the outside corners, right and left edge.
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Rook, "a1"));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Rook, "h1"));

            return retval;
        }
    }
}
