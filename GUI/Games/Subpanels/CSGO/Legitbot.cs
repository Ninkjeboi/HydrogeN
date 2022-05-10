using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialCSharp.GUI.Games.Subpanels.CSGO
{
    public partial class Legitbot : Form
    {
        public Legitbot()
        {
            InitializeComponent();
        }

        private void lblAimbot_Click(object sender, EventArgs e)
        {
            lblAimbot.ForeColor = Color.FromArgb(3, 134, 254);
            lblTriggerbot.ForeColor = Color.White;
            lblCrosshair.ForeColor = Color.White;
            pnlSelection.Location = new Point(58, 114);
        }

        private void lblTriggerbot_Click(object sender, EventArgs e)
        {
            lblAimbot.ForeColor = Color.White;
            lblTriggerbot.ForeColor = Color.FromArgb(3, 134, 254);
            lblCrosshair.ForeColor = Color.White;
            pnlSelection.Location = new Point(165, 114);
        }

        private void lblCrosshair_Click(object sender, EventArgs e)
        {
            lblAimbot.ForeColor = Color.White;
            lblTriggerbot.ForeColor = Color.White;
            lblCrosshair.ForeColor = Color.FromArgb(3, 134, 254);
            pnlSelection.Location = new Point(282, 114);
        }
    }
}
