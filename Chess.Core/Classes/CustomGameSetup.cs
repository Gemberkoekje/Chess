using Chess.Core.Enums;
using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Classes
{
    class CustomGameSetup : IGameSetup
    {
        private List<ChessPiece> _savedGameSetup;
        internal CustomGameSetup(string desiredSetup)
        {
            _savedGameSetup = new List<ChessPiece>();
            var piecelist = Split(desiredSetup, 4);
            foreach (var piece in piecelist)
            {
                var pieceColor = piece[0].ToString();
                var pieceSymbol = piece[1].ToString();

                var piecefile = piece[2].ToString();
                var piecerank = piece[3].ToString();

                var color = pieceColor == "B" ? PieceColor.Black :
                    pieceColor == "W" ? PieceColor.White :
                    throw new ArgumentException(string.Format("color {0} isn't B or W", pieceColor));
                var symbol = pieceSymbol == "K" ? PieceSymbol.King :
                    pieceSymbol == "B" ? PieceSymbol.Bishop :
                    pieceSymbol == "Q" ? PieceSymbol.Queen :
                    pieceSymbol == "N" ? PieceSymbol.Knight :
                    pieceSymbol == "R" ? PieceSymbol.Rook :
                    pieceSymbol == " " ? PieceSymbol.Pawn :
                    throw new ArgumentException(string.Format("symbol {0} isn't K, B, Q, N, R or  ", pieceSymbol));

                var resolver = pieceSymbol == "K" ? (IMoveResolver)new KingMoveResolver() :
                    pieceSymbol == "B" ? (IMoveResolver)new BishopMoveResolver() :
                    pieceSymbol == "Q" ? (IMoveResolver)new QueenMoveResolver() :
                    pieceSymbol == "N" ? (IMoveResolver)new KnightMoveResolver() :
                    pieceSymbol == "R" ? (IMoveResolver)new RookMoveResolver() :
                    pieceSymbol == " " ? (IMoveResolver)new PawnMoveResolver() :
                    throw new ArgumentException(string.Format("symbol {0} isn't K, B, Q, N, R or  ", pieceSymbol));


                if (
                    piecefile != "a" &&
                    piecefile != "b" &&
                    piecefile != "c" &&
                    piecefile != "d" &&
                    piecefile != "e" &&
                    piecefile != "f" &&
                    piecefile != "g" &&
                    piecefile != "h"
                    )
                    throw new ArgumentException(string.Format("file {0} isn't a, b, c, d, e, f, g or h", piecefile));

                int rank;
                if(!int.TryParse(piecerank, out rank))
                    throw new ArgumentException(string.Format("rank {0} isn't a number", piecerank));

                if(rank < 1 || rank > 8)
                    throw new ArgumentException(string.Format("rank {0} isn't a number between 1 and 8", piecerank));
                _savedGameSetup.Add(new ChessPiece(color, symbol, String.Format("{0}{1}", piecefile, rank), resolver));
            }
        }
        public List<ChessPiece> GetSetup()
        {
            return _savedGameSetup;
        }
        static IEnumerable<string> Split(string str, int chunkSize)
        {
            if (str == null)
                return new List<string>();
            if (str.Length % chunkSize != 0)
            {
                throw new ArgumentException(String.Format("{0}'s length can't be divided by {1}", str, chunkSize));
            }

            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
