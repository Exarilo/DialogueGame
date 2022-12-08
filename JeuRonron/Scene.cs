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
        private PictureBox pbChar;
        private PictureBox pbBackground;
        private Button button1;

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
            if(!File.Exists(path + "\\Scénario.txt"))
                return;
            scenario = File.ReadAllLines(path + "\\Scénario.txt");
        }

        protected void MessageClick(object sender, EventArgs e)
        {
            signal.Release();

        }
        private async void Scene_Load(object sender, EventArgs e)
        {
            if (scenario == null)
                return;
            foreach (string line in scenario)
            {
                DetectChar(line);
                //TODO NOT NULL
                var detectedChar = listChar.Where(x => x.Name.Contains(CharName)).ToList();
                if (detectedChar.Any())
                {
                    if (detectedChar[0].Image != null)
                    {
                        var messageContainChar = listChar.Where(x => MessageToDisplay.Contains(x.Name));
                        if (messageContainChar.Any())
                        {

                        }
                        pbChar.Visible = true;
                        pbChar.BackgroundImage = detectedChar[0].Image;

                    }
                    else
                        pbChar.Visible = false;
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
            this.button1 = new System.Windows.Forms.Button();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbChar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pbBackground
            // 
            this.pbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(816, 489);
            this.pbBackground.TabIndex = 1;
            this.pbBackground.TabStop = false;
            // 
            // pbChar
            // 
            this.pbChar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbChar.Location = new System.Drawing.Point(274, 147);
            this.pbChar.Name = "pbChar";
            this.pbChar.Size = new System.Drawing.Size(307, 342);
            this.pbChar.TabIndex = 0;
            this.pbChar.TabStop = false;
            // 
            // Scene
            // 
            this.Controls.Add(this.pbBackground);
            this.Controls.Add(this.pbChar);
            this.Controls.Add(this.button1);
            this.Name = "Scene";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.Scene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).EndInit();
            this.ResumeLayout(false);

        }
    }
}