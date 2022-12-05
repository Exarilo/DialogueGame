using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        private string MessageToDisplay { get; set; }
        public string CharName { get; set; }
        private SemaphoreSlim signal = new SemaphoreSlim(0);

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
            scenario = File.ReadAllLines(path + "\\Scénario.txt");
        }

        protected void MessageClick(object sender, EventArgs e)
        {
            signal.Release();

        }
        private async void Scene_Load(object sender, EventArgs e)
        {
            foreach (string line in scenario)
            {
                DetectChar(line);
                //TODO NOT NULL
                var detectedChar = listChar.Where(x => x.Name.Contains(CharName)).ToList();
                if (detectedChar.Any())
                {
                    Bulle bulle = new Bulle(detectedChar[0]);
                    this.Controls.Add(bulle);
                    bulle.message.Click += new EventHandler(MessageClick);
                    bulle.message.Text = MessageToDisplay;
                    await signal.WaitAsync();
                    this.Controls.Remove(bulle);
                    var panelCharName = Parent.Controls.OfType<Panel>().Where(x => x.Name.Equals("panelCharName")).ToList();
                    foreach (var panel in panelCharName)
                    {
                        this.Parent.Controls.Remove(panel);
                    }
                    Parent.Refresh();
                }
            }
        }
        public void DetectChar(string line)
        {
            if (line.StartsWith(Constant.DelimiteurStartChar) && line.Contains(Constant.DelimiteurEndChar))
            {
                var match = new Regex($"\\{Constant.DelimiteurStartChar}*.*\\{Constant.DelimiteurEndChar}").Match(line);
                if (match.Success)
                {
                    var characterMatch = listChar.Where(x => x.Name.ToLower().Equals(match.Value.Substring(1, match.Value.Length - 2).ToLower())).FirstOrDefault();
                    if (characterMatch != null)
                    {
                        MessageToDisplay = line.Replace("[" + characterMatch.Name + "]", "");
                        CharName = characterMatch.Name;
                    }
                    else
                    {
                        bool isCharFind = false;
                        foreach (var character in listChar)
                        {
                            int levenshteinDistance = Fastenshtein.Levenshtein.Distance(character.Name, match.Value.Substring(1, match.Value.Length - 2).ToLower());
                            if (levenshteinDistance <= 1)
                            {
                                MessageToDisplay = line.Replace("[" + character.Name + "]", "");
                                CharName = character.Name;
                                isCharFind = true;
                                return;
                            }
                        }
                        if (!isCharFind)
                        {
                            MessageToDisplay = line.Replace("[" + match.Value.Substring(1, match.Value.Length - 2) + "]", "");
                            CharName = match.Value.Substring(1, match.Value.Length - 2);
                        }
                    }
                }
            }
            else
            {
                listChar.Where(x => x.Name == Constant.UnkownCharName).FirstOrDefault().Dialogues.Add(line);
            }

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