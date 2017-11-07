using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeteorRush
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private int page;

        private void Instructions_Load(object sender, EventArgs e)
        {
            CenterToParent();
            page = 1;
        }

        private void btnPageLeft_Click(object sender, EventArgs e)
        {
            switch (page)
            {
                case 2: PagePic.BackgroundImage = MeteorRush.Properties.Resources.InstructiuniP1; btnPageLeft.Enabled = false; page--; break;
                case 3: PagePic.BackgroundImage = MeteorRush.Properties.Resources.InstructiuniP2; btnPageRight.Enabled = true; page--; break;
            }
        }

        private void btnPageRight_Click(object sender, EventArgs e)
        {
            switch (page)
            {
                case 1: PagePic.BackgroundImage = MeteorRush.Properties.Resources.InstructiuniP2; btnPageLeft.Enabled = true; page++; break;
                case 2: PagePic.BackgroundImage = MeteorRush.Properties.Resources.InstructiuniP3; btnPageRight.Enabled = false; page++; break;
            }
        }

       


    }
}
