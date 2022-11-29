using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace JeuRonron
{
    public partial class MainForm : Form
    {
        public Game game;
        public Random random = new Random();
        public Bulle bulle1;
        public MainForm()
        {
            InitializeComponent();
            //btPrevious.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\GraphicComponents\\button_previous.png");
            //btNext.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\GraphicComponents\\button_next.png");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            game = new Game();
            game.Load();
            convSelectionControl.AddCharacters(game.listScenes[game.currentSceneIndex].listChar);


            convSelectionControl.ButtonNext.Click += BtNextClick;
            convSelectionControl.ButtonPrevious.Click += BtPreviousClick;
            convSelectionControl.ButtonSelect.Click += BtSelectClick;
            convSelectionControl.ButtonSettings.Click += BtSettingsClick;
        }

        private void BtSettingsClick(object sender, EventArgs e)
        {
            if (settingsControl.Visible == true)
            {
                settingsControl.Visible = false;
                settingsControl.SendToBack();
            }

            else
            {
                settingsControl.BringToFront();
                settingsControl.Visible = true;
            }

        }


        private void BtNextClick(object sender, EventArgs e)
        {
            if (game.currentSceneIndex < game.listScenes[game.currentSceneIndex].listBackground.Count)
                game.currentSceneIndex++;

            else
                game.currentSceneIndex = 0;

            convSelectionControl.SwapCharacters(game.listScenes[game.currentSceneIndex].listChar);
        }
        private void BtPreviousClick(object sender, EventArgs e)
        {
            if (game.currentSceneIndex > 0)
                game.currentSceneIndex--;

            else
                game.currentSceneIndex = game.listScenes[game.currentSceneIndex].listBackground.Count;

            convSelectionControl.SwapCharacters(game.listScenes[game.currentSceneIndex].listChar);
        }

        private void BtSelectClick(object sender, EventArgs e)
        {
            this.Text = game.listScenes[game.currentSceneIndex].SceneName;
            convSelectionControl.Visible = false;
            this.Controls.Add(game.listScenes[game.currentSceneIndex]);
        }




        private void MainForm_Resize(object sender, EventArgs e)
        {
            // panelGame.Controls.OfType<PictureBox>().ToList().ForEach(control => panelGame.Controls.Remove(control));
            ///AddCharImg();
        }




        private void MainForm_ControlAdded(object sender, ControlEventArgs e)
        {
            if (!(e.Control is Scene))
                return;
        }

    }
}