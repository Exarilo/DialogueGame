using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuRonron
{
    public partial class TestPictureBoxAnimation : Form
    {
        public static Action<PictureBox, Control> FirstAction { get; set; }

        /*

        Action<PictureBox, Control> Move = (pb, control) =>
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
        };*/

        public void MoveControlToControl(Control ctr, Control control)
        {
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s, e) =>{
                if (ctr.Location.X < control.Location.X)
                {
                    ctr.Location = new Point(ctr.Location.X + 5, ctr.Location.Y);
                    if (ctr.Location.X + ctr.Width > control.Location.X)
                        timer.Stop();
                }

                else
                {
                    ctr.Location = new Point(ctr.Location.X - 5, ctr.Location.Y);
                    if (ctr.Location.X  < control.Location.X+ control.Width)
                        timer.Stop();
                }
            };
            timer.Start();
        }
        public void MakeAJump(Control ctr, int jumpSize,int jumpDurationMS)
        {
            Timer timer = new Timer();
            timer.Interval = 10;

            int startingPosY = ctr.Location.Y;
            int nbCptLeft = jumpDurationMS / timer.Interval;
            int cptMiddleJump = nbCptLeft / 2;
            timer.Tick += (s, e) => {
                
                if(nbCptLeft > cptMiddleJump)
                    ctr.Location = new Point(ctr.Location.X, ctr.Location.Y-(jumpSize/cptMiddleJump));
               
                else
                    ctr.Location = new Point(ctr.Location.X, ctr.Location.Y + (jumpSize / cptMiddleJump));
                
                nbCptLeft--;
                if (nbCptLeft == 0)
                    timer.Stop();
            };
            timer.Start();
        }
        public TestPictureBoxAnimation()
        {
            InitializeComponent();
            //MoveControlToControl(pictureBox2, pictureBox1);
            MakeAJump(pictureBox2, 150, 2000);
        }

        private void TestPictureBoxAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
