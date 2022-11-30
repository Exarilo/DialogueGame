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
        public void movePictureboxToControl(PictureBox pb, Control control)
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
        public TestPictureBoxAnimation()
        {
            InitializeComponent();
            movePictureboxToControl(pictureBox2, pictureBox1);
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
    }
}
