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
    public class PawnMoves
    {
        [TestMethod]
        public void PawnCanMoveForward()
        {

                //Arrange
                string testString = "W d3";
                var game = GameFactory.NewCustomGame(testString);

                //Act
                var updatedgame = game.Move("d3", "d4");
                //Assert
                var pawn = updatedgame.GetBoard().Single(p =>
                    p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Queen && p.GetRank() == 4 &&
                    p.GetFile() == "d");
                Assert.IsNotNull(pawn);
        }

        [TestMethod]
        public void PawnCannotMoveAnywhereElse()
        {
            //Arrange
            string testString = "W d3";
            for (var r = 1; r <= 8; r++)
            {
                for (var f = 1; f <= 8; f++)
                {
                    var game = GameFactory.NewCustomGame(testString);
                    var targetrank = r;
                    var targetfilenr = f;
                    char targetfile = (char)(((int)'a') + (targetfilenr - 1));

                    var target = string.Format("{0}{1}",targetfile,targetrank);

                    if (target != "d4" && target != "d5")
                        continue;

                    try
                    {
                        //Act
                        var updatedgame = game.Move("d3", target);
                    }
                    catch (Exception)
                    {
                        continue;
                    }

                    //Assert
                    Assert.Fail("No exception thrown");
                }
            }
        }
        [TestMethod]
        public void PawnCanMoveForward2SpacesIfItHasNotMovedYet()
        {

            //Arrange
            string testString = "W d3";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("d3", "d5");
            //Assert
            var pawn = updatedgame.GetBoard().Single(p =>
                p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Queen && p.GetRank() == 4 &&
                p.GetFile() == "d");
            Assert.IsNotNull(pawn);
        }
        [TestMethod]
        public void PawnCannotMove2SpacesIfItHasMovedBefore()
        {
            //Arrange
            string testString = "W d3";
            var game = GameFactory.NewCustomGame(testString);
            var updatedgame = game.Move("d3", "d4");


            try
            {
                //Act
                var updatedgame2 = updatedgame.Move("d4", "d6");
            }
            catch (Exception)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");
            
            
        }
        [TestMethod]
        public void PawnCannotMoveThroughFriendlyUnits()
        {
            //Arrange
            string testString = "W d3WBd4";
            var game = GameFactory.NewCustomGame(testString);


            try
            {
                //Act
                var updatedgame = game.Move("d3", "d4");
            }
            catch (Exception)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");


        }
        [TestMethod]
        public void PawnCannotMoveThroughRivalUnits()
        {
            //Arrange
            string testString = "W d3BBd4";
            var game = GameFactory.NewCustomGame(testString);


            try
            {
                //Act
                var updatedgame = game.Move("d3", "d4");
            }
            catch (Exception)
            {
                return;
            }

            //Assert
            Assert.Fail("No exception thrown");


        }
        [TestMethod]
        public void PawnCanCaptureRivalUnitIfItsOnADiagonal()
        {

            //Arrange
            string testString = "W d3BBe4";
            var game = GameFactory.NewCustomGame(testString);

            //Act
            var updatedgame = game.Move("d3", "e4");
            //Assert
            var pawn = updatedgame.GetBoard().Single(p =>
                p.GetColor() == PieceColor.White && p.GetSymbol() == PieceSymbol.Queen && p.GetRank() == 4 &&
                p.GetFile() == "e");
            Assert.IsNotNull(pawn);
            var count = updatedgame.GetBoard().Count;
            Assert.AreEqual(1, count);
        }
    }
}
