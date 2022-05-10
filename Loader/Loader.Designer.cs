
namespace TutorialCSharp
{
    partial class Loader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnGTA = new FontAwesome.Sharp.IconButton();
            this.btnRoblox = new FontAwesome.Sharp.IconButton();
            this.btnCSGO = new FontAwesome.Sharp.IconButton();
            this.pnlDescriptions = new System.Windows.Forms.Panel();
            this.btnStart = new FontAwesome.Sharp.IconButton();
            this.lblGameSelection = new System.Windows.Forms.Label();
            this.ptbProfile = new TutorialCSharp.Classes.roundedPicturebox();
            this.pnlSelection.SuspendLayout();
            this.pnlDescriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlSelection.Controls.Add(this.lblStatus);
            this.pnlSelection.Controls.Add(this.lblName);
            this.pnlSelection.Controls.Add(this.ptbProfile);
            this.pnlSelection.Controls.Add(this.lblLogo);
            this.pnlSelection.Controls.Add(this.btnGTA);
            this.pnlSelection.Controls.Add(this.btnRoblox);
            this.pnlSelection.Controls.Add(this.btnCSGO);
            this.pnlSelection.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSelection.Location = new System.Drawing.Point(0, 0);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(139, 342);
            this.pnlSelection.TabIndex = 0;
            this.pnlSelection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSelection_MouseDown);
            this.pnlSelection.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSelection_MouseMove);
            this.pnlSelection.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlSelection_MouseUp);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(184)))), ((int)(((byte)(231)))));
            this.lblStatus.Location = new System.Drawing.Point(58, 309);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 18);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Undetected";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblName.Location = new System.Drawing.Point(58, 290);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 21);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Synack";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblLogo.Location = new System.Drawing.Point(3, 19);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(135, 34);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "HydrogeN²";
            // 
            // btnGTA
            // 
            this.btnGTA.FlatAppearance.BorderSize = 0;
            this.btnGTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGTA.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGTA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.btnGTA.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btnGTA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.btnGTA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGTA.IconSize = 35;
            this.btnGTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGTA.Location = new System.Drawing.Point(3, 165);
            this.btnGTA.Name = "btnGTA";
            this.btnGTA.Size = new System.Drawing.Size(133, 43);
            this.btnGTA.TabIndex = 2;
            this.btnGTA.Text = "GTA V";
            this.btnGTA.UseVisualStyleBackColor = true;
            this.btnGTA.Click += new System.EventHandler(this.btnGTA_Click);
            // 
            // btnRoblox
            // 
            this.btnRoblox.FlatAppearance.BorderSize = 0;
            this.btnRoblox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoblox.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoblox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.btnRoblox.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnRoblox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.btnRoblox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoblox.IconSize = 35;
            this.btnRoblox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoblox.Location = new System.Drawing.Point(3, 116);
            this.btnRoblox.Name = "btnRoblox";
            this.btnRoblox.Size = new System.Drawing.Size(133, 43);
            this.btnRoblox.TabIndex = 1;
            this.btnRoblox.Text = "ROBLOX";
            this.btnRoblox.UseVisualStyleBackColor = true;
            this.btnRoblox.Click += new System.EventHandler(this.btnRoblox_Click);
            // 
            // btnCSGO
            // 
            this.btnCSGO.FlatAppearance.BorderSize = 0;
            this.btnCSGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSGO.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSGO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.btnCSGO.IconChar = FontAwesome.Sharp.IconChar.Bomb;
            this.btnCSGO.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.btnCSGO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCSGO.IconSize = 35;
            this.btnCSGO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCSGO.Location = new System.Drawing.Point(3, 67);
            this.btnCSGO.Name = "btnCSGO";
            this.btnCSGO.Size = new System.Drawing.Size(133, 43);
            this.btnCSGO.TabIndex = 0;
            this.btnCSGO.Text = "CS:GO";
            this.btnCSGO.UseVisualStyleBackColor = true;
            this.btnCSGO.Click += new System.EventHandler(this.btnCSGO_Click);
            // 
            // pnlDescriptions
            // 
            this.pnlDescriptions.Controls.Add(this.btnStart);
            this.pnlDescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescriptions.Location = new System.Drawing.Point(139, 0);
            this.pnlDescriptions.Name = "pnlDescriptions";
            this.pnlDescriptions.Size = new System.Drawing.Size(440, 342);
            this.pnlDescriptions.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.btnStart.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnStart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.btnStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStart.IconSize = 29;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStart.Location = new System.Drawing.Point(155, 287);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 43);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblGameSelection
            // 
            this.lblGameSelection.AutoSize = true;
            this.lblGameSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblGameSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblGameSelection.Location = new System.Drawing.Point(17, 274);
            this.lblGameSelection.Name = "lblGameSelection";
            this.lblGameSelection.Size = new System.Drawing.Size(30, 13);
            this.lblGameSelection.TabIndex = 8;
            this.lblGameSelection.Text = "csgo";
            // 
            // ptbProfile
            // 
            this.ptbProfile.Image = ((System.Drawing.Image)(resources.GetObject("ptbProfile.Image")));
            this.ptbProfile.Location = new System.Drawing.Point(12, 290);
            this.ptbProfile.Name = "ptbProfile";
            this.ptbProfile.Size = new System.Drawing.Size(40, 40);
            this.ptbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProfile.TabIndex = 4;
            this.ptbProfile.TabStop = false;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(579, 342);
            this.Controls.Add(this.lblGameSelection);
            this.Controls.Add(this.pnlDescriptions);
            this.Controls.Add(this.pnlSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlSelection.ResumeLayout(false);
            this.pnlSelection.PerformLayout();
            this.pnlDescriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSelection;
        private FontAwesome.Sharp.IconButton btnCSGO;
        private System.Windows.Forms.Label lblLogo;
        private FontAwesome.Sharp.IconButton btnGTA;
        private FontAwesome.Sharp.IconButton btnRoblox;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblName;
        private Classes.roundedPicturebox ptbProfile;
        private System.Windows.Forms.Panel pnlDescriptions;
        private FontAwesome.Sharp.IconButton btnStart;
        private System.Windows.Forms.Label lblGameSelection;
    }
}

