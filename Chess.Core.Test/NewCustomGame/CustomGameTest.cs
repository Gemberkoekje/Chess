using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Chess.Core.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess.Core.Factories;

namespace Chess.Core.Test.NewCustomGame
{
    [TestClass]
    public class CustomGameTest
    {
       [TestMethod]
        public void CustomGameStartCanSetupAPiece()
        {
            //Arrange
            string testString = "BKc6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetRank() == 6 && p.GetFile() == "c" && p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.King);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetup2Pieces()
        {
            //Arrange
            string testString = "BKc6WKb4";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var amount = game.GetBoard().Count;
            Assert.AreEqual(2, amount);
            var piece1 = game.GetBoard().Single(p => p.GetRank() == 6 && p.GetFile() == "c" && p.GetColor() == PieceColor.Black && p.GetSymbol() == PieceSymbol.King);
            Assert.IsNotNull(piece1);
            var piece2 = game.GetBoard().Single(p => p.GetRank() == 4 && p.GetFile() == "b" && p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.King);
            Assert.IsNotNull(piece2);

        }
        [TestMethod]
        public void CustomGameStartCanSetupAKing()
        {
            //Arrange
            string testString = "BKc6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetSymbol() == PieceSymbol.King);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAQueen()
        {
            //Arrange
            string testString = "BQc6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetSymbol() == PieceSymbol.Queen);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupABishop()
        {
            //Arrange
            string testString = "BBc6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetSymbol() == PieceSymbol.Bishop);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAKnight()
        {
            //Arrange
            string testString = "BNc6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetSymbol() == PieceSymbol.Knight);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupARook()
        {
            //Arrange
            string testString = "BRc6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetSymbol() == PieceSymbol.Rook);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPawn()
        {
            //Arrange
            string testString = "B c6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetSymbol() == PieceSymbol.Pawn);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupABlackPiece()
        {
            //Arrange
            string testString = "B c6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetColor() == PieceColor.Black);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAWhitePiece()
        {
            //Arrange
            string testString = "W c6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetColor() == PieceColor.White);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtFileA()
        {
            //Arrange
            string testString = "WRa6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetFile() == "a");
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtFileB()
        {
            //Arrange
            string testString = "WRb6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetFile() == "b");
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtFileC()
        {
            //Arrange
            string testString = "WRc6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetFile() == "c");
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtFileD()
        {
            //Arrange
            string testString = "WRd6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetFile() == "d");
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtFileE()
        {
            //Arrange
            string testString = "WRe6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetFile() == "e");
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtFileF()
        {
            //Arrange
            string testString = "WRf6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetFile() == "f");
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtFileG()
        {
            //Arrange
            string testString = "WRg6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetFile() == "g");
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtFileH()
        {
            //Arrange
            string testString = "WRh6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetFile() == "h");
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtRank1()
        {
            //Arrange
            string testString = "WRf1";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetRank() == 1);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtRank2()
        {
            //Arrange
            string testString = "WRf2";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetRank() == 2);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtRank3()
        {
            //Arrange
            string testString = "WRf3";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetRank() == 3);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtRank4()
        {
            //Arrange
            string testString = "WRf4";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetRank() == 4);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtRank5()
        {
            //Arrange
            string testString = "WRf5";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetRank() == 5);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtRank6()
        {
            //Arrange
            string testString = "WRf6";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetRank() == 6);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtRank7()
        {
            //Arrange
            string testString = "WRf7";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetRank() == 7);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartCanSetupAPieceAtRank8()
        {
            //Arrange
            string testString = "WRf8";

            //Act
            var game = GameFactory.NewCustomGame(testString);

            //Assert
            var piece = game.GetBoard().Single(p => p.GetRank() == 8);
            Assert.IsNotNull(piece);
        }
        [TestMethod]
        public void CustomGameStartThrowsExceptionIfStringIsNotAMultipleOf4()
        {
            //Arrange
            string testString = "WRf8BBf";

            //Act
            try
            {
                var game = GameFactory.NewCustomGame(testString);
            }
            catch (ArgumentException)
            {
                return;
            }
            

            //Assert
            Assert.Fail("No exception encountered");
        }
        [TestMethod]
        public void CustomGameStartThrowsExceptionIfColorIsNotValid()
        {
            //Arrange
            string testString = "TRf8";

            //Act
            try
            {
                var game = GameFactory.NewCustomGame(testString);
            }
            catch (ArgumentException)
            {
                return;
            }


            //Assert
            Assert.Fail("No exception encountered");
        }
        [TestMethod]
        public void CustomGameStartThrowsExceptionIfSymbolIsNotValid()
        {
            //Arrange
            string testString = "WGf8";

            //Act
            try
            {
                var game = GameFactory.NewCustomGame(testString);
            }
            catch (ArgumentException)
            {
                return;
            }


            //Assert
            Assert.Fail("No exception encountered");
        }
        [TestMethod]
        public void CustomGameStartThrowsExceptionIfFileIsNotValid()
        {
            //Arrange
            string testString = "WRl8";

            //Act
            try
            {
                var game = GameFactory.NewCustomGame(testString);
            }
            catch (ArgumentException)
            {
                return;
            }


            //Assert
            Assert.Fail("No exception encountered");
        }
        [TestMethod]
        public void CustomGameStartThrowsExceptionIfRankIsNotANumber()
        {
            //Arrange
            string testString = "WRct";

            //Act
            try
            {
                var game = GameFactory.NewCustomGame(testString);
            }
            catch (ArgumentException)
            {
                return;
            }


            //Assert
            Assert.Fail("No exception encountered");
        }
        [TestMethod]
        public void CustomGameStartThrowsExceptionIfRankIsNotValid()
        {
            //Arrange
            string testString = "WRc9";

            //Act
            try
            {
                var game = GameFactory.NewCustomGame(testString);
            }
            catch (ArgumentException)
            {
                return;
            }


            //Assert
            Assert.Fail("No exception encountered");
        }
    }
}
