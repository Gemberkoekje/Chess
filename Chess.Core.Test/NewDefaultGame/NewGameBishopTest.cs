using System;
using System.Linq;
using Chess.Core.Enums;
using Chess.Core.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess.Core.Test.NewDefaultGame
{
    [TestClass]
    public class NewGameBishopTest
    {
        [TestMethod]
        public void GameStartHas2WhiteBishops()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var bishops = game.GetBoard().Where(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Bishop);

            //Assert
            Assert.AreEqual(2, bishops.Count());

        }
        [TestMethod]
        public void GameStartHasAWhiteBishopAtC1()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var bishop = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Bishop && p.GetRank() == 1 && p.GetFile() == "c");

            //Assert
            Assert.IsNotNull(bishop);
        }
        [TestMethod]
        public void GameStartHasAWhiteBishopAtF1()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var bishop = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Bishop && p.GetRank() == 1 && p.GetFile() == "f");

            //Assert
            Assert.IsNotNull(bishop);
        }
        [TestMethod]
        public void GameStartHas2BlackBishops()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var bishops = game.GetBoard().Where(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Bishop);

            //Assert
            Assert.AreEqual(2, bishops.Count());

        }
        [TestMethod]
        public void GameStartHasABlackBishopAtC8()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var bishop = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Bishop && p.GetRank() == 8 && p.GetFile() == "c");

            //Assert
            Assert.IsNotNull(bishop);
        }
        [TestMethod]
        public void GameStartHasABlackBishopAtF8()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var bishop = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Bishop && p.GetRank() == 8 && p.GetFile() == "f");

            //Assert
            Assert.IsNotNull(bishop);
        }
    }
}
