using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuRonron
{
    public class ActionHelper
    {
        private readonly string[] buildings = { "école", "ecole" };
        private readonly string[] positiveEmotions = { "happy", "salut", "coucou" };
        Action act = () => Console.WriteLine("test");
 

        public Action<PictureBox, Control> movePictureBox = (pb, control) =>
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




        public IEnumerable<Action> PositiveActions(string message)
        {
            List<Action> positiveActions = new List<Action>();
            Action<string> act2 = (string a) => Console.WriteLine("test");
            positiveActions.Add(act2);
            positiveActions.Add(positiveEmotions.Any(x => message.Contains(x)) ? act : null);
            foreach (var action in positiveActions)
            {
                yield return action;
            }
        }
        public void DisplayMessage<T>(T message)
        {
            if (message is string)
            {
                Console.WriteLine(message);
            }
        }


    }
}
List<Action> technicallyRedundant = new List<Action>();
technicallyRedundant.Add(() => { Console.WriteLine("Action 1"); });
technicallyRedundant.Add(() => { Console.WriteLine("Action 2"); });

foreach (var action in technicallyRedundant)
{
    action?.Invoke();
}