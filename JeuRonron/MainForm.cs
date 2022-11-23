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
        private int _colorCounter = 250;
        public Game game;
        public Random random = new Random();
        public Bulle bulle1;
        public MainForm()
        {
            InitializeComponent();
            btPrevious.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\GraphicComponents\\button_previous.png");
            btNext.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\GraphicComponents\\button_next.png");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            game = new Game();
            game.Load();
            List<string> listGoogleSceneTitle= getGoogleSheets();
            if(listGoogleSceneTitle!=null)
            {
                AddSceneToGame(listGoogleSceneTitle);
            }
            RefreshFormWithSelectionnedScene();
        }

        private void btNextChar_Click(object sender, EventArgs e)
        {
            if (game.currentSceneIndex < game.listScenes[game.currentSceneIndex].listBackground.Count)
                game.currentSceneIndex++;

            else
                game.currentSceneIndex=0;
            RefreshFormWithSelectionnedScene();
        }


        private void btPreviousChar_Click(object sender, EventArgs e)
        {
            if (game.currentSceneIndex > 0)
                game.currentSceneIndex--;

            else
                game.currentSceneIndex = game.listScenes[game.currentSceneIndex].listBackground.Count;

            RefreshFormWithSelectionnedScene();
        }
        public void RefreshFormWithSelectionnedScene()
        {
            panelGame.Controls.OfType<PictureBox>().ToList().ForEach(control =>panelGame.Controls.Remove(control));
            if (game.listScenes.Count > 0)
            {
                if (game.listScenes[game.currentSceneIndex].listBackground.Count > 0)
                {
                    LabelSceneName.Text=game.listScenes[game.currentSceneIndex].SceneName;
                    int randomBackgroundIndex = random.Next(game.listScenes[game.currentSceneIndex].listBackground.Count);
                    panelGame.BackgroundImage = game.listScenes[game.currentSceneIndex].listBackground[randomBackgroundIndex].Image;
                    panelGame.BackgroundImageLayout = ImageLayout.Stretch;
                    AddCharImg();
                    panelGame.Refresh();
                }
            }
        }
        public void AddCharImg()
        {
            int numberOfNullCharImage = game.listScenes[game.currentSceneIndex].listChar.Where(x => x.Image == null).Count();
            int PictureBoxHeight = (this.Height / 2)+50;
            int PictureBoxWidth = this.Width / (game.listScenes[game.currentSceneIndex].listChar.Count- numberOfNullCharImage);
            int cptPictureInScreen = 0;
            for (int i = 0; i < game.listScenes[game.currentSceneIndex].listChar.Count; i++)
            {
                if (game.listScenes[game.currentSceneIndex].listChar[i].Image == null)
                    continue;
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = game.listScenes[game.currentSceneIndex].listChar[i].Image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //if(i==0)
                //pictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
                //else
                //    pictureBox.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top;
                pictureBox.Anchor = AnchorStyles.Bottom;

                pictureBox.BackColor = Color.Transparent;
                pictureBox.Width = PictureBoxWidth;
                pictureBox.Height = PictureBoxHeight;
                int LocationX =  50 + (PictureBoxWidth * (cptPictureInScreen));
                int LocationY = this.Height - PictureBoxHeight-btSelect.Height;
                pictureBox.Location=new Point(LocationX, LocationY);
                panelGame.Controls.Add(pictureBox);
                cptPictureInScreen++;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            panelGame.Controls.OfType<PictureBox>().ToList().ForEach(control => panelGame.Controls.Remove(control));
            AddCharImg();
        }

        private void btSelect_MouseHover(object sender, EventArgs e)
        {
            _colorCounter = 250;
            btSelect.UseVisualStyleBackColor = false;
            timer1.Start();
            btSelect.ForeColor = Color.White;
        }

        private void btSelect_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            _colorCounter = 250;

            btSelect.UseVisualStyleBackColor = true;
            btSelect.ForeColor = Color.Black;
            btSelect.BackColor = SystemColors.Control;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _colorCounter -= 25;

            if (_colorCounter == 0)
            {
                timer1.Stop();
                _colorCounter = 250;
            }
            else
                btSelect.BackColor = Color.FromArgb(_colorCounter, _colorCounter, _colorCounter);
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            panelGame.Visible = false;
            this.Controls.Add(game.listScenes[game.currentSceneIndex]);
        }

        private void MainForm_ControlAdded(object sender, ControlEventArgs e)
        {
            if (!(e.Control is Scene))
                return;
        }
        private List<string> getGoogleSheets()
        {
            var client = new RestClient();
            var request = new RestRequest("https://sheets.googleapis.com/v4/spreadsheets/1Bfk2PrGBKE7m9CrK4U2E5KakOZrBtqvYpaZUISw_SDQ?alt=json&key=AIzaSyDD1KgLzMRUaNIUQ4yys7GyNDaVh8S4b1w",Method.Get);
            RestResponse response = client.Execute(request);
            dynamic json = Newtonsoft.Json.Linq.JObject.Parse(response.Content);
            if (json == null)
                return null;
            if (json["sheets"] == null)
                return null;

            int nbSheets = json["sheets"].Count;
            List<string> list = new List<string>();
            for (int i = 0; i < nbSheets; i++)
            {
                var title = json["sheets"][i]["properties"]["title"].Value;
                list.Add(title);
            }
            return list;
        }
        private void AddSceneToGame(List<string> listTitle)
        {
            var client = new RestClient();
            for (int i = 0; i < listTitle.Count; i++)
            {
                Scene scene = new Scene();
                game.listScenes.Add(scene);
                var requestOneSheet = new RestRequest($"https://sheets.googleapis.com/v4/spreadsheets/1Bfk2PrGBKE7m9CrK4U2E5KakOZrBtqvYpaZUISw_SDQ/values/{listTitle[i]}?alt=json&key=AIzaSyDD1KgLzMRUaNIUQ4yys7GyNDaVh8S4b1w", Method.Get);
                RestResponse responseSheet = client.Execute(requestOneSheet);
                dynamic jsonSheet = Newtonsoft.Json.Linq.JObject.Parse(responseSheet.Content);
                int nbLines = jsonSheet["values"][0].Count;
                for (int j = 0; j < nbLines; j++)
                {

                }
            }
        }
    }
}
