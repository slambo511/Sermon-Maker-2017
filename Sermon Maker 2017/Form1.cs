using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using Sermon_Maker_2017.Properties;


namespace Sermon_Maker_2017
{
    public partial class frmSplashScreen : Form
    {
        public SoundPlayer Player = new SoundPlayer(Resources.holy);

        public frmSplashScreen()
        {
            InitializeComponent();
            btnStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Player.Play();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Player.Stop();
        }
    }
}
