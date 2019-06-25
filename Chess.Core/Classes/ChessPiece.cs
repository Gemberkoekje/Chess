using Chess.Core.Enums;
using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Classes
{
    internal class ChessPiece : IChessPiece
    {
        private IMoveResolver _moveResolver;
        private PieceColor _color;
        private PieceSymbol _symbol;
        private int _rank;
        private int _fileNr;
        private string  _file {
            get
            {
                switch(_fileNr)
                {
                    case 1:
                        return "a";
                    case 2:
                        return "b";
                    case 3:
                        return "c";
                    case 4:
                        return "d";
                    case 5:
                        return "e";
                    case 6:
                        return "f";
                    case 7:
                        return "g";
                    case 8:
                        return "h";
                    default:
                        throw new IndexOutOfRangeException("_fileNr is not in range");
                }
            }
            set
            {
                switch(value)
                {
                    case "a":
                        _fileNr = 1;
                        break;
                    case "b":
                        _fileNr = 2;
                        break;
                    case "c":
                        _fileNr = 3;
                        break;
                    case "d":
                        _fileNr = 4;
                        break;
                    case "e":
                        _fileNr = 5;
                        break;
                    case "f":
                        _fileNr = 6;
                        break;
                    case "g":
                        _fileNr = 7;
                        break;
                    case "h":
                        _fileNr = 8;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("value is not in range");
                }
            }
        }

        internal ChessPiece(PieceColor color, PieceSymbol symbol, string rankandfile, IMoveResolver moveResolver)
        {
            _color = color;
            _symbol = symbol;
            _moveResolver = moveResolver;

            SetRankAndFile(rankandfile);
        }

        private void SetRankAndFile(string rankandfile)
        {
            if (rankandfile == null)
                throw new ArgumentNullException("rankandfile cannot be empty.");
            if (rankandfile.Length != 2)
                throw new ArgumentException("rankandfile needs a rank and a file, e.g. 'a1'.");

            var file = rankandfile[0].ToString();
            var rankstring = rankandfile[1].ToString();

            var rank = int.Parse(rankstring);

            _rank = rank;
            _file = file;
        }

        internal List<string> GetPossibleMoves(List<ChessPiece> board)
        {
            return _moveResolver.GetPossibleMoves(this, board);
        }
        internal void Move(string destination)
        {
            SetRankAndFile(destination);
        }
        public PieceColor GetColor()
        {
            return _color;
        }

        public PieceSymbol GetSymbol()
        {
            return _symbol;
        }

        public string GetFile()
        {
            return _file;
        }

        public int GetFileNr()
        {
            return _fileNr;
        }

        public int GetRank()
        {
            return _rank;
        }

        public string GetRankAndFile()
        {
            return string.Format("{0}{1}",_file,_rank);
        }

    }
}
