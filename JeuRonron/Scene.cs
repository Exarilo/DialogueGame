using stdole;
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

        public Bulle Bulle { get; set; }
        public string SceneName { get; set; }
        public string path { get; set; }
        public List<Character> listChar { get; set; } = new List<Character>();
        public List<Background> listBackground { get; set; } = new List<Background>();
        public string[] scenario { get; set; }
        private string MessageToDisplay { get; set; }
        public string CharName { get; set; }
        private SemaphoreSlim signal = new SemaphoreSlim(0);

        public async Task DoDialag()
        {
            pbChar.BackColor = Color.Transparent;
            if (scenario == null)
                return;
            bool locationPbCharAlreadyChanged = false;
            for(int i=0;i<scenario.Length;i++)
            {
                DetectChar(scenario[i]);
                Bitmap detectedBackground = DetectKeywordBackground(MessageToDisplay);
                if (detectedBackground != null)
                    this.BackgroundImage = detectedBackground;
                else
                    this.BackgroundImage = default;
                //TODO NOT NULL

                var detectedChar = listChar?.Where(x => x.Name.Contains(CharName))?.ToList();
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
                    bulle.SetStyle(MainForm.game.gameSettings.BulleBackColor, MainForm.game.gameSettings.BulleTextColor, MainForm.game?.gameSettings?.BulleTextFont);
                    if (!locationPbCharAlreadyChanged)
                    {
                        pbChar.Location = new Point(pbChar.Location.X, bulle.Location.Y+ 8);
                        locationPbCharAlreadyChanged = true;
                    }

                    this.Controls.Add(bulle);
                    bulle.buttonNext.Click += (s, e) => { signal.Release(); };
                    bulle.buttonPrevious.Click += (s, e) => { i= i==0?i-1:i=i-2; signal.Release(); };
                    bulle.message.Text = MessageToDisplay;

                    await signal.WaitAsync();
                    this.Controls.Remove(bulle);
                    var panelCharName = Parent.Controls.OfType<Panel>().Where(x => x.Name.Equals("panelCharName")).ToList();

                    foreach (var panel in panelCharName)
                    {
                        this.Parent.Controls.Remove(panel);
                    }
                   // Parent.Refresh();
                }
            }
        }
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


        public Bitmap DetectKeywordBackground(string line)
        {
            var rand = new Random();
            var keywordsDetected = MainForm.game.backgroundsKeywords.Where(x => line.ToLower().Trim().Contains(Convert.ToString(x.Tag).ToLower().Trim()));
            if (keywordsDetected.Any())
                return keywordsDetected.OrderBy(x => rand.Next())?.First();
            return null;
        }
        public void DetectChar(string line)
        {
            if (line.StartsWith(MainForm.game.gameSettings.DelimiteurStartChar) && line.Contains(MainForm.game.gameSettings.DelimiteurEndChar))
            {
                var match = new Regex($"\\{MainForm.game.gameSettings.DelimiteurStartChar}*.*\\{MainForm.game.gameSettings.DelimiteurEndChar}").Match(line);
                if (match.Success)
                {
                    var characterMatch = listChar.Where(x => x.Name.ToLower().Equals(match.Value.Substring(1, match.Value.Length - 2).ToLower())).FirstOrDefault();
                    if (characterMatch != null)
                    {
                        MessageToDisplay = line.Replace($"{MainForm.game.gameSettings.DelimiteurStartChar}" + characterMatch.Name + $"{MainForm.game.gameSettings.DelimiteurEndChar}", "");
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
                                MessageToDisplay = line.Replace($"{MainForm.game.gameSettings.DelimiteurStartChar}" + character.Name + $"{MainForm.game.gameSettings.DelimiteurEndChar}", "");
                                CharName = character.Name;
                                isCharFind = true;
                                return;
                            }
                        }
                        if (!isCharFind)
                        {
                            MessageToDisplay = line.Replace($"{MainForm.game.gameSettings.DelimiteurStartChar}" + match.Value.Substring(1, match.Value.Length - 2) + $"{MainForm.game.gameSettings.DelimiteurEndChar}", "");
                            CharName = match.Value.Substring(1, match.Value.Length - 2);
                        }
                    }
                }
            }
            else
            {
                var index = line.IndexOf($"{MainForm.game.gameSettings.DelimiteurEndChar}");
                MessageToDisplay = line.Substring(index,line.Length);
                var car = listChar?.Where(x => x?.Name == Constant.UnkownCharName)?.FirstOrDefault();
                CharName = car.Name;
            }

        }

        private void InitializeComponent()
        {
            this.pbChar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbChar
            // 
            this.pbChar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbChar.BackColor = System.Drawing.Color.Transparent;
            this.pbChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbChar.Location = new System.Drawing.Point(253, 86);
            this.pbChar.Name = "pbChar";
            this.pbChar.Size = new System.Drawing.Size(307, 342);
            this.pbChar.TabIndex = 0;
            this.pbChar.TabStop = false;
            // 
            // Scene
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbChar);
            this.Name = "Scene";
            this.Size = new System.Drawing.Size(816, 489);
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).EndInit();
            this.ResumeLayout(false);

        }
    }
}