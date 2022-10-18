namespace Uber
{
    partial class SavedPlacesReportForm
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
            this.saved_places_report_viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // saved_places_report_viewer
            // 
            this.saved_places_report_viewer.ActiveViewIndex = -1;
            this.saved_places_report_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saved_places_report_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.saved_places_report_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saved_places_report_viewer.Location = new System.Drawing.Point(0, 0);
            this.saved_places_report_viewer.Name = "saved_places_report_viewer";
            this.saved_places_report_viewer.Size = new System.Drawing.Size(800, 450);
            this.saved_places_report_viewer.TabIndex = 0;
            this.saved_places_report_viewer.Load += new System.EventHandler(this.saved_places_report_viewer_Load);
            // 
            // SavedPlacesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saved_places_report_viewer);
            this.Name = "SavedPlacesReportForm";
            this.Text = "SavedPlacesReportForm";
            this.Load += new System.EventHandler(this.SavedPlacesReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer saved_places_report_viewer;
    }
}