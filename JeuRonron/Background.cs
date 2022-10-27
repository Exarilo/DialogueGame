using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRonron
{
    public class Background
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Bitmap Image { get; set; }

        public Background()
        {

        }
        public Background(string path, Bitmap image)
        {
            this.Image= image;
            this.Path = path;   
            this.Name = path.Split('\\').Last().Trim();
        }
        public void Load()
        {

        }
    }
}
