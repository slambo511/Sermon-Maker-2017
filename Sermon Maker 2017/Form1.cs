using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sermon_Maker_2017
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            btnGetStarted.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGetStarted.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {

        }
    }
}
