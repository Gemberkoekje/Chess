using System;
using System.Linq;
using Chess.Core.Enums;
using Chess.Core.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess.Core.Test.NewDefaultGame
{
    [TestClass]
    public class NewGameKingTest
    {
        [TestMethod]
        public void GameStartHas1WhiteKing()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var kings = game.GetBoard().Where(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King);

            //Assert
            Assert.AreEqual(1, kings.Count());

        }
        [TestMethod]
        public void GameStartHasAWhiteKingAtE1()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var king = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King && p.GetRank() == 1 && p.GetFile() == "e");

            //Assert
            Assert.IsNotNull(king);
        }
        [TestMethod]
        public void GameStartHas1BlackKing()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var kings = game.GetBoard().Where(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.King);

            //Assert
            Assert.AreEqual(1, kings.Count());

        }
        [TestMethod]
        public void GameStartHasABlackKingAtE8()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var king = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.King && p.GetRank() == 8 && p.GetFile() == "e");

            //Assert
            Assert.IsNotNull(king);
        }
    }
}
