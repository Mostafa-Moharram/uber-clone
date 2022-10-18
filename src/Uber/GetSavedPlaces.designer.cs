
namespace Uber
{
    partial class GetSavedPlaces
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
            this.UserId = new System.Windows.Forms.TextBox();
            this.SavedPlaces = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SavedPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(264, 30);
            this.UserId.Multiline = true;
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(240, 33);
            this.UserId.TabIndex = 0;
            this.UserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserId.TextChanged += new System.EventHandler(this.UserId_TextChanged);
            // 
            // SavedPlaces
            // 
            this.SavedPlaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SavedPlaces.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SavedPlaces.ColumnHeadersHeight = 29;
            this.SavedPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SavedPlaces.Location = new System.Drawing.Point(82, 147);
            this.SavedPlaces.Name = "SavedPlaces";
            this.SavedPlaces.RowHeadersWidth = 51;
            this.SavedPlaces.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SavedPlaces.RowTemplate.Height = 50;
            this.SavedPlaces.Size = new System.Drawing.Size(620, 192);
            this.SavedPlaces.TabIndex = 1;
            this.SavedPlaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SavedPlaces_CellContentClick);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(264, 81);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(240, 35);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Get Saved Places";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(339, 371);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(119, 41);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "User ID:";
            // 
            // GetSavedPlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SavedPlaces);
            this.Controls.Add(this.UserId);
            this.Name = "GetSavedPlaces";
            this.Text = "GetSavedPlaces";
            this.Load += new System.EventHandler(this.GetSavedPlaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SavedPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.DataGridView SavedPlaces;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
    }
}

