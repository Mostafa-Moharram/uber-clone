namespace Uber
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedPlacesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newComplaintToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getComplaintToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allComplaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintsOnADateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedPlacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectedModeToolStripMenuItem,
            this.connectedModeToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.formsToolStripMenuItem.Text = "Forms";
            this.formsToolStripMenuItem.Click += new System.EventHandler(this.formsToolStripMenuItem_Click);
            // 
            // disconnectedModeToolStripMenuItem
            // 
            this.disconnectedModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedPlacesToolStripMenuItem1});
            this.disconnectedModeToolStripMenuItem.Name = "disconnectedModeToolStripMenuItem";
            this.disconnectedModeToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.disconnectedModeToolStripMenuItem.Text = "Disconnected mode";
            // 
            // savedPlacesToolStripMenuItem1
            // 
            this.savedPlacesToolStripMenuItem1.Name = "savedPlacesToolStripMenuItem1";
            this.savedPlacesToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.savedPlacesToolStripMenuItem1.Text = "Saved places of a user";
            this.savedPlacesToolStripMenuItem1.Click += new System.EventHandler(this.savedPlacesToolStripMenuItem1_Click);
            // 
            // connectedModeToolStripMenuItem
            // 
            this.connectedModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newComplaintToolStripMenuItem1,
            this.getComplaintToolStripMenuItem1,
            this.allComplaintsToolStripMenuItem,
            this.complaintsOnADateToolStripMenuItem});
            this.connectedModeToolStripMenuItem.Name = "connectedModeToolStripMenuItem";
            this.connectedModeToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.connectedModeToolStripMenuItem.Text = "Connected mode";
            // 
            // newComplaintToolStripMenuItem1
            // 
            this.newComplaintToolStripMenuItem1.Name = "newComplaintToolStripMenuItem1";
            this.newComplaintToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.newComplaintToolStripMenuItem1.Text = "Create a new complaint";
            this.newComplaintToolStripMenuItem1.Click += new System.EventHandler(this.newComplaintToolStripMenuItem1_Click);
            // 
            // getComplaintToolStripMenuItem1
            // 
            this.getComplaintToolStripMenuItem1.Name = "getComplaintToolStripMenuItem1";
            this.getComplaintToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.getComplaintToolStripMenuItem1.Text = "Retrieve a complaint";
            this.getComplaintToolStripMenuItem1.Click += new System.EventHandler(this.getComplaintToolStripMenuItem1_Click);
            // 
            // allComplaintsToolStripMenuItem
            // 
            this.allComplaintsToolStripMenuItem.Name = "allComplaintsToolStripMenuItem";
            this.allComplaintsToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.allComplaintsToolStripMenuItem.Text = "All complaints by a user";
            this.allComplaintsToolStripMenuItem.Click += new System.EventHandler(this.allComplaintsToolStripMenuItem_Click);
            // 
            // complaintsOnADateToolStripMenuItem
            // 
            this.complaintsOnADateToolStripMenuItem.Name = "complaintsOnADateToolStripMenuItem";
            this.complaintsOnADateToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.complaintsOnADateToolStripMenuItem.Text = "Complaints on a date";
            this.complaintsOnADateToolStripMenuItem.Click += new System.EventHandler(this.complaintsOnADateToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedPlacesToolStripMenuItem,
            this.complaintsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // savedPlacesToolStripMenuItem
            // 
            this.savedPlacesToolStripMenuItem.Name = "savedPlacesToolStripMenuItem";
            this.savedPlacesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.savedPlacesToolStripMenuItem.Text = "Saved Places";
            this.savedPlacesToolStripMenuItem.Click += new System.EventHandler(this.savedPlacesToolStripMenuItem_Click);
            // 
            // complaintsToolStripMenuItem
            // 
            this.complaintsToolStripMenuItem.Name = "complaintsToolStripMenuItem";
            this.complaintsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.complaintsToolStripMenuItem.Text = "Complaints";
            this.complaintsToolStripMenuItem.Click += new System.EventHandler(this.complaintsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Uber";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(359, 301);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 46);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectedModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savedPlacesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectedModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newComplaintToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getComplaintToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allComplaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complaintsOnADateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savedPlacesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
    }
}

