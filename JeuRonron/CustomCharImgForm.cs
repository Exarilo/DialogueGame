using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuRonron
{
    public partial class CustomCharImgForm : Form
    {
        public Image selectedImg { get; set; }
        public Bitmap bitmapToTransform { get; set; }
         
        public CustomCharImgForm()
        {
            InitializeComponent();
        }
        public CustomCharImgForm(string imgUri) 
        {
            InitializeComponent();
            pbChar.SizeMode = PictureBoxSizeMode.StretchImage;
            var request = WebRequest.Create(imgUri);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pbChar.Image = Bitmap.FromStream(stream);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {

            }
            //textBox1.BackColor = MyDialog.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.selectedImg = new Bitmap(pbChar.Image);  ;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bitmapToTransform = new Bitmap(pbChar.Image);
            bitmapToTransform.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbChar.Image= bitmapToTransform;
        }
    }
}
