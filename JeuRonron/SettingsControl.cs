using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuRonron
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.SendToBack();
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {

        }

        private void btDiscord_Click(object sender, EventArgs e)
        {
            if (panelDiscord.Visible)
            {
                btDiscord.BackColor = default(Color);
                panelDiscord.Visible = false;
            }
            else
            {
                btAudio.BackColor = default(Color);
                btDiscord.BackColor = Color.LightGray;
                panelAudio.Visible = false;
                panelDiscord.Visible = true;
            }
        }

        private void btAudio_Click(object sender, EventArgs e)
        {
            if (panelAudio.Visible)
            {
                btAudio.BackColor = default(Color);
                panelAudio.Visible = false;
            }
            else
            {
                btDiscord.BackColor = default(Color);
                btAudio.BackColor = Color.LightGray;
                panelDiscord.Visible = false;
                panelAudio.Visible = true;
            }
                
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btVolG_Click(object sender, EventArgs e)
        {
            if(btVolG.Image != Properties.Resources.muet)
                btVolG.Image = Properties.Resources.muet;
            else
            {

            }
        }

        private void trackVolG_ValueChanged(object sender, EventArgs e)
        {
            int value = (sender as TrackBar).Value;
            if (value > 66 && value <=100)
            {
                btVolG.Image = Properties.Resources.vol3;
                return;
            }
            else if(value > 33 && value <= 66)
            {
                btVolG.Image = Properties.Resources.vol2;

                return;
            }
            else if (value>0 && value <= 33)
            {
                btVolG.Image = Properties.Resources.vol1;
                return;
            }
            else
            {
                btVolG.Image = Properties.Resources.muet;
                return;
            }
        }
    }
}
