using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuRonron
{
    public partial class SettingsControl : UserControl
    {
        private Dictionary<string, string> dictGuilds = new Dictionary<string, string>();
        private Dictionary<string, string> dictChannels = new Dictionary<string, string>();

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

        private void btAddBot_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/oauth2/authorize?client_id=1041766774422646905&permissions=8&scope=bot");
        }

        private void btDetectGuild_Click(object sender, EventArgs e)
        {
            comboGuilds.Items.Clear();
            dictGuilds.Clear();
            var client = new RestClient();
            var request = new RestRequest("https://discord.com/api/users/@me/guilds", Method.Get);
            request.AddHeader("Authorization", "Bot MTA0MTc2Njc3NDQyMjY0NjkwNQ.GzqNMJ.nanwGFdMRGY32bUz12tGAKr1-9X6652KbDQEhY");
            RestResponse response = client.Execute(request);
            try
            {
                var listDiscordGuild = JsonConvert.DeserializeObject<List<DiscordGuild>>(response.Content);

                foreach (var guild in listDiscordGuild)
                {
                    dictGuilds.Add(guild.Name, guild.Id);
                    comboGuilds.Items.Add(guild.Name);
                }
                if (comboGuilds.Items.Count > 0)
                {
                    comboGuilds.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            btImportConv.Enabled = true;
            comboChannels.Items.Clear();
            dictChannels.Clear();
            string selectedGuildId = dictGuilds[(sender as ComboBox).SelectedItem.ToString()];
            //(sender as ComboBox).SelectedItem
            var client = new RestClient();
            var request = new RestRequest($"https://discord.com/api/v10/guilds/{selectedGuildId}/channels", Method.Get);
            request.AddHeader("Authorization", "Bot MTA0MTc2Njc3NDQyMjY0NjkwNQ.GzqNMJ.nanwGFdMRGY32bUz12tGAKr1-9X6652KbDQEhY");
            RestResponse response = client.Execute(request);

            try
            {
                var listDiscordChannels = JsonConvert.DeserializeObject<List<DiscordChannel>>(response.Content);

                foreach (var channel in listDiscordChannels)
                {
                    if (channel.Type != "0")
                        continue;
                    dictChannels.Add(channel.Name, channel.Id);
                    comboChannels.Items.Add(channel.Name);
                }
                if (comboChannels.Items.Count > 0)
                {
                    comboChannels.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btImportConv_Click(object sender, EventArgs e)
        {

        }
    }
}
