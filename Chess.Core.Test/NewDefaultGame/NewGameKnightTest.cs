using System;
using System.Linq;
using Chess.Core.Enums;
using Chess.Core.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess.Core.Test.NewDefaultGame
{
    [TestClass]
    public class NewGameKnightTest
    {
        [TestMethod]
        public void GameStartHas2WhiteKnights()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var knights = game.GetBoard().Where(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Knight);

            //Assert
            Assert.AreEqual(2, knights.Count());

        }
        [TestMethod]
        public void GameStartHasAWhiteKnightAtB1()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var knight = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Knight && p.GetRank() == 1 && p.GetFile() == "b");

            //Assert
            Assert.IsNotNull(knight);
        }
        [TestMethod]
        public void GameStartHasAWhiteKnightAtG1()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var knight = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Knight && p.GetRank() == 1 && p.GetFile() == "g");

            //Assert
            Assert.IsNotNull(knight);
        }
        [TestMethod]
        public void GameStartHas2BlackKnights()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var knights = game.GetBoard().Where(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Knight);

            //Assert
            Assert.AreEqual(2, knights.Count());

        }
        [TestMethod]
        public void GameStartHasABlackKnightAtB8()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var knight = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Knight && p.GetRank() == 8 && p.GetFile() == "b");

            //Assert
            Assert.IsNotNull(knight);
        }
        [TestMethod]
        public void GameStartHasABlackKnightAtG8()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var knight = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Knight && p.GetRank() == 8 && p.GetFile() == "g");

            //Assert
            Assert.IsNotNull(knight);
        }
    }
}
