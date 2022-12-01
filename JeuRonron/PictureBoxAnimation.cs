using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;

namespace JeuRonron
{
    public class PictureBoxAnimation 
    {

        Action a = null;
        Action b = null;
        string[] buildings = { "école", "ecole" };
        bool ContainBuilding(string message) => buildings.Any(x => message.Contains(x));

        Action c(string message) => buildings.Any(x => message.Contains(x)) ? a : b;








        public PictureBoxAnimation()
        {
            Action a = null;
            Action b = null;
            string[] buildings = { "école", "ecole" };

            Action c(string message) => buildings.Any(x => message.Contains(x)) ? a : b;
            c("a").Invoke();
            c?.Invoke();
        }
        
        public Action MovePB
        {
            get { return movePB?.Invoke(this, new Control());  }
        }

        public Action<PictureBox, Control> movePB = (pb,control) =>
        {
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s, e) => {
                if (pb.Location.X < control.Location.X)
                {
                    pb.Location = new Point(pb.Location.X + 5, pb.Location.Y);
                    if (pb.Location.X + pb.Width > control.Location.X)
                        timer.Stop();
                }

                else
                {
                    pb.Location = new Point(pb.Location.X - 5, pb.Location.Y);
                    if (pb.Location.X < control.Location.X + control.Width)
                        timer.Stop();
                }
            };
            timer.Start();
        };

    }
}
