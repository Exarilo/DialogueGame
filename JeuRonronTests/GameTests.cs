using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeuRonron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JeuRonron.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void GameTest()
        {
            Game game = new Game();
            Assert.IsNotNull(game);
            Assert.IsNotNull(game.gameSettings);
            Assert.IsNotNull(game.listScenes);
            //Assert.IsTrue(Directory.Exists(Directory.GetCurrentDirectory() + "\\Conversations"));
            //Assert.IsTrue(File.Exists(Directory.GetCurrentDirectory() + "\\Conversations\\settings.txt"));
            game.Load();
        }
    }
}