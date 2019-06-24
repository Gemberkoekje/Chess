using System;
using System.Linq;
using Chess.Core.Enums;
using Chess.Core.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess.Core.Test.NewDefaultGame
{
    [TestClass]
    public class NewGameQueenTest
    {
        [TestMethod]
        public void GameStartHas1WhiteQueen()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var queens = game.GetBoard().Where(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Queen);

            //Assert
            Assert.AreEqual(1, queens.Count());

        }
        [TestMethod]
        public void GameStartHasAWhiteQueenAtD1()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var queen = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Queen && p.GetRank() == 1 && p.GetFile() == "d");

            //Assert
            Assert.IsNotNull(queen);
        }
        [TestMethod]
        public void GameStartHas1BlackQueen()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var queens = game.GetBoard().Where(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Queen);

            //Assert
            Assert.AreEqual(1, queens.Count());

        }
        [TestMethod]
        public void GameStartHasABlackQueenAtD8()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var queen = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Queen && p.GetRank() == 8 && p.GetFile() == "d");

            //Assert
            Assert.IsNotNull(queen);
        }
    }
}
