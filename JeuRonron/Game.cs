using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRonron
{
    public class Game
    {
        public List<Scene> listScenes { get; set; } = new List<Scene>();
        public GameSettings gameSettings { get; set; } = new GameSettings();
        public int currentSceneIndex{ get; set; } = 0;
        public Game()
        {

        }
        public void Load()
        {
            gameSettings.Load();
            var ImgDirectories = Directory.GetCurrentDirectory() + "\\Conversations";
            if (!Directory.Exists(ImgDirectories))
                return;
            string[] dirs = Directory.GetDirectories(ImgDirectories, "*", SearchOption.TopDirectoryOnly);

            foreach (string dir in dirs)
            {
                Scene scene = new Scene(dir);
                scene.LoadScene();
                listScenes.Add(scene);
            }
        }
    }
}
