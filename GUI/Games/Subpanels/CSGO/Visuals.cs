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
    public partial class Visuals : Form
    {
        public Visuals()
        {
            InitializeComponent();
        }

        private void lblESP_Click(object sender, EventArgs e)
        {
            lblESP.ForeColor = Color.FromArgb(3, 134, 254);
            lblChams.ForeColor = Color.White;
            lblWorld.ForeColor = Color.White;
            pnlSelection.Location = new Point(58, 114);
        }

        private void lblChams_Click(object sender, EventArgs e)
        {
            lblESP.ForeColor = Color.White;
            lblChams.ForeColor = Color.FromArgb(3, 134, 254);
            lblWorld.ForeColor = Color.White;
            pnlSelection.Location = new Point(156, 114);
        }

        private void lblWorld_Click(object sender, EventArgs e)
        {
            lblESP.ForeColor = Color.White;
            lblChams.ForeColor = Color.White;
            lblWorld.ForeColor = Color.FromArgb(3, 134, 254);
            pnlSelection.Location = new Point(266, 114);
        }
    }
}
