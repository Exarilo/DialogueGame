using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JeuRonron.Scene;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace JeuRonron
{
    //AJOUTER README DANS LES FOLDERS
    //REMOVE BACKGROUND
    //PERMETTRE DE CHANGER COULEUR DU BACKGROUND SI PAS DE SOLUTIONS
    //GraphicComponents FOLDER
    //Settings.txt SI DELIMITEUR DEBUT == DELIMITEUR FIN
    //Splash Screen

    public partial class MainForm : Form
    {
        public static Game game;
        private CharSelectionControl charSelectionControl ;
        private SettingsControl settingsControl;
        public MainForm()
        {
            InitializeComponent();
            LoadForm();

            //btPrevious.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\GraphicComponents\\button_previous.png");
            //btNext.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\GraphicComponents\\button_next.png");
        }
        public void LoadForm()
        {
            this.Controls.Clear();
            charSelectionControl = new CharSelectionControl();
            settingsControl = new SettingsControl();
            settingsControl.SendToBack();
            this.Controls.Add(charSelectionControl);
            this.Controls.Add(settingsControl);
            game = new Game();
            game.Load();
            if (game.listScenes.Count == 0)
            {
                charSelectionControl.Visible = false;
                return;
            }

            this.ControlAdded += async (se, ev) =>
            {
                if (ev.Control is Scene)
                {
                    await (ev.Control as Scene).DoDialag();
                    LoadForm();
                }
            };




            charSelectionControl.AddCharacters(game.listScenes[game.currentSceneIndex].listChar);
            charSelectionControl.ButtonNext.Click += BtNextClick;
            charSelectionControl.ButtonPrevious.Click += BtPreviousClick;
            charSelectionControl.ButtonSelect.Click += BtSelectClick;
            charSelectionControl.ButtonSettings.Click += BtSettingsClick;
            this.Refresh();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

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
            if (game.currentSceneIndex < game.listScenes.Count-1)
                game.currentSceneIndex++;

            else
                game.currentSceneIndex = 0;

            charSelectionControl.SwapCharacters(game.listScenes[game.currentSceneIndex].listChar);
        }
        private void BtPreviousClick(object sender, EventArgs e)
        {
            if (game.currentSceneIndex > 0)
                game.currentSceneIndex--;

            else
                game.currentSceneIndex = game.listScenes.Count-1;

            charSelectionControl.SwapCharacters(game.listScenes[game.currentSceneIndex].listChar);
        }

        private void BtSelectClick(object sender, EventArgs e)
        {
            this.Text = game.listScenes[game.currentSceneIndex].SceneName;
            charSelectionControl.Visible = false;
            this.Controls.Add(game.listScenes[game.currentSceneIndex]);

        }
        public void ReturnToCharSelection()
        {
            this.Controls.OfType<Scene>().ToList().ForEach(x => x.Dispose());
            
        }

    }
}