namespace Bira.TeamLeadDashBoard
{
    partial class frmTeamLeadDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeamLeadDashboard));
            this.headerstrip = new System.Windows.Forms.ToolStrip();
            this.drpdownsettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblprofile = new System.Windows.Forms.ToolStripLabel();
            this.btnProfile = new System.Windows.Forms.ToolStripButton();
            this.headerstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerstrip
            // 
            this.headerstrip.GripMargin = new System.Windows.Forms.Padding(4);
            this.headerstrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.headerstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drpdownsettings,
            this.toolStripSeparator1,
            this.lblprofile,
            this.btnProfile});
            this.headerstrip.Location = new System.Drawing.Point(0, 0);
            this.headerstrip.Name = "headerstrip";
            this.headerstrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.headerstrip.Size = new System.Drawing.Size(1924, 37);
            this.headerstrip.TabIndex = 0;
            this.headerstrip.Text = "Top Header";
            // 
            // drpdownsettings
            // 
            this.drpdownsettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drpdownsettings.Image = ((System.Drawing.Image)(resources.GetObject("drpdownsettings.Image")));
            this.drpdownsettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drpdownsettings.Name = "drpdownsettings";
            this.drpdownsettings.Padding = new System.Windows.Forms.Padding(2);
            this.drpdownsettings.Size = new System.Drawing.Size(46, 32);
            this.drpdownsettings.Text = "drpdownsettings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // lblprofile
            // 
            this.lblprofile.Name = "lblprofile";
            this.lblprofile.Padding = new System.Windows.Forms.Padding(2);
            this.lblprofile.Size = new System.Drawing.Size(66, 32);
            this.lblprofile.Text = "Profile";
            // 
            // btnProfile
            // 
            this.btnProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(2);
            this.btnProfile.Size = new System.Drawing.Size(34, 32);
            this.btnProfile.Text = "toolStripButton1";
            // 
            // frmTeamLeadDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.headerstrip);
            this.Name = "frmTeamLeadDashboard";
            this.Text = "frmTeamLeadDashboard";
            this.headerstrip.ResumeLayout(false);
            this.headerstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip headerstrip;
        private System.Windows.Forms.ToolStripDropDownButton drpdownsettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblprofile;
        private System.Windows.Forms.ToolStripButton btnProfile;
    }
}