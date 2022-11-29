using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuRonron
{

    public class DiscordGuild
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public class DiscordChannel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

    }

    public class Message
    {
        public string channelName { get; set; }
        public string id { get; set; }
        public int type { get; set; }
        public string content { get; set; }
        public Author author { get; set; }
        public void SaveCharImg(string basePath)
        {
            if (author.avatar == null || author.id == null)
                return;
            var folderPath = basePath + "\\" + author.username;
            if (Directory.Exists(folderPath))
                return;

            Directory.CreateDirectory(folderPath);


            using (CustomCharImgForm form = new CustomCharImgForm($"https://cdn.discordapp.com/avatars/{author.id}/{author.avatar}.png?size=2048"))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    form.selectedImg.Save(folderPath + "\\" + author.username + ".jpg");
                    // wc.DownloadFileAsync(new Uri($"https://cdn.discordapp.com/avatars/{author.id}/{author.avatar}.png?size=2048"), folderPath + "\\" + author.username + ".jpg");

                }
            }

        }
        public void SaveScenario(string scenarioPath)
        {
            File.AppendAllText(scenarioPath, $"[{author.username}]{content}{Environment.NewLine}", Encoding.UTF8);

        }
    }
    public class Author
    {
        public string id { get; set; }
        public string username { get; set; }
        public string avatar { get; set; }
    }
}
