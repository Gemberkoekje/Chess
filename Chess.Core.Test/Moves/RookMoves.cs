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
    public class RookMoves
    {
        [TestMethod]
        public void RookCanMoveHorizontally()
        {
            for (int x = 1; x <= 8; x++)
            {
                if (x == 5)
                    continue;
                //Arrange
                string testString = "WRb5";
                var game = GameFactory.NewCustomGame(testString);

                //Act
                var updatedgame = game.Move("b5", string.Format("b{0}",x));

                //Assert
                var rook = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Rook && p.GetRank() == x && p.GetFile() == "b");
                Assert.IsNotNull(rook);
            }
        }
        [TestMethod]
        public void RookCanMoveVertically()
        {
            for (int y = 1; y <= 8; y++)
            {
                if (y == 4)
                    continue;

                char t = (char)(((int)'a') + (y-1));

                //Arrange
                string testString = "WRd5";
                var game = GameFactory.NewCustomGame(testString);

                //Act
                var updatedgame = game.Move("d5", string.Format("{0}5", t));

                //Assert
                var rook = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Rook && p.GetRank() == 5 && p.GetFile() == string.Format("{0}", t));
                Assert.IsNotNull(rook);
            }
        }
        [TestMethod]
        public void RookCannotMoveDiagonally()
        {
                //Arrange
                string testString = "WRd5";
                var game = GameFactory.NewCustomGame(testString);

            try
            {
                //Act
                var updatedgame = game.Move("d5", "f3");

            }
            catch (Exception e)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");

        }
        [TestMethod]
        public void RookCannotMoveThroughAllies()
        {
            //Arrange
            string testString = "WRd5WQd7";
            var game = GameFactory.NewCustomGame(testString);

            try
            {
                //Act
                var updatedgame = game.Move("d5", "d8");

            }
            catch (Exception e)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");

        }
        [TestMethod]
        public void RookCannotMoveThroughEnemies()
        {
            //Arrange
            string testString = "WRd5BQd3";
            var game = GameFactory.NewCustomGame(testString);

            try
            {
                //Act
                var updatedgame = game.Move("d5", "d2");

            }
            catch (Exception e)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");

        }
        [TestMethod]
        public void RookCanCaptureEnemies()
        {
            //Arrange
            string testString = "WRd5BQd2";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("d5", "d2");


            //Assert
            var rook = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Rook && p.GetRank() == 2 && p.GetFile() == "d");
            Assert.IsNotNull(rook);

        }
    }
}
