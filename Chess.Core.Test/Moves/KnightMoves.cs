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
                var knight = game.GetBoard().Single(p =>
                    p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Knight && p.GetRank() == targetrank &&
                    p.GetFile() == string.Format("{0}",targetfile));
                Assert.IsNotNull(knight);
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
                    catch (Exception)
                    {
                        continue;
                    }

                    //Assert
                    Assert.Fail("No exception thrown");
                }
            }
        }

        [TestMethod]
        public void KnightCanJumpOverFriendlyUnits()
        {

                //Arrange
                string testString = "WNe6WBe5WBf5";
                var game = GameFactory.NewCustomGame(testString);

                //Act
                var updatedgame = game.Move("e6", "f4");
                //Assert
                var knight = updatedgame.GetBoard().Single(p =>
                    p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Knight && p.GetRank() == 4 &&
                    p.GetFile() == "f");
                Assert.IsNotNull(knight);
        }

        [TestMethod]
        public void KnightCanJumpOverRivalUnits()
        {

            //Arrange
            string testString = "WNe6BBe5BBf5";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("e6", "f4");
            //Assert
            var knight = updatedgame.GetBoard().Single(p =>
                p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Knight && p.GetRank() == 4 &&
                p.GetFile() == "f");
            Assert.IsNotNull(knight);
        }
        [TestMethod]
        public void KnightCanCaptureRivalUnits()
        {

            //Arrange
            string testString = "WNe6BBf4";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("e6", "f4");
            //Assert
            var knight = updatedgame.GetBoard().Single(p =>
                p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Knight && p.GetRank() == 4 &&
                p.GetFile() == "f");
            Assert.IsNotNull(knight);
            var count = updatedgame.GetBoard().Count;
            Assert.AreEqual(1, count);
        }
    }
}
