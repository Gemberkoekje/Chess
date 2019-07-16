using System;
using Chess.Core.Enums;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess.Core.Factories;

namespace Chess.Core.Test.Moves
{
    [TestClass]
    public class KingMoves
    {
        [TestMethod]
        public void KingCanMoveOneSquareForward()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("c6", "c7");

            //Assert
            var king = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King && p.GetRank() == 7 && p.GetFile() == "c");
            Assert.IsNotNull(king);

        }
        [TestMethod]
        public void KingCanMoveOneSquareBackward()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("c6", "c5");

            //Assert
            var king = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King && p.GetRank() == 5 && p.GetFile() == "c");
            Assert.IsNotNull(king);

        }
        [TestMethod]
        public void KingCanMoveOneSquareLeft()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("c6", "b6");

            //Assert
            var king = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King && p.GetRank() == 6 && p.GetFile() == "b");
            Assert.IsNotNull(king);

        }
        [TestMethod]
        public void KingCanMoveOneSquareRight()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("c6", "d6");

            //Assert
            var king = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King && p.GetRank() == 6 && p.GetFile() == "d");
            Assert.IsNotNull(king);

        }
        [TestMethod]
        public void KingCanMoveOneSquareForwardAndLeft()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("c6", "b7");

            //Assert
            var king = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King && p.GetRank() == 7 && p.GetFile() == "b");
            Assert.IsNotNull(king);

        }
        [TestMethod]
        public void KingCanMoveOneSquareForwardAndRight()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("c6", "d7");

            //Assert
            var king = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King && p.GetRank() == 7 && p.GetFile() == "d");
            Assert.IsNotNull(king);

        }
        [TestMethod]
        public void KingCanMoveOneSquareBackwardAndLeft()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("c6", "b5");

            //Assert
            var king = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King && p.GetRank() == 5 && p.GetFile() == "b");
            Assert.IsNotNull(king);

        }
        [TestMethod]
        public void KingCanMoveOneSquareBackwardAndRight()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("c6", "d5");

            //Assert
            var king = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King && p.GetRank() == 5 && p.GetFile() == "d");
            Assert.IsNotNull(king);

        }
        [TestMethod]
        public void KingCannotMoveTwoSquaresHorizontally()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            try
            {
                //Act
                var updatedgame = game.Move("c6", "e6");
            }catch(Exception e)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");

        }
        [TestMethod]
        public void KingCannotMoveTwoSquaresVertically()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            try
            {
                //Act
                var updatedgame = game.Move("c6", "c4");
            }
            catch (Exception e)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");

        }
        [TestMethod]
        public void KingCannotMoveTwoSquaresDiagonally()
        {
            //Arrange
            string testString = "WKc6";
            var game = GameFactory.NewCustomGame(testString);

            try
            {
                //Act
                var updatedgame = game.Move("c6", "e4");
            }
            catch (Exception e)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");

        }
        [TestMethod]
        public void KingCannotMoveThroughAllies()
        {
            //Arrange
            string testString = "WKc6WQc5";
            var game = GameFactory.NewCustomGame(testString);

            try
            {
                //Act
                var updatedgame = game.Move("c6", "c5");
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
