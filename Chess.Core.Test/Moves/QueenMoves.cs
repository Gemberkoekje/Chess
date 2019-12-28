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
    public class QueenMoves
    {
        public string[] validMoves = { "b1", "d1", "f1", "c2", "d2", "e2", "a3", "b3", "c3", "e3", "f3", "g3", "h3", "c4", "d4", "e4", "b5", "d5", "f5", "a6", "d6", "g6", "d7", "h7", "d8" };

        [TestMethod]
        public void QueenCanMoveToValidSpaces()
        {

            foreach (var move in validMoves)
            {
                //Arrange
                string testString = "WQd3";
                var game = GameFactory.NewCustomGame(testString);

                //Act
                var updatedgame = game.Move("d3", move);
                var targetfile = move[0];
                var targetrank = int.Parse(string.Format("{0}",move[1]));
                //Assert
                var queen = game.GetBoard().Single(p =>
                    p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Queen && p.GetRank() == targetrank &&
                    p.GetFile() == string.Format("{0}",targetfile));
                Assert.IsNotNull(queen);
            }
        }

        [TestMethod]
        public void QueenCannotMoveAnywhereElse()
        {
            //Arrange
            string testString = "WQd3";
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
                        var updatedgame = game.Move("d3", target);
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
