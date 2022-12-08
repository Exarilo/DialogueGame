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
    public partial class TestPanelOpacity : Form
    {
        public TestPanelOpacity()
        {
            InitializeComponent();
            trasnparentPanel1.BackColor = Color.FromArgb(100, 88, 44, 55);
            //panel1.BackColor = Color.FromArgb(5, 204, 212, 230);
        }

        private void TestPanelOpacity_Load(object sender, EventArgs e)
        {

        }

    }
}
