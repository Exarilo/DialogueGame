using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuRonron
{
    public partial class DiscordForm : Form
    {
        private Dictionary<string, string> dictGuilds = new Dictionary<string, string>();
        private Dictionary<string, string> dictChannels = new Dictionary<string, string>();


        







        public DiscordForm()
        {
            InitializeComponent();
        }

        private void DiscordForm_Load(object sender, EventArgs e)
        {


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
            request.AddHeader("Authorization", ConfigurationManager.AppSettings["token"]);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboGuilds_SelectedIndexChanged(object sender, EventArgs e)
        {
            btImportConv.Enabled = true;
            comboChannels.Items.Clear();
            dictChannels.Clear();
            string selectedGuildId = dictGuilds[(sender as ComboBox).SelectedItem.ToString()];
            //(sender as ComboBox).SelectedItem
            var client = new RestClient();
            var request = new RestRequest($"https://discord.com/api/v10/guilds/{selectedGuildId}/channels", Method.Get);
            request.AddHeader("Authorization", ConfigurationManager.AppSettings["token"]);
            RestResponse response = client.Execute(request);

            try
            {
                var listDiscordChannels = JsonConvert.DeserializeObject<List<DiscordChannel>>(response.Content);

                foreach (var channel in listDiscordChannels)
                {
                    if (channel.Type!="0")
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
        
            string selectedChannel = dictChannels[comboChannels.SelectedItem.ToString()];
            var client = new RestClient();
            var request = new RestRequest($"https://discord.com/api/v9/channels/{selectedChannel}/messages", Method.Get);
            request.AddHeader("Authorization",  ConfigurationManager.AppSettings["token"]);

            RestResponse response = client.Execute(request);
            var myDeserializedClass = JsonConvert.DeserializeObject<List<Message>>(response.Content);
            //https://cdn.discordapp.com/avatars/[id]/[avatar].png?size=2048
        }
    }
}





