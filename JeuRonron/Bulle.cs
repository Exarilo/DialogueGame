using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JeuRonron
{
    public partial class Bulle : Panel
    {
        public Panel panelNameChar { get; set; }
        const int WS_EX_DLGMODALFRAME = 0x00000001;
        public Message message { get; set; } = new Message();
        public bool isPanelCharNameExist { get; set; } = false;
        public string CharName { get; set; }
        private string MessageToDisplay { get; set; }

        public Bulle() : base()
        {
            
        }
        public Bulle(Character character) : base()
        {
            CharName=character.Name;    
            this.Dock = DockStyle.Bottom;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            message = new Message();

            this.Controls.Add(message);
            this.Resize += (sender, e) => {
                panelNameChar.Location = new Point(this.Location.X + 5, this.Location.Y - panelNameChar.Height);
            };
            var currentForm = Application.OpenForms.Cast<Form>().Last();
            AddPanelCharName(currentForm);
            Refresh();

            message.Text = MessageToDisplay;

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
        public void AddPanelCharName(Form currentForm)
        {
            Label labelCharName = new Label();
            labelCharName.Text = CharName;
            labelCharName.AutoSize = true;

            labelCharName.Dock = DockStyle.Fill;
            labelCharName.Font = new Font("Arial", 10, FontStyle.Bold);
            panelNameChar = new Panel();
            panelNameChar.BackColor = Color.White;
            panelNameChar.BorderStyle = BorderStyle.Fixed3D;
            panelNameChar.Name = "panelCharName";
            int labelSize = TextRenderer.MeasureText(labelCharName.Text, labelCharName.Font).Width;
            panelNameChar.Size = new Size(labelSize, 20);
            panelNameChar.Location = new Point(this.Location.X + 5, this.Location.Y - panelNameChar.Height);
            currentForm.Controls.Add(panelNameChar);
            panelNameChar.BringToFront();
            if (!String.IsNullOrEmpty(labelCharName.Text))
                panelNameChar.Controls.Add(labelCharName);
            panelNameChar.Refresh();
        }
        
        public class Message : Label
        {
            Timer t;
            private int counter;
            private bool isTyping = false;

            public Message() : base()
            {
                //this.Click += (s, e) => { this.Text = "azfazfazf"; };
                this.Font = new Font("Arial", 15, FontStyle.Bold);
                this.Dock = DockStyle.Fill;
                this.AutoSize = false;
                this.TextChanged += new EventHandler(messageChanged);

                this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
                BackColor = Color.Transparent;
            }
            protected void messageChanged(object sender, EventArgs e)
            {
                this.TextChanged -= messageChanged;
                string message = (sender as Label).Text;
                this.Text = "";
                Refresh();
                if (isTyping)
                {
                    t.Stop();
                    this.TextChanged += new EventHandler(messageChanged);
                }
                counter = 0;
                t = new Timer();
                t.Interval = 10;
                t.Tick += (sender2, e2) => timer_Tick(sender, e, message);
                t.Start();
            }
            void timer_Tick(object sender, EventArgs e, string message)
            {
                if (!message.StartsWith(this.Text))
                {
                    //this.Text = "";
                    this.Refresh();
                    counter = 0;
                }
                if (this.Text.Length < message.Length)
                {
                    isTyping = true;
                    Text += message[counter];
                    counter++;
                    Refresh();
                    return;
                }
                t.Stop();
                isTyping = false;
                this.TextChanged += new EventHandler(messageChanged);
            }
        }
    }
    
}
