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
        private Bulle bulle;

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
            scenario = File.ReadAllLines(path + "\\Scénario.txt");
        }
        private void Scene_Load(object sender, EventArgs e)
        {           
            foreach (string line in scenario)
            {
                bool isClicked = false;
                bulle = new Bulle(listChar, line);
                bulle.message.Text = line;


            }
    
            //Character character = new Character();
            //character.Name = "Je suis le nom du perso";
            //bulle1 = new Bulle(character);
            //this.Controls.Add(bulle1);
        }

        private void InitializeComponent()
        {
            this.bulle = new JeuRonron.Bulle();
            this.SuspendLayout();
            // 
            // bulle
            // 
            this.bulle.CharName = null;
            this.bulle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bulle.isPanelCharNameExist = false;
            this.bulle.Location = new System.Drawing.Point(0, 268);
            this.bulle.Name = "bulle";
            this.bulle.panelNameChar = null;
            this.bulle.Size = new System.Drawing.Size(434, 100);
            this.bulle.TabIndex = 0;
            // 
            // Scene
            // 
            this.Controls.Add(this.bulle);
            this.Name = "Scene";
            this.Size = new System.Drawing.Size(434, 368);
            this.Load += new System.EventHandler(this.Scene_Load);
            this.ResumeLayout(false);

        }
    }
}


















