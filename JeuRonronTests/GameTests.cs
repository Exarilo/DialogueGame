using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeuRonron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRonron.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void GameTest()
        {
            Game game = new Game();
            game.Load();
            Assert.IsNotNull(game);
            
        }

        [TestMethod()]
        public void LoadTest()
        {
            Assert.Fail();
        }
    }
}