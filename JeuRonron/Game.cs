using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace JeuRonron
{
    public class Game
    {
        public List<Scene> listScenes { get; set; } = new List<Scene>();
        public Settings gameSettings { get; set; } = new Settings();
        public IEnumerable<Bitmap> backgroundsKeywords { get; set; }
        public int currentSceneIndex { get; set; } = 0;
        public Game()
        {

        }
        public void Load()
        {
            CreateMissingDirectories();
            gameSettings.Load();
            backgroundsKeywords = GetKeywordBackground(Directory.GetCurrentDirectory() + "\\MotsBackground").ToList();
            listScenes.AddRange(ProduceScenes(Directory.GetCurrentDirectory() + "\\Conversations").ToList());
        }

        IEnumerable<Scene> ProduceScenes(string rootDirectory)
        {
            if (Directory.Exists(rootDirectory))
            {
                string[] dirs = Directory.GetDirectories(rootDirectory, "*", SearchOption.TopDirectoryOnly);

                foreach (string dir in dirs)
                {
                    Scene scene = new Scene(dir);
                    scene.LoadScene();
                    yield return scene;
                }
            }
        }
        public void CreateMissingDirectories()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Conversations"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Conversations");

            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\MotsBackground"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\MotsBackground");
        }

        IEnumerable<Bitmap> GetKeywordBackground(string rootDirectory)
        {
            var filtersImg = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" };
            if (Directory.Exists(rootDirectory))
            {
                var files = Tools.GetFilesFrom(rootDirectory, filtersImg, false);
                foreach (string file in files)
                {      
                    Bitmap bitmap = new Bitmap(file);
                    bitmap.Tag= file.Split('\\').Last().Split('.').First();
                    yield return bitmap;
                }

            }
        }
    }
}
