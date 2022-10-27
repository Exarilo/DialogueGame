using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace JeuRonron
{
    public class Character
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Bitmap Image { get; set; }
        public List<string> Dialogues { get; set; } = new List<string>();

        public Character(string name)
        {
            this.Name = name;
        }
        
        public Character(string path,Bitmap image)
        {
            this.Image = image;
            this.Path = path;
            this.Name = path.Split('\\').Last().Trim();
            if (this.Name.Contains('.'))
            {
                this.Name = this.Name.Split('.')[0];
            }
        }
        public static void Load(Character character)
        {

        }
    }
}
