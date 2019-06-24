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

            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Rook, "a8"));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Rook, "h8"));

            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Knight, "b1"));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Knight, "g1"));

            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Knight, "b8"));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Knight, "g8"));

            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Bishop, "c1"));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Bishop, "f1"));

            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Bishop, "c8"));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Bishop, "f8"));

            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Queen, "d1"));
            
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Queen, "d8"));

            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.King, "e1"));

            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.King, "e8"));

            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "a2"));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "b2"));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "c2"));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "d2"));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "e2"));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "f2"));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "g2"));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "h2"));

            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "a7"));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "b7"));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "c7"));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "d7"));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "e7"));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "f7"));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "g7"));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "h7"));

            return retval;
        }
    }
}
