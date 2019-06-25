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
    }
}
