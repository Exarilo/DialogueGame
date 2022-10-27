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
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Controls.OfType<PictureBox>().ToList().ForEach(control =>this.Controls.Remove(control));
            if (game.listScenes.Count > 0)
            {
                if (game.listScenes[game.currentSceneIndex].listBackground.Count > 0)
                {
                    LabelSceneName.Text=game.listScenes[game.currentSceneIndex].SceneName;
                    int randomBackgroundIndex = random.Next(game.listScenes[game.currentSceneIndex].listBackground.Count);
                    this.BackgroundImage = game.listScenes[game.currentSceneIndex].listBackground[randomBackgroundIndex].Image;
                    AddCharImg();
                    this.Refresh();
                }
            }
        }
        public void AddCharImg()
        {
            int numberOfNullCharImage = game.listScenes.Where(x => x.listChar[game.currentSceneIndex].Image == null).Count();
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
                pictureBox.Anchor =   AnchorStyles.Bottom;
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Width = PictureBoxWidth;
                pictureBox.Height = PictureBoxHeight;
                int LocationX =  50 + (PictureBoxWidth * (cptPictureInScreen));
                int LocationY = this.Height - PictureBoxHeight-btSelect.Height;
                pictureBox.Location=new Point(LocationX, LocationY);
                this.Controls.Add(pictureBox);
                cptPictureInScreen++;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.Controls.OfType<PictureBox>().ToList().ForEach(control => this.Controls.Remove(control));
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
            this.Controls.Clear();
            this.Controls.Add(game.listScenes[game.currentSceneIndex]);

        }

        private void MainForm_ControlAdded(object sender, ControlEventArgs e)
        {
            if (!(e.Control is Scene))
                return;
            //game.listScenes[game.currentSceneIndex].InitializeComponents();
        }
    }
}
