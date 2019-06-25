using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Classes
{
    class KingMoveResolver : IMoveResolver
    {
        public List<string> GetPossibleMoves(ChessPiece me, List<ChessPiece> board)
        {
            var retval = new List<string>();
            var myrank = me.GetRank();
            var myfile = me.GetFileNr();

            AddMoveIfValid(me, board, retval, myrank + 1, myfile - 1);
            AddMoveIfValid(me, board, retval, myrank, myfile - 1);
            AddMoveIfValid(me, board, retval, myrank - 1, myfile - 1);
            AddMoveIfValid(me, board, retval, myrank + 1, myfile);
            AddMoveIfValid(me, board, retval, myrank - 1, myfile);
            AddMoveIfValid(me, board, retval, myrank + 1, myfile + 1);
            AddMoveIfValid(me, board, retval, myrank, myfile + 1);
            AddMoveIfValid(me, board, retval, myrank - 1, myfile + 1);

            return retval;
        }

        private static void AddMoveIfValid(ChessPiece me, List<ChessPiece> board, List<string> retval, int targetrank, int targetfile)
        {
            if (targetrank < 1 || targetrank > 8 || targetfile < 1 || targetfile > 8)
                return;
            var targetpiece = board.FirstOrDefault(p => p.GetRank() == targetrank && p.GetFileNr() == targetfile);
            if (targetpiece == null || targetpiece.GetColor() != me.GetColor())
            {
                string targetfileletter = GetFileLetter(targetfile);
                retval.Add(string.Format("{0}{1}", targetfileletter, targetrank));
            }
        }

        private static string GetFileLetter(int targetfile)
        {
            return targetfile == 1 ? "a" :
                                targetfile == 2 ? "b" :
                                targetfile == 3 ? "c" :
                                targetfile == 4 ? "d" :
                                targetfile == 5 ? "e" :
                                targetfile == 6 ? "f" :
                                targetfile == 7 ? "g" :
                                targetfile == 8 ? "h" :
                                "";
        }
    }
}
