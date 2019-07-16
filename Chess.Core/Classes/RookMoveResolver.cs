using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Classes
{
    class RookMoveResolver : IMoveResolver
    {
        public List<string> GetPossibleMoves(ChessPiece me, List<ChessPiece> board)
        {
            var retval = new List<string>();
            var horpos = me.GetRank();
            var verpos = me.GetFileNr();

            for(var x = horpos + 1; x <= 8; x++)
            {
                var pieceonpos = board.FirstOrDefault(p => p.GetRank() == x && p.GetFile() == me.GetFile());
                if (pieceonpos != null && pieceonpos.GetColor() == me.GetColor())
                    break;

                retval.Add(string.Format("{0}{1}",me.GetFile(), x));
                if (pieceonpos != null && pieceonpos.GetColor() != me.GetColor())
                    break;
            }
            for (var x = horpos - 1; x > 0; x--)
            {
                var pieceonpos = board.FirstOrDefault(p => p.GetRank() == x && p.GetFile() == me.GetFile());

                if (pieceonpos != null && pieceonpos.GetColor() == me.GetColor())
                    break;

                retval.Add(string.Format("{0}{1}", me.GetFile(), x));

                if (pieceonpos != null && pieceonpos.GetColor() != me.GetColor())
                    break;
            }
            for (var y = verpos + 1; y <= 8; y++)
            {
                var t = (char)(((int)'a') + (y - 1));
                var pieceonpos = board.FirstOrDefault(p => p.GetRank() == me.GetRank() && p.GetFile() == string.Format("{0}",t));

                if (pieceonpos != null && pieceonpos.GetColor() == me.GetColor())
                    break;

                retval.Add(string.Format("{0}{1}", t, me.GetRank()));
                if (pieceonpos != null && pieceonpos.GetColor() != me.GetColor())
                    break;
            }
            for (var y = verpos - 1; y > 0; y--)
            {
                var t = (char)(((int)'a') + (y - 1));
                var pieceonpos = board.FirstOrDefault(p => p.GetRank() == me.GetRank() && p.GetFile() == string.Format("{0}", t));

                if (pieceonpos != null && pieceonpos.GetColor() == me.GetColor())
                    break;

                retval.Add(string.Format("{0}{1}", t, me.GetRank()));
                if (pieceonpos != null && pieceonpos.GetColor() != me.GetColor())
                    break;
            }

            return retval;
        }
    }
}
