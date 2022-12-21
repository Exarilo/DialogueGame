using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuRonron
{
    public partial class Bulle : Panel
    {
        public Panel panelNameChar { get; set; } = new Panel();
        const int WS_EX_DLGMODALFRAME = 0x00000001;
        private const int WS_EX_TRANSPARENT = 0x20;
        public Message message { get; set; } = new Message();
        public bool isPanelCharNameExist { get; set; } = false;
        public string CharName { get; set; }
        private string MessageToDisplay { get; set; }
        public Button buttonNext { get; set; } = new Button();
        public Button buttonPrevious { get; set; } = new Button();


        public Bulle() : base()
        {

        }
        public Bulle(Character character) : base()
        {

            BackColor = Color.FromArgb(255, 128, 128);
            buttonNext.Text = "-->";
            buttonNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNext.Location = new Point(this.Location.X + this.Width - buttonNext.Width + 2, this.Location.Y + this.Height - buttonNext.Height + 2);


            buttonPrevious.Text = "<--";
            buttonPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPrevious.Location = new Point(this.Location.X - 2, this.Location.Y + this.Height - buttonNext.Height + 2);

            this.Controls.Add(buttonNext);
            this.Controls.Add(buttonPrevious);
            CharName = character.Name;
            this.Dock = DockStyle.Bottom;
            SetStyle(ControlStyles.Opaque, true);

            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            message = new Message();
            message.BringToFront();

            this.Controls.Add(message);

            this.Resize += (sender, e) =>
            {
                panelNameChar.Location = new Point(this.Location.X + 5, this.Location.Y - panelNameChar.Height);
            };
            var currentForm = Application.OpenForms?.Cast<Form>()?.Last();
            if(currentForm != null)
            {
                var panelCharName = currentForm?.Controls?.Find("panelCharName", true);
                if(panelCharName == null)
                {
                    AddPanelCharName(currentForm);
                    Refresh();
                }
            }


            message.Text = MessageToDisplay;

        }

        public void SetStyle(Color BulleBackColor, Color BulleTextColor, Font BulleTextFont)
        {
            if (BulleBackColor != null)
                this.BackColor = BulleBackColor;
            if (BulleTextColor != null)
                this.message.ForeColor = BulleTextColor;
            if (BulleTextFont != null)
                this.message.Font = BulleTextFont;
        }


        public void AddPanelCharName(Form currentForm)
        {
            panelNameChar = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.Fixed3D,
                Name = "panelCharName",
                Location = new Point(this.Location.X + 5, this.Location.Y - panelNameChar.Height)
            };

            using (Font font = new Font("Arial", 10, FontStyle.Bold))
            {
                Label labelCharName = new Label
                {
                    Text = CharName,
                    Font = font,
                    TextAlign = ContentAlignment.TopLeft
                };
                Size size = TextRenderer.MeasureText(labelCharName.Text, labelCharName.Font);
                panelNameChar.Size = new Size(size.Width, 20);
                panelNameChar.Controls.Add(labelCharName);
            }

            currentForm.Controls.Add(panelNameChar);
            panelNameChar.BringToFront();
            panelNameChar.Refresh();
        }

        public class Message : Label
        {
            private Timer timer;
            private int index;
            private string message;

            public Message() : base()
            {
                this.BringToFront();
                this.Font = new Font("Arial", 15, FontStyle.Bold);
                this.Dock = DockStyle.Fill;
                this.AutoSize = false;
                this.TextChanged += new EventHandler(messageChanged);

                // Initialise le timer
                timer = new Timer();
                timer.Interval = 10; // Intervalle en ms
                timer.Tick += new EventHandler(displayMessage);
            }

            protected void messageChanged(object sender, EventArgs e)
            {
                this.TextChanged -= messageChanged;

                message = (sender as Label).Text;
                this.Text = "";

                // Démarre le timer pour afficher le message
                index = 0;
                timer.Start();
            }

            private void displayMessage(object sender, EventArgs e)
            {
                // Met à jour la propriété Text avec le prochain caractère du message
                StringBuilder sb = new StringBuilder(this.Text);
                sb.Append(message[index]);
                this.Text = sb.ToString();

                // Si tous les caractères du message ont été affichés, arrête le timer
                if (++index == message.Length)
                {
                    timer.Stop();
                    this.TextChanged += new EventHandler(messageChanged);
                }
            }
        }

    }
}
