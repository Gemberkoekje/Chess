using Chess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Interfaces
{
    public interface IChessPiece
    {
        PieceColor GetColor();
        PieceSymbol GetSymbol();

        int GetRank();
        string GetFile();
    }
}
