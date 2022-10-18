namespace Uber
{
    partial class UsersComplaintsByUserId
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
            this.complaintByUserIdGroupBox = new System.Windows.Forms.GroupBox();
            this.userIdComboBox = new System.Windows.Forms.ComboBox();
            this.showComplaintButton = new System.Windows.Forms.Button();
            this.complaintsByUserIdLabel = new System.Windows.Forms.Label();
            this.currentComplaintTextBox = new System.Windows.Forms.TextBox();
            this.complaintCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showNextButton = new System.Windows.Forms.Button();
            this.showPreviousButton = new System.Windows.Forms.Button();
            this.navigatorGroupBox = new System.Windows.Forms.GroupBox();
            this.complaintGroupBox = new System.Windows.Forms.GroupBox();
            this.answeredGroupBox = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.isAnsweredLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.complaintIdTextBox = new System.Windows.Forms.TextBox();
            this.complaintIdLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.complaintByUserIdGroupBox.SuspendLayout();
            this.navigatorGroupBox.SuspendLayout();
            this.complaintGroupBox.SuspendLayout();
            this.answeredGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // complaintByUserIdGroupBox
            // 
            this.complaintByUserIdGroupBox.Controls.Add(this.userIdComboBox);
            this.complaintByUserIdGroupBox.Controls.Add(this.showComplaintButton);
            this.complaintByUserIdGroupBox.Controls.Add(this.complaintsByUserIdLabel);
            this.complaintByUserIdGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintByUserIdGroupBox.Location = new System.Drawing.Point(60, 22);
            this.complaintByUserIdGroupBox.Name = "complaintByUserIdGroupBox";
            this.complaintByUserIdGroupBox.Size = new System.Drawing.Size(449, 69);
            this.complaintByUserIdGroupBox.TabIndex = 3;
            this.complaintByUserIdGroupBox.TabStop = false;
            this.complaintByUserIdGroupBox.Text = "Choose User ID";
            // 
            // userIdComboBox
            // 
            this.userIdComboBox.FormatString = "N0";
            this.userIdComboBox.FormattingEnabled = true;
            this.userIdComboBox.Location = new System.Drawing.Point(92, 26);
            this.userIdComboBox.Name = "userIdComboBox";
            this.userIdComboBox.Size = new System.Drawing.Size(116, 24);
            this.userIdComboBox.Sorted = true;
            this.userIdComboBox.TabIndex = 3;
            // 
            // showComplaintButton
            // 
            this.showComplaintButton.Location = new System.Drawing.Point(225, 21);
            this.showComplaintButton.Name = "showComplaintButton";
            this.showComplaintButton.Size = new System.Drawing.Size(208, 34);
            this.showComplaintButton.TabIndex = 2;
            this.showComplaintButton.Text = "Fetch Complaints";
            this.showComplaintButton.UseVisualStyleBackColor = true;
            this.showComplaintButton.Click += new System.EventHandler(this.showComplaintButton_Click);
            // 
            // complaintsByUserIdLabel
            // 
            this.complaintsByUserIdLabel.AutoSize = true;
            this.complaintsByUserIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.complaintsByUserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintsByUserIdLabel.Location = new System.Drawing.Point(14, 29);
            this.complaintsByUserIdLabel.Name = "complaintsByUserIdLabel";
            this.complaintsByUserIdLabel.Size = new System.Drawing.Size(61, 18);
            this.complaintsByUserIdLabel.TabIndex = 1;
            this.complaintsByUserIdLabel.Text = "User ID";
            // 
            // currentComplaintTextBox
            // 
            this.currentComplaintTextBox.Location = new System.Drawing.Point(119, 21);
            this.currentComplaintTextBox.Name = "currentComplaintTextBox";
            this.currentComplaintTextBox.ReadOnly = true;
            this.currentComplaintTextBox.Size = new System.Drawing.Size(54, 22);
            this.currentComplaintTextBox.TabIndex = 4;
            // 
            // complaintCountTextBox
            // 
            this.complaintCountTextBox.Location = new System.Drawing.Point(207, 21);
            this.complaintCountTextBox.Name = "complaintCountTextBox";
            this.complaintCountTextBox.ReadOnly = true;
            this.complaintCountTextBox.Size = new System.Drawing.Size(54, 22);
            this.complaintCountTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // showNextButton
            // 
            this.showNextButton.Location = new System.Drawing.Point(272, 21);
            this.showNextButton.Name = "showNextButton";
            this.showNextButton.Size = new System.Drawing.Size(89, 22);
            this.showNextButton.TabIndex = 7;
            this.showNextButton.Text = "Next";
            this.showNextButton.UseVisualStyleBackColor = true;
            this.showNextButton.Click += new System.EventHandler(this.showNextButton_Click);
            // 
            // showPreviousButton
            // 
            this.showPreviousButton.Location = new System.Drawing.Point(19, 21);
            this.showPreviousButton.Name = "showPreviousButton";
            this.showPreviousButton.Size = new System.Drawing.Size(89, 22);
            this.showPreviousButton.TabIndex = 8;
            this.showPreviousButton.Text = "Previous";
            this.showPreviousButton.UseVisualStyleBackColor = true;
            this.showPreviousButton.Click += new System.EventHandler(this.showPreviousButton_Click);
            // 
            // navigatorGroupBox
            // 
            this.navigatorGroupBox.Controls.Add(this.complaintCountTextBox);
            this.navigatorGroupBox.Controls.Add(this.showPreviousButton);
            this.navigatorGroupBox.Controls.Add(this.currentComplaintTextBox);
            this.navigatorGroupBox.Controls.Add(this.showNextButton);
            this.navigatorGroupBox.Controls.Add(this.label1);
            this.navigatorGroupBox.Location = new System.Drawing.Point(95, 97);
            this.navigatorGroupBox.Name = "navigatorGroupBox";
            this.navigatorGroupBox.Size = new System.Drawing.Size(379, 59);
            this.navigatorGroupBox.TabIndex = 9;
            this.navigatorGroupBox.TabStop = false;
            // 
            // complaintGroupBox
            // 
            this.complaintGroupBox.Controls.Add(this.answeredGroupBox);
            this.complaintGroupBox.Controls.Add(this.datePicker);
            this.complaintGroupBox.Controls.Add(this.descriptionTextBox);
            this.complaintGroupBox.Controls.Add(this.descriptionLabel);
            this.complaintGroupBox.Controls.Add(this.dateLabel);
            this.complaintGroupBox.Controls.Add(this.userIdTextBox);
            this.complaintGroupBox.Controls.Add(this.isAnsweredLabel);
            this.complaintGroupBox.Controls.Add(this.userIdLabel);
            this.complaintGroupBox.Controls.Add(this.complaintIdTextBox);
            this.complaintGroupBox.Controls.Add(this.complaintIdLabel);
            this.complaintGroupBox.Controls.Add(this.titleTextBox);
            this.complaintGroupBox.Controls.Add(this.titleLabel);
            this.complaintGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintGroupBox.Location = new System.Drawing.Point(24, 162);
            this.complaintGroupBox.Name = "complaintGroupBox";
            this.complaintGroupBox.Size = new System.Drawing.Size(517, 387);
            this.complaintGroupBox.TabIndex = 10;
            this.complaintGroupBox.TabStop = false;
            this.complaintGroupBox.Text = "Complaint";
            // 
            // answeredGroupBox
            // 
            this.answeredGroupBox.Controls.Add(this.noRadioButton);
            this.answeredGroupBox.Controls.Add(this.yesRadioButton);
            this.answeredGroupBox.Enabled = false;
            this.answeredGroupBox.Location = new System.Drawing.Point(135, 330);
            this.answeredGroupBox.Name = "answeredGroupBox";
            this.answeredGroupBox.Size = new System.Drawing.Size(135, 39);
            this.answeredGroupBox.TabIndex = 5;
            this.answeredGroupBox.TabStop = false;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Checked = true;
            this.noRadioButton.Location = new System.Drawing.Point(78, 12);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(48, 20);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(5, 12);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(55, 20);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd/MM/yyyy";
            this.datePicker.Enabled = false;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(135, 241);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(114, 22);
            this.datePicker.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(135, 108);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(362, 114);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionLabel.Location = new System.Drawing.Point(17, 108);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(88, 18);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateLabel.Location = new System.Drawing.Point(17, 243);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 18);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTextBox.Location = new System.Drawing.Point(135, 281);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.ReadOnly = true;
            this.userIdTextBox.Size = new System.Drawing.Size(114, 22);
            this.userIdTextBox.TabIndex = 1;
            this.userIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // isAnsweredLabel
            // 
            this.isAnsweredLabel.AutoSize = true;
            this.isAnsweredLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.isAnsweredLabel.Location = new System.Drawing.Point(17, 344);
            this.isAnsweredLabel.Name = "isAnsweredLabel";
            this.isAnsweredLabel.Size = new System.Drawing.Size(101, 18);
            this.isAnsweredLabel.TabIndex = 0;
            this.isAnsweredLabel.Text = "Is Answered?";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userIdLabel.Location = new System.Drawing.Point(17, 283);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(61, 18);
            this.userIdLabel.TabIndex = 0;
            this.userIdLabel.Text = "User ID";
            // 
            // complaintIdTextBox
            // 
            this.complaintIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintIdTextBox.Location = new System.Drawing.Point(135, 32);
            this.complaintIdTextBox.Name = "complaintIdTextBox";
            this.complaintIdTextBox.ReadOnly = true;
            this.complaintIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.complaintIdTextBox.Size = new System.Drawing.Size(79, 22);
            this.complaintIdTextBox.TabIndex = 1;
            // 
            // complaintIdLabel
            // 
            this.complaintIdLabel.AutoSize = true;
            this.complaintIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.complaintIdLabel.Location = new System.Drawing.Point(17, 34);
            this.complaintIdLabel.Name = "complaintIdLabel";
            this.complaintIdLabel.Size = new System.Drawing.Size(97, 18);
            this.complaintIdLabel.TabIndex = 0;
            this.complaintIdLabel.Text = "Complaint ID";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(135, 70);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(362, 22);
            this.titleTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titleLabel.Location = new System.Drawing.Point(17, 72);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(40, 18);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // UsersComplaintsByUserId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 573);
            this.Controls.Add(this.complaintGroupBox);
            this.Controls.Add(this.navigatorGroupBox);
            this.Controls.Add(this.complaintByUserIdGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UsersComplaintsByUserId";
            this.Text = "UsersComplaintsByUserId";
            this.Load += new System.EventHandler(this.UsersComplaintsByDate_Load);
            this.complaintByUserIdGroupBox.ResumeLayout(false);
            this.complaintByUserIdGroupBox.PerformLayout();
            this.navigatorGroupBox.ResumeLayout(false);
            this.navigatorGroupBox.PerformLayout();
            this.complaintGroupBox.ResumeLayout(false);
            this.complaintGroupBox.PerformLayout();
            this.answeredGroupBox.ResumeLayout(false);
            this.answeredGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox complaintByUserIdGroupBox;
        private System.Windows.Forms.Button showComplaintButton;
        private System.Windows.Forms.Label complaintsByUserIdLabel;
        private System.Windows.Forms.TextBox currentComplaintTextBox;
        private System.Windows.Forms.TextBox complaintCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showNextButton;
        private System.Windows.Forms.Button showPreviousButton;
        private System.Windows.Forms.GroupBox navigatorGroupBox;
        private System.Windows.Forms.GroupBox complaintGroupBox;
        private System.Windows.Forms.GroupBox answeredGroupBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label isAnsweredLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox complaintIdTextBox;
        private System.Windows.Forms.Label complaintIdLabel;
        private System.Windows.Forms.ComboBox userIdComboBox;
    }
}