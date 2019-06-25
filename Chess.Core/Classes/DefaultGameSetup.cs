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
        public List<ChessPiece> GetSetup()
        {
            var retval = new List<ChessPiece>();

            //The rooks are placed on the outside corners, right and left edge.
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Rook, "a1", new RookMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Rook, "h1", new RookMoveResolver()));

            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Rook, "a8", new RookMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Rook, "h8", new RookMoveResolver()));

            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Knight, "b1", new KnightMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Knight, "g1", new KnightMoveResolver()));

            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Knight, "b8", new KnightMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Knight, "g8", new KnightMoveResolver()));

            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Bishop, "c1", new BishopMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Bishop, "f1", new BishopMoveResolver()));

            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Bishop, "c8", new BishopMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Bishop, "f8", new BishopMoveResolver()));

            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Queen, "d1", new QueenMoveResolver()));
            
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Queen, "d8", new QueenMoveResolver()));

            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.King, "e1", new KingMoveResolver()));

            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.King, "e8", new KingMoveResolver()));

            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "a2", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "b2", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "c2", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "d2", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "e2", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "f2", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "g2", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.White, PieceSymbol.Pawn, "h2", new PawnMoveResolver()));

            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "a7", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "b7", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "c7", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "d7", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "e7", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "f7", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "g7", new PawnMoveResolver()));
            retval.Add(new ChessPiece(PieceColor.Black, PieceSymbol.Pawn, "h7", new PawnMoveResolver()));

            return retval;
        }
    }
}
