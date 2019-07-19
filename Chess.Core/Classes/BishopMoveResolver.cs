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
            for (int squaresout = 1; squaresout <= Math.Min(8 - me.GetRank(), 8 - me.GetFileNr()); squaresout++)
            {
                int file = me.GetFileNr() + squaresout;
                int rank = me.GetRank() + squaresout;
                char targetfile = (char)(((int)'a') + (file - 1));

                retval.Add(string.Format("{0}{1}",targetfile,rank));
            }
            for (int squaresout = 1; squaresout <= Math.Min(8 - me.GetRank(), me.GetFileNr() - 1); squaresout++)
            {
                int file = me.GetFileNr() - squaresout;
                int rank = me.GetRank() + squaresout;
                char targetfile = (char)(((int)'a') + (file - 1));

                retval.Add(string.Format("{0}{1}", targetfile, rank));
            }
            for (int squaresout = 1; squaresout <= Math.Min(me.GetRank() - 1, me.GetFileNr() - 1); squaresout++)
            {
                int file = me.GetFileNr() - squaresout;
                int rank = me.GetRank() - squaresout;
                char targetfile = (char)(((int)'a') + (file - 1));

                retval.Add(string.Format("{0}{1}", targetfile, rank));
            }
            for (int squaresout = 1; squaresout <= Math.Min(me.GetRank() - 1, 8 - me.GetFileNr()); squaresout++)
            {
                int file = me.GetFileNr() + squaresout;
                int rank = me.GetRank() - squaresout;
                char targetfile = (char)(((int)'a') + (file - 1));

                retval.Add(string.Format("{0}{1}", targetfile, rank));
            }
            return retval;
        }
    }
}
