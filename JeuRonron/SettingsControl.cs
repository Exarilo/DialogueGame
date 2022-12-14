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
        private Image lastVolGImgBeforeMute = Properties.Resources.vol2;
        private Image lastVolBImgBeforeMute = Properties.Resources.vol2;



        public SettingsControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.SendToBack();
            btVolG.Tag = "";
            btVolB.Tag = "";
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {

        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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
            request.AddHeader("Authorization", "Bot MTA0MTc2Njc3NDQyMjY0NjkwNQ.G19ZIh.3MZvsGV63YD_WQywUqamBszHwUSe9vcFs5y7pg");
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
            request.AddHeader("Authorization", "Bot MTA0MTc2Njc3NDQyMjY0NjkwNQ.G19ZIh.3MZvsGV63YD_WQywUqamBszHwUSe9vcFs5y7pg");
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
            try
            {
                string selectedChannel = dictChannels[comboChannels.SelectedItem.ToString()];
                var client = new RestClient();
                var request = new RestRequest($"https://discord.com/api/v9/channels/{selectedChannel}/messages", Method.Get);
                request.AddHeader("Authorization", "Bot MTA0MTc2Njc3NDQyMjY0NjkwNQ.G19ZIh.3MZvsGV63YD_WQywUqamBszHwUSe9vcFs5y7pg");

                RestResponse response = client.Execute(request);
                var messages = JsonConvert.DeserializeObject<List<Message>>(response.Content);

                Tools.DiscordMessagesToFile(messages, comboChannels.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackVolB_ValueChanged(object sender, EventArgs e)
        {
            int value = (sender as TrackBar).Value;
            labVolB.Text = value.ToString();
            if (value > 66 && value <= 100)
            {
                btVolB.BackgroundImage = Properties.Resources.vol3;
                return;
            }
            else if (value > 33 && value <= 66)
            {
                btVolB.BackgroundImage = Properties.Resources.vol2;
                return;
            }
            else if (value > 0 && value <= 33)
            {
                btVolB.BackgroundImage = Properties.Resources.vol1;
                return;
            }
            else
            {
                btVolB.BackgroundImage = Properties.Resources.muet;
                return;
            }
        }

        private void trackVolG_ValueChanged(object sender, EventArgs e)
        {
            int value = (sender as TrackBar).Value;
            labVolG.Text = value.ToString();
            if (value > 66 && value <= 100)
            {
                btVolG.BackgroundImage = Properties.Resources.vol3;
                return;
            }
            else if (value > 33 && value <= 66)
            {
                btVolG.BackgroundImage = Properties.Resources.vol2;


                return;
            }
            else if (value > 0 && value <= 33)
            {
                btVolG.BackgroundImage = Properties.Resources.vol1;
                return;
            }
            else
            {
                btVolG.BackgroundImage = Properties.Resources.muet;
                return;
            }
        }

        private void btVolB_Click(object sender, EventArgs e)
        {
            if (btVolB.Tag.ToString() != "mute")
            {
                lastVolBImgBeforeMute = btVolB.BackgroundImage;
                btVolB.Tag = "mute";
                btVolB.BackgroundImage = Properties.Resources.muet;
            }

            else
            {
                btVolB.Tag = "";
                btVolB.BackgroundImage = lastVolBImgBeforeMute;
            }
        }
        private void btVolG_Click(object sender, EventArgs e)
        {
            if (btVolG.Tag.ToString() != "mute")
            {
                lastVolGImgBeforeMute = btVolG.BackgroundImage;
                btVolG.Tag = "mute";
                btVolG.BackgroundImage = Properties.Resources.muet;
            }

            else
            {
                btVolG.Tag = "";
                btVolG.BackgroundImage = lastVolGImgBeforeMute;
            }
        }

        private void btSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = panelChatColor.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                panelChatColor.BackColor = colorDialog1.Color;
        }

        private void btFontText_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = labelText.Font;
            fontDialog1.Color = labelText.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                labelText.Font = fontDialog1.Font;
                labelText.ForeColor = fontDialog1.Color;
            }
        }
    }
}
