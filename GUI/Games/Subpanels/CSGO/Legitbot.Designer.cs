
namespace TutorialCSharp.GUI.Games.Subpanels.CSGO
{
    partial class Legitbot
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
            this.lblFeature = new System.Windows.Forms.Label();
            this.lblAimbot = new System.Windows.Forms.Label();
            this.lblTriggerbot = new System.Windows.Forms.Label();
            this.lblCrosshair = new System.Windows.Forms.Label();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblFeature
            // 
            this.lblFeature.AutoSize = true;
            this.lblFeature.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeature.ForeColor = System.Drawing.Color.White;
            this.lblFeature.Location = new System.Drawing.Point(41, 30);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(106, 34);
            this.lblFeature.TabIndex = 0;
            this.lblFeature.Text = "Legitbot";
            // 
            // lblAimbot
            // 
            this.lblAimbot.AutoSize = true;
            this.lblAimbot.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAimbot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblAimbot.Location = new System.Drawing.Point(47, 85);
            this.lblAimbot.Name = "lblAimbot";
            this.lblAimbot.Size = new System.Drawing.Size(71, 26);
            this.lblAimbot.TabIndex = 1;
            this.lblAimbot.Text = "Aimbot";
            this.lblAimbot.Click += new System.EventHandler(this.lblAimbot_Click);
            // 
            // lblTriggerbot
            // 
            this.lblTriggerbot.AutoSize = true;
            this.lblTriggerbot.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriggerbot.ForeColor = System.Drawing.Color.White;
            this.lblTriggerbot.Location = new System.Drawing.Point(140, 85);
            this.lblTriggerbot.Name = "lblTriggerbot";
            this.lblTriggerbot.Size = new System.Drawing.Size(99, 26);
            this.lblTriggerbot.TabIndex = 2;
            this.lblTriggerbot.Text = "Triggerbot";
            this.lblTriggerbot.Click += new System.EventHandler(this.lblTriggerbot_Click);
            // 
            // lblCrosshair
            // 
            this.lblCrosshair.AutoSize = true;
            this.lblCrosshair.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrosshair.ForeColor = System.Drawing.Color.White;
            this.lblCrosshair.Location = new System.Drawing.Point(259, 85);
            this.lblCrosshair.Name = "lblCrosshair";
            this.lblCrosshair.Size = new System.Drawing.Size(93, 26);
            this.lblCrosshair.TabIndex = 3;
            this.lblCrosshair.Text = "Crosshair";
            this.lblCrosshair.Click += new System.EventHandler(this.lblCrosshair_Click);
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.pnlSelection.Location = new System.Drawing.Point(58, 114);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(45, 1);
            this.pnlSelection.TabIndex = 4;
            // 
            // Legitbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(584, 529);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.lblCrosshair);
            this.Controls.Add(this.lblTriggerbot);
            this.Controls.Add(this.lblAimbot);
            this.Controls.Add(this.lblFeature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Legitbot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legitbot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.Label lblAimbot;
        private System.Windows.Forms.Label lblTriggerbot;
        private System.Windows.Forms.Label lblCrosshair;
        private System.Windows.Forms.Panel pnlSelection;
    }
}