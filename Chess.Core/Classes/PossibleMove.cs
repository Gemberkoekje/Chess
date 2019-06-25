using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Classes
{
    class PossibleMove
    {
        internal PossibleMove(string source, string destination)
        {
            Source = source;
            Destination = destination;
        }
        internal string Source { get; private set; }
        internal string Destination { get; private set; }
    }
}
