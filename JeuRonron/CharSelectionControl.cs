using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuRonron
{
    public partial class CharSelectionControl : UserControl
    {
        private int _colorCounter = 250;

        [Description("Get the central panel"), Category("Data")]
        public Panel PanelChar
        {
            get => panelChar;
            set => panelChar= value;
        }
        [Description("Get the background panel"), Category("Data")]
        public Panel PanelBackground
        {
            get => panelBackground;
            set => panelBackground = value;
        }

        [Description("Button Settings"), Category("Data")]
        public PictureBox ButtonSettings
        {
            get => btSettings;
            set => btSettings = value;
        }
        [Description("Button Next"), Category("Data")]
        public RoundButton ButtonNext
        {
            get => buttonNext;
            set => buttonNext = value;
        }
        [Description("Button Previous"), Category("Data")]
        public RoundButton ButtonPrevious
        {
            get => buttonPrevious;
            set => buttonPrevious = value;
        }
       
        [Description("Button Select"), Category("Data")]
        public Button ButtonSelect
        {
            get => btSelect;
            set => btSelect = value;
        }

        public CharSelectionControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            btSettings.BackColor = Color.Transparent;
            panelLeft.BackColor = Color.Transparent;
            panelRight.BackColor = Color.Transparent;
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
            panelChar.BringToFront();
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
        public void SwapCharacters(List<Character> characters)
        {
            panelChar.Controls.Clear();
            AddCharacters(characters);
        }
        public void AddCharacters(List<Character> characters)
        {
            var charactersWithImages = characters.Where(x => x.Image != null).ToList();
            int numberOfImageToDisplay = charactersWithImages.Count();
            if (numberOfImageToDisplay == 0)
                return;

            if (numberOfImageToDisplay > 2)   
                panelChar.Size = new Size(panelChar.Width,panelChar.Width/numberOfImageToDisplay);

            
            if (numberOfImageToDisplay == 1)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
                pictureBox.BackgroundImage = characters[0].Image;
                pictureBox.BackgroundImageLayout= ImageLayout.Stretch;
                pictureBox.Size = new Size(panelChar.Height, panelChar.Height);
                pictureBox.Location = new Point(panelChar.Height / 2, 0);
                panelChar.Controls.Add(pictureBox);
                panelChar.Refresh();

            }
            else
            {
                int locationX = 0;
                foreach (var @char in charactersWithImages)
                {
                    PictureBox pictureBox2 = new PictureBox();
                    pictureBox2.BackgroundImage = @char.Image;
                    pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.Size = new Size(panelChar.Height, panelChar.Height);
                    panelChar.Controls.Add(pictureBox2);
                    pictureBox2.Location = new Point(locationX, 0);
                    locationX += panelChar.Width / numberOfImageToDisplay;
                    panelChar.Refresh();
                }
            }
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            //SettingsForm settingsForm = new SettingsForm();
            //settingsForm.ShowDialog();
        }
    }
}
