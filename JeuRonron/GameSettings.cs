using System.IO;

namespace JeuRonron
{
    public class GameSettings
    {
        public string UnkownCharName { get; set; } = Constant.UnkownCharName;
        public string DelimiteurStartChar { get; set; } = Constant.DelimiteurStartChar;
        public string DelimiteurEndChar { get; set; } = Constant.DelimiteurEndChar;
        public string DelimiteurChoice { get; set; } = Constant.DelimiteurChoice;
        public string SetBackgroundImg { get; set; } = Constant.SetBackgroundImg;
        public string SetCharImg { get; set; } = Constant.SetCharImg;

        public GameSettings()
        {
         
        }
        public void Load()
        {
            var SettingsDirectory = Directory.GetCurrentDirectory() + "\\Conversations\\settings.txt";
            if (!File.Exists(SettingsDirectory))
                return;
            string[] lines = File.ReadAllLines(SettingsDirectory);
            //GameSettings gameSettings = new GameSettings();
            foreach (string line in lines)
            {
                if (!line.Contains(":"))
                    continue;
                if (line.Split(':')[1].Trim() == "")
                    continue;
                switch (line)
                {
                    case string UnkownCharName when UnkownCharName.Contains(Constant.InFileUnkownCharName):
                        this.UnkownCharName = line.Split(':')[1].Trim();
                        break;
                    case string DelimiteurStartChar when DelimiteurStartChar.Contains(Constant.InFileDelimiteurStartChar):
                        this.DelimiteurStartChar = line.Split(':')[1].Trim();
                        break;
                    case string DelimiteurEndChar when DelimiteurEndChar.Contains(Constant.InFileDelimiteurEndChar):
                        this.DelimiteurEndChar = line.Split(':')[1].Trim();
                        break;
                    case string DelimiteurChoice when DelimiteurChoice.Contains(Constant.InFileDelimiteurChoice):
                        this.DelimiteurChoice = line.Split(':')[1].Trim();
                        break;
                    case string SetBackgroundImg when SetBackgroundImg.Contains(Constant.InFileSetBackgroundImg):
                        this.SetBackgroundImg = line.Split(':')[1].Trim();
                        break;
                    case string SetCharImg when SetCharImg.Contains(Constant.InFileSetCharImg):
                        this.SetCharImg = line.Split(':')[1].Trim();
                        break;
                }
            }
            //var nullProperties = gameSettings.GetType().GetProperties().Where(x =>  x.GetValue(gameSettings) == null|| x.GetValue(gameSettings) == "");
        }
    }
}
