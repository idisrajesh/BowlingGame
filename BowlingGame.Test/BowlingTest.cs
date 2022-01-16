using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;
using System;

namespace BowlingGame.Test
{
    [TestClass]
    public class BowlingTest
    {
        private readonly IGame _game;
        public BowlingTest()
        {
            _game = new Game();
        }
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            Roll(10, 12);
            Assert.AreEqual(300, _game.GetScore());
        }

        private void Roll( int pins, int times)
        {


            for (int i = 0; i < times; i++)
            {
                _game.Roll(pins);
            }
        }

        [TestMethod]
        public void TestRollSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(7);
            _game.Roll(2);
            Assert.AreEqual(26, _game.GetScore());
        }

        [TestMethod]
        public void TestRollStrike()
        {
            _game.Roll(10);
            _game.Roll(5);
            _game.Roll(2);
            _game.Roll(2);
            Assert.AreEqual(26, _game.GetScore());
        }

        [TestMethod]
        public void TestRollStrikeSpare()
        {
            _game.Roll(10);
            _game.Roll(10);
            _game.Roll(10);
            _game.Roll(2);
            _game.Roll(4);
            Assert.AreEqual(74, _game.GetScore());
        }

        [TestMethod]
        public void TestValidScore()
        {
            _game.Roll(10);
            _game.Roll(9);
            _game.Roll(1);
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(7);
            _game.Roll(2);
            _game.Roll(10);
            _game.Roll(10);
            _game.Roll(10);
            _game.Roll(9);
            _game.Roll(0);
            _game.Roll(8);
            _game.Roll(2);
            _game.Roll(9);
            _game.Roll(1);
            _game.Roll(10);
            Assert.AreEqual(187, _game.GetScore());
        }

        [TestMethod]
        public void TestValidScore2()
        {
            _game.Roll(10);
            _game.Roll(8);
            _game.Roll(2);
            _game.Roll(9);
            _game.Roll(1);
            _game.Roll(8);
            _game.Roll(0);
            _game.Roll(10);
            _game.Roll(10);
            _game.Roll(9);
            _game.Roll(1);
            _game.Roll(9);
            _game.Roll(1);
            _game.Roll(10);
            _game.Roll(10);
            _game.Roll(9);
            _game.Roll(1);
            Assert.AreEqual(202, _game.GetScore());
        }
    }
}
