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

        public void MovePictureboxToControl(PictureBox pb, Control control)
        {
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s, e) =>{
                if (pb.Location.X < control.Location.X)
                {
                    pb.Location = new Point(pb.Location.X + 5, pb.Location.Y);
                    if (pb.Location.X + pb.Width > control.Location.X)
                        timer.Stop();
                }

                else
                {
                    pb.Location = new Point(pb.Location.X - 5, pb.Location.Y);
                    if (pb.Location.X  < control.Location.X+ control.Width)
                        timer.Stop();
                }
            };
            timer.Start();
        }
        public void MakeAJump(PictureBox pb, int jumpSize,int jumpDurationMS)
        {
            Timer timer = new Timer();
            timer.Interval = 10;

            int startingPosY = pb.Location.Y;
            int nbCptLeft = jumpDurationMS / timer.Interval;
            int cptMiddleJump = nbCptLeft / 2;
            timer.Tick += (s, e) => {
                
                if(nbCptLeft > cptMiddleJump)
                    pb.Location = new Point(pb.Location.X, pb.Location.Y-(jumpSize/cptMiddleJump));
               
                else
                    pb.Location = new Point(pb.Location.X, pb.Location.Y + (jumpSize / cptMiddleJump));
                
                nbCptLeft--;
                if (nbCptLeft == 0)
                    timer.Stop();
            };
            timer.Start();
        }
        public TestPictureBoxAnimation()
        {
            InitializeComponent();
            //MovePictureboxToControl(pictureBox2, pictureBox1);
            MakeAJump(pictureBox2, 50, 100);
            //timer2.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x = pictureBox2.Location.X;
            int y = pictureBox2.Location.Y;

            pictureBox2.Location = new Point(x + 25, y);

            if (x > this.Width)
                timer2.Stop();
        }

        private void TestPictureBoxAnimation_Load(object sender, EventArgs e)
        {

            Action<string> aa = Console.WriteLine;


            Action a = Console.WriteLine;
            Action b = MessageBox.Show;
            string[] buildings = { "école", "ecole" };
            bool ContainBuilding(string message) => buildings.Any(x => message.Contains(x));

            Action c(string message) => buildings.Any(x => message.Contains(x)) ? a : b;

            c("je suis une ecole")?.Invoke();


        }
    }
}
