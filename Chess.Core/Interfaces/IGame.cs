using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Interfaces
{
    public interface IGame
    {
        List<IChessPiece> GetBoard();

        IGame Move(string source, string destination);
    }
}
