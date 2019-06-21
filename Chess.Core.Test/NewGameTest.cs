using System;
using System.Linq;
using Chess.Core.Enums;
using Chess.Core.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess.Core.Test
{
    [TestClass]
    public class NewGameTest
    {
        [TestMethod]
        public void GameStartHas2WhiteRooks()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var rooks = game.GetBoard().Where(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Rook);

            //Assert
            Assert.AreEqual(2, rooks.Count());

        }
        [TestMethod]
        public void GameStartHasAWhiteRookAtA1()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var rook = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Rook && p.GetRank() == 1 && p.GetFile() == "a");

            //Assert
            Assert.IsNotNull(rook);
        }
        [TestMethod]
        public void GameStartHasAWhiteRookAtH1()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var rook = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Rook && p.GetRank() == 1 && p.GetFile() == "h");

            //Assert
            Assert.IsNotNull(rook);
        }
    }
}
