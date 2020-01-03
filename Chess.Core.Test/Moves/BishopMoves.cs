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
            for (var t = 4; t <= 8; t++)
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
            for (var t = 1; t <= 8; t++)
            {
                if (t == 6)
                    continue;
                var targetrank = t;
                var targetfilenr = 9 - t;
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
        [TestMethod]
        public void BishopCannotMoveAnywhereElse()
        {
            string[] validMoves = { "a4", "b5", "d7", "e8", "a8", "b7", "c6", "d5", "e4", "f3", "g2", "h1" };
            //Arrange
            string testString = "WBc6";
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
                        var updatedgame = game.Move("c6", target);
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
        [TestMethod]
        public void BishopCanCaptureAnotherPlayersPiece()
        {
            var game = GameFactory.NewCustomGame("WBc6B b7");

            //Act
            var updatedgame = game.Move("c6", "b7");

            //Assert
            var count = game.GetBoard().Count;
            Assert.AreEqual(1, count);
            var bishop = game.GetBoard().Single(p =>
                p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Bishop && p.GetRank() == 7 &&
                p.GetFile() == "b");
            Assert.IsNotNull(bishop);
        }
        [TestMethod]
        public void BishopCannotMoveThroughAnotherPlayersPiece()
        {
            var game = GameFactory.NewCustomGame("WBc6B b7");

            try
            {
                //Act
                var updatedgame = game.Move("c6", "a8");
            }
            catch (Exception e)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");
        }
        [TestMethod]
        public void BishopCannotMoveIntoSamePlayersPiece()
        {
            var game = GameFactory.NewCustomGame("WBc6W b7");

            try
            {
                //Act
                var updatedgame = game.Move("c6", "b7");
            }
            catch (Exception e)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");
        }
        [TestMethod]
        public void BishopCannotMoveThroughSamePlayersPiece()
        {
            var game = GameFactory.NewCustomGame("WBc6W b7");

            try
            {
                //Act
                var updatedgame = game.Move("c6", "a8");
            }
            catch (Exception e)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");
        }
    }
}
