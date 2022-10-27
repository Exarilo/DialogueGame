using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuRonron
{
    public partial class Scene : UserControl
    {

        public Bulle Bulle { get; set; }
        public string SceneName { get; set; }
        public string path { get; set; }
        public List<Character> listChar { get; set; } = new List<Character>();
        public List<Background> listBackground { get; set; } = new List<Background>();
        public string[] scenario { get; set; }

        public Scene()
        {
        }
        public Scene(string path) 
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.path = path;
            this.SceneName = path.Split('\\').Last().Trim();
        }
        public void LoadScene()
        {
            listChar.Add(new Character(Constant.UnkownCharName));
            var filtersImg = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" };
            string[] dirs = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
            foreach (string dir in dirs)
            {
                var files = Tools.GetFilesFrom(dir, filtersImg, false);
                foreach (string file in files)
                {
                    Bitmap bitmap = new Bitmap(file);
                    if (dir.EndsWith("Background"))
                    {
                        listBackground.Add(new Background(file, bitmap));
                    }
                    else
                    {
                        listChar.Add(new Character(file, bitmap));
                    }
                }
            }
            string[] scenarioLines = File.ReadAllLines(path + "\\Scénario.txt");
            foreach (string line in scenarioLines)
            {
                if (line.StartsWith(Constant.DelimiteurStartChar) && line.Contains(Constant.DelimiteurEndChar))
                {
                    var match = new Regex($"\\{Constant.DelimiteurStartChar}*.*\\{Constant.DelimiteurEndChar}").Match(line);
                    if (match.Success)
                    {
                        var characterMatch = listChar.Where(x => x.Name.ToLower().Equals(match.Value.Substring(1, match.Value.Length - 2).ToLower())).FirstOrDefault();
                        if (characterMatch != null)
                            characterMatch.Dialogues.Add(line);
                        else
                        {
                            bool isCharFind = false;
                            foreach (var character in listChar)
                            {
                                int levenshteinDistance = Fastenshtein.Levenshtein.Distance(character.Name, match.Value.Substring(1, match.Value.Length - 2).ToLower());
                                if (levenshteinDistance <= 1)
                                {
                                    character.Dialogues.Add(line);
                                    isCharFind = true;
                                    break;
                                }

                            }
                            if (!isCharFind)
                            {
                                listChar.Add(new Character(match.Value.Substring(1, match.Value.Length - 2)));
                            }

                        }
                    }
                }
                else
                {
                    listChar.Where(x => x.Name == Constant.UnkownCharName).FirstOrDefault().Dialogues.Add(line);
                }
            }
        }
        private void Scene_Load(object sender, EventArgs e)
        {
            Bulle bulle = new Bulle();
            this.Controls.Add(bulle);
            //Character character = new Character();
            //character.Name = "Je suis le nom du perso";
            //bulle1 = new Bulle(character);
            //this.Controls.Add(bulle1);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Scene
            // 
            this.Name = "Scene";
            this.Size = new System.Drawing.Size(434, 368);
            this.Load += new System.EventHandler(this.Scene_Load);
            this.ResumeLayout(false);

        }
    }
}


















