using System;
using System.Linq;
using Chess.Core.Enums;
using Chess.Core.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess.Core.Test.NewDefaultGame
{
    [TestClass]
    public class NewGamePawnTest
    {
        [TestMethod]
        public void GameStartHas8WhitePawns()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawns = game.GetBoard().Where(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Pawn);

            //Assert
            Assert.AreEqual(8, pawns.Count());

        }
        [TestMethod]
        public void GameStartHasAWhitePawnAtA2()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 2 && p.GetFile() == "a");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasAWhitePawnAtB2()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 2 && p.GetFile() == "b");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasAWhitePawnAtC2()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 2 && p.GetFile() == "c");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasAWhitePawnAtD2()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 2 && p.GetFile() == "d");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasAWhitePawnAtE2()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 2 && p.GetFile() == "e");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasAWhitePawnAtF2()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 2 && p.GetFile() == "f");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasAWhitePawnAtG2()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 2 && p.GetFile() == "g");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasAWhitePawnAtH2()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 2 && p.GetFile() == "h");

            //Assert
            Assert.IsNotNull(pawn);
        }



        [TestMethod]
        public void GameStartHas8BlackPawns()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawns = game.GetBoard().Where(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Pawn);

            //Assert
            Assert.AreEqual(8, pawns.Count());

        }
        [TestMethod]
        public void GameStartHasABlackPawnAtA7()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 7 && p.GetFile() == "a");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasABlackPawnAtB7()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 7 && p.GetFile() == "b");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasABlackPawnAtC7()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 7 && p.GetFile() == "c");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasABlackPawnAtD7()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 7 && p.GetFile() == "d");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasABlackPawnAtE7()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 7 && p.GetFile() == "e");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasABlackPawnAtF7()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 7 && p.GetFile() == "f");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasABlackPawnAtG7()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 7 && p.GetFile() == "g");

            //Assert
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void GameStartHasABlackPawnAtH7()
        {
            //Arrange
            var game = GameFactory.NewGame();

            //Act
            var pawn = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.Pawn && p.GetRank() == 7 && p.GetFile() == "h");

            //Assert
            Assert.IsNotNull(pawn);
        }
    }
}
