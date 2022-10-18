namespace Uber
{
    partial class ComplaintsReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.start_date_txt = new System.Windows.Forms.TextBox();
            this.end_date_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.complaints_report_viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(176, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start date:";
            // 
            // start_date_txt
            // 
            this.start_date_txt.Location = new System.Drawing.Point(249, 22);
            this.start_date_txt.Name = "start_date_txt";
            this.start_date_txt.Size = new System.Drawing.Size(100, 22);
            this.start_date_txt.TabIndex = 1;
            // 
            // end_date_txt
            // 
            this.end_date_txt.Location = new System.Drawing.Point(467, 22);
            this.end_date_txt.Name = "end_date_txt";
            this.end_date_txt.Size = new System.Drawing.Size(100, 22);
            this.end_date_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "End date:";
            // 
            // complaints_report_viewer
            // 
            this.complaints_report_viewer.ActiveViewIndex = -1;
            this.complaints_report_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.complaints_report_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.complaints_report_viewer.Location = new System.Drawing.Point(3, 107);
            this.complaints_report_viewer.Name = "complaints_report_viewer";
            this.complaints_report_viewer.Size = new System.Drawing.Size(793, 339);
            this.complaints_report_viewer.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComplaintsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.complaints_report_viewer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.end_date_txt);
            this.Controls.Add(this.start_date_txt);
            this.Controls.Add(this.label1);
            this.Name = "ComplaintsReportForm";
            this.Text = "ComplaintsReportForm";
            this.Load += new System.EventHandler(this.ComplaintsReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox start_date_txt;
        private System.Windows.Forms.TextBox end_date_txt;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer complaints_report_viewer;
        private System.Windows.Forms.Button button1;
    }
}