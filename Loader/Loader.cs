using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TutorialCSharp
{
    public partial class Loader : Form
    {
        // Rounded Edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
            );

        // Draggable Panel
        bool mouseDown;
        private Point offset;

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDescriptions.Controls.Add(childForm);
            pnlDescriptions.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void startGame()
        {
            // Games
            GUI.Games.CSGO CSGOUI = new GUI.Games.CSGO();
            GUI.Games.ROBLOX ROBLOXUI = new GUI.Games.ROBLOX();
            GUI.Games.GTA GTAUI = new GUI.Games.GTA();

            // Check lblGame game status 
            if (lblGameSelection.Text == "csgo")
            {
                CSGOUI.Show();
                this.Hide();
            }
            else if (lblGameSelection.Text == "roblox")
            {
                ROBLOXUI.Show();
                this.Hide();
            }
            else if (lblGameSelection.Text == "gta")
            {
                GTAUI.Show();
                this.Hide();
            }

        }

        public Loader()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            openChildForm(new GUI.Descriptions.CSGO());
            btnStart.BringToFront();

        }

        private void btnCSGO_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Descriptions.CSGO());
            lblGameSelection.Text = "csgo";
            btnStart.BringToFront();
        }

        private void btnRoblox_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Descriptions.ROBLOX_Description());
            lblGameSelection.Text = "roblox";
            btnStart.BringToFront();
        }

        private void btnGTA_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Descriptions.GTA_Description());
            lblGameSelection.Text = "gta";
            btnStart.BringToFront();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void pnlSelection_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - offset.X, currentPos.Y - offset.Y);
            }
        }

        private void pnlSelection_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pnlSelection_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
