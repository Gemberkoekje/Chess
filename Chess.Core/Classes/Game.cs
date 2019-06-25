using Chess.Core.Enums;
using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Core.Classes
{
    internal class Game : IGame
    {
        private List<ChessPiece> _board;
        private PieceColor _currentPlayer;
        private List<PossibleMove> _possibleMoves;
        internal Game(IGameSetup gameSetup)
        {
            _board = gameSetup.GetSetup();
            CheckDuplications(_board);
            _currentPlayer = PieceColor.White;
            _possibleMoves = GetPossibleMoves(_board, _currentPlayer);
        }

        private void CheckDuplications(List<ChessPiece> board)
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
        private List<PossibleMove> GetPossibleMoves(List<ChessPiece> board, PieceColor currentPlayer)
        {
            var retval = new List<PossibleMove>();

            foreach(var piece in board.Where(p => p.GetColor() == currentPlayer))
            {
                var possibleMovesForThisPiece = piece.GetPossibleMoves(board);
                foreach(var possiblemove in possibleMovesForThisPiece)
                {
                    retval.Add(new PossibleMove(string.Format("{0}{1}", piece.GetFile(), piece.GetRank()),possiblemove));
                }
            }

            return retval;
        }

        public List<IChessPiece> GetBoard()
        {
            var retval = new List<IChessPiece>();
            retval.AddRange(_board);
            return retval;
        }

        public IGame Move(string source, string destination)
        {
            CheckMoveValid(source, destination);
            var newgame = (Game)this.MemberwiseClone();
            newgame.ExecuteMove(source, destination);
            return newgame;
        }

        private void CheckMoveValid(string source, string destination)
        {
            var possiblemove = _possibleMoves.FirstOrDefault(m => m.Source == source && m.Destination == destination);
            if (possiblemove == null)
                throw new ArgumentException("Move is not valid!");
        }

        private void ExecuteMove(string source, string destination)
        {
            var targetPiece = _board.FirstOrDefault(p => p.GetRankAndFile() == destination);
            if(targetPiece != null)
            {
                _board.Remove(targetPiece);
            }

            var piece = _board.Single(p => p.GetRankAndFile() == source);
            piece.Move(destination);
        }
    }
}
