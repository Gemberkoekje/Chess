using Chess.Core.Enums;
using Chess.Core.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Test.Moves
{
    [TestClass]
    public class BishopMoves
    {
        [TestMethod]
        public void BishopCanMoveDiagonally1()
        {
            for (var t = 4; t < 8; t++)
            {
                if (t == 6)
                    continue;
                var targetrank = t;
                var targetfilenr = t-3;
                char targetfile = (char)(((int)'a') + (targetfilenr - 1));
                //Arrange
                string testString = "WBc6";
                var game = GameFactory.NewCustomGame(testString);

                //Act
                var updatedgame = game.Move("c6", string.Format("{0}{1}",targetfile,targetrank));

                //Assert
                var king = game.GetBoard().Single(p =>
                    p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Bishop && p.GetRank() == targetrank &&
                    p.GetFile() == string.Format("{0}",targetfile));
                Assert.IsNotNull(king);
            }
        }
        [TestMethod]
        public void BishopCanMoveDiagonally2()
        {
            for (var t = 1; t < 8; t++)
            {
                if (t == 6)
                    continue;
                var targetrank = t;
                var targetfilenr = 8 - t;
                char targetfile = (char)(((int)'a') + (targetfilenr - 1));
                //Arrange
                string testString = "WBc6";
                var game = GameFactory.NewCustomGame(testString);

                //Act
                var updatedgame = game.Move("c6", string.Format("{0}{1}", targetfile, targetrank));

                //Assert
                var king = game.GetBoard().Single(p =>
                    p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Bishop && p.GetRank() == targetrank &&
                    p.GetFile() == string.Format("{0}", targetfile));
                Assert.IsNotNull(king);
            }
        }
    }
}
