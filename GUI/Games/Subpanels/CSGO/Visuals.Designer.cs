
namespace TutorialCSharp.GUI.Games.Subpanels.CSGO
{
    partial class Visuals
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
            this.lblWorld = new System.Windows.Forms.Label();
            this.lblChams = new System.Windows.Forms.Label();
            this.lblESP = new System.Windows.Forms.Label();
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
            this.lblFeature.Size = new System.Drawing.Size(92, 34);
            this.lblFeature.TabIndex = 1;
            this.lblFeature.Text = "Visuals";
            // 
            // lblWorld
            // 
            this.lblWorld.AutoSize = true;
            this.lblWorld.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorld.ForeColor = System.Drawing.Color.White;
            this.lblWorld.Location = new System.Drawing.Point(259, 85);
            this.lblWorld.Name = "lblWorld";
            this.lblWorld.Size = new System.Drawing.Size(59, 26);
            this.lblWorld.TabIndex = 6;
            this.lblWorld.Text = "World";
            this.lblWorld.Click += new System.EventHandler(this.lblWorld_Click);
            // 
            // lblChams
            // 
            this.lblChams.AutoSize = true;
            this.lblChams.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChams.ForeColor = System.Drawing.Color.White;
            this.lblChams.Location = new System.Drawing.Point(144, 85);
            this.lblChams.Name = "lblChams";
            this.lblChams.Size = new System.Drawing.Size(70, 26);
            this.lblChams.TabIndex = 5;
            this.lblChams.Text = "Chams";
            this.lblChams.Click += new System.EventHandler(this.lblChams_Click);
            // 
            // lblESP
            // 
            this.lblESP.AutoSize = true;
            this.lblESP.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblESP.Location = new System.Drawing.Point(58, 85);
            this.lblESP.Name = "lblESP";
            this.lblESP.Size = new System.Drawing.Size(44, 26);
            this.lblESP.TabIndex = 4;
            this.lblESP.Text = "ESP";
            this.lblESP.Click += new System.EventHandler(this.lblESP_Click);
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.pnlSelection.Location = new System.Drawing.Point(58, 114);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(45, 1);
            this.pnlSelection.TabIndex = 7;
            // 
            // Visuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(584, 529);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.lblWorld);
            this.Controls.Add(this.lblChams);
            this.Controls.Add(this.lblESP);
            this.Controls.Add(this.lblFeature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visuals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visuals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.Label lblWorld;
        private System.Windows.Forms.Label lblChams;
        private System.Windows.Forms.Label lblESP;
        private System.Windows.Forms.Panel pnlSelection;
    }
}