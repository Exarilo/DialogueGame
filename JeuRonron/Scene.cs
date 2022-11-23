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
        private SemaphoreSlim semaphoreMessage = new SemaphoreSlim(0);

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
            semaphoreMessage.Release();
            var panelCharName = Parent.Controls.OfType<Panel>().Where(x => x.Name.Equals("panelCharName")).ToList();
            foreach (var panel in panelCharName)
            {
                this.Parent.Controls.Remove(panel);
            }
            Parent.Refresh();

        }
        private async void Scene_Load(object sender, EventArgs e)
        {
            foreach (string line in scenario)
            {        
                DetectChar(line);
                var detectedChar = listChar.Where(x => x.Name.Contains(CharName)).ToList();
                if (detectedChar.Any())
                {
                    Bulle bulle = new Bulle(detectedChar[0]);
                    this.Controls.Add(bulle);
                    AddPictureBoxWithDetectedChar(bulle);
                    bulle.message.Click += new EventHandler(MessageClick);
                    bulle.message.Text = MessageToDisplay;
                    await semaphoreMessage.WaitAsync();
                    this.Controls.Remove(bulle);

                }
            }
        }
        public void AddPictureBoxWithDetectedChar(Bulle bulle)
        {
            var detectedChar = listChar.Where((x) => x.Name.Contains(CharName)).ToList();
            if (detectedChar.Any())
            {
                if (detectedChar[0].Image != null)
                {
                    pbChar.BorderStyle = BorderStyle.FixedSingle;
                    int PictureBoxHeight = (this.Parent.Height / 2) + 50;
                    int PictureBoxWidth = this.ClientSize.Width/ (listChar.Count - listChar.Where(x=>x.Image==null).Count());
                    pbChar.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbChar.Visible = true;
                    pbChar.Image = detectedChar[0].Image;
                    pbChar.Size= new Size(PictureBoxWidth, PictureBoxHeight);

                    int LocationX = (this.ClientSize.Width / 2);
                    int LocationY = this.Height - PictureBoxHeight - bulle.Height;
                    pbChar.Location = new Point(LocationX, LocationY);
                    //pbChar.Location= new Point(this.ClientSize.Width / 2, this.Parent.Height - PictureBoxHeight - bulle.Height);
                    pbChar.Refresh();
                    return;
                }
            }
            pbChar.Visible = false;
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
                                MessageToDisplay = line.Replace("[" + match.Value.Substring(1, match.Value.Length - 2) + "]", "");
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
            this.pbChar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbChar
            // 
            this.pbChar.BackColor = System.Drawing.Color.Transparent;
            this.pbChar.Location = new System.Drawing.Point(117, 100);
            this.pbChar.Name = "pbChar";
            this.pbChar.Size = new System.Drawing.Size(169, 142);
            this.pbChar.TabIndex = 0;
            this.pbChar.TabStop = false;
            this.pbChar.Visible = false;
            // 
            // Scene
            // 
            this.Controls.Add(this.pbChar);
            this.Name = "Scene";
            this.Size = new System.Drawing.Size(434, 368);
            this.Load += new System.EventHandler(this.Scene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbChar)).EndInit();
            this.ResumeLayout(false);

        }

    }
}