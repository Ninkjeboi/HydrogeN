using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialCSharp.GUI.Games
{
    public partial class CSGO : Form
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

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public CSGO()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            openChildForm(new GUI.Games.Subpanels.CSGO.Legitbot());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Games.Subpanels.CSGO.Visuals());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.Games.Subpanels.CSGO.Legitbot());
        }
    }
}
