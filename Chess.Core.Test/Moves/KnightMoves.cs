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
    public class KnightMoves
    {
        public string[] validMoves = { "d4", "f4", "c5", "g5", "d7", "f7", "c8", "f8"};

        [TestMethod]
        public void KnightCanMoveToValidSpaces()
        {

            foreach (var move in validMoves)
            {
                //Arrange
                string testString = "WNe6";
                var game = GameFactory.NewCustomGame(testString);

                //Act
                var updatedgame = game.Move("e6", move);
                var targetfile = move[0];
                var targetrank = int.Parse(string.Format("{0}",move[1]));
                //Assert
                var queen = game.GetBoard().Single(p =>
                    p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Knight && p.GetRank() == targetrank &&
                    p.GetFile() == string.Format("{0}",targetfile));
                Assert.IsNotNull(queen);
            }
        }

        [TestMethod]
        public void KnightCannotMoveAnywhereElse()
        {
            //Arrange
            string testString = "WNe6";
            for (var r = 1; r <= 8; r++)
            {
                for (var f = 1; f <= 8; f++)
                {
                    var game = GameFactory.NewCustomGame(testString);
                    var targetrank = r;
                    var targetfilenr = f;
                    char targetfile = (char)(((int)'a') + (targetfilenr - 1));

                    var target = string.Format("{0}{1}",targetfile,targetrank);

                    if (validMoves.Contains(target))
                        continue;

                    try
                    {
                        //Act
                        var updatedgame = game.Move("e6", target);
                    }
                    catch (Exception e)
                    {
                        continue;
                    }

                    //Assert
                    Assert.Fail("No exception thrown");
                }
            }
        }
    }
}
