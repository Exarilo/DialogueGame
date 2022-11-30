using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static JeuRonron.Bulle;

namespace JeuRonron
{
    public static class Tools
    {
        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }

        public static void DiscordMessagesToFile(List<Message> messages,string channelName)
        {
            var rootPath = Directory.GetCurrentDirectory() + $"\\Conversations\\{channelName}";
            var scenarioPath = rootPath + "\\Scénario.txt";
            var scenario = "";

            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }
            if (File.Exists(scenarioPath))
            {
                File.Delete(scenarioPath);
            }

            for(int i = messages.Count-1; i >= 0; i--)
            {
                messages[i].SaveCharImg(rootPath);
                if (!String.IsNullOrEmpty(messages[i].content))
                    scenario += $"[{messages[i].author.username}]{messages[i].content}{Environment.NewLine}";
            }

            File.AppendAllText(scenarioPath, scenario, Encoding.UTF8);
        }
    }
}
