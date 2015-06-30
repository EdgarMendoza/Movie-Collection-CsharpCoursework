namespace Movie_Collection
{
    partial class Form1
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
            this.directoryLabel = new System.Windows.Forms.Label();
            this.filePathTxtBox = new System.Windows.Forms.TextBox();
            this.readDataButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTxtBox = new System.Windows.Forms.TextBox();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.runtimeTxtBox = new System.Windows.Forms.TextBox();
            this.runtimeLabel = new System.Windows.Forms.Label();
            this.movieTitlesListBox = new System.Windows.Forms.ListBox();
            this.titlesListLabel = new System.Windows.Forms.Label();
            this.movieYearListBox = new System.Windows.Forms.ListBox();
            this.yearListLabel = new System.Windows.Forms.Label();
            this.movieRuntimeListBox = new System.Windows.Forms.ListBox();
            this.runtimeListBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(14, 16);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(89, 13);
            this.directoryLabel.TabIndex = 0;
            this.directoryLabel.Text = "Path to Data File:";
            // 
            // filePathTxtBox
            // 
            this.filePathTxtBox.Location = new System.Drawing.Point(109, 13);
            this.filePathTxtBox.Name = "filePathTxtBox";
            this.filePathTxtBox.Size = new System.Drawing.Size(179, 20);
            this.filePathTxtBox.TabIndex = 1;
            // 
            // readDataButton
            // 
            this.readDataButton.Location = new System.Drawing.Point(294, 12);
            this.readDataButton.Name = "readDataButton";
            this.readDataButton.Size = new System.Drawing.Size(75, 23);
            this.readDataButton.TabIndex = 2;
            this.readDataButton.Text = "Read Data";
            this.readDataButton.UseVisualStyleBackColor = true;
            this.readDataButton.Click += new System.EventHandler(this.readDataButton_Click);
            // 
            // saveDataButton
            // 
            this.saveDataButton.Location = new System.Drawing.Point(375, 12);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(75, 23);
            this.saveDataButton.TabIndex = 3;
            this.saveDataButton.Text = "Save Data";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(41, 58);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(62, 13);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Movie Title:";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(109, 55);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(179, 20);
            this.titleTxtBox.TabIndex = 5;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(368, 53);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(82, 23);
            this.addMovieButton.TabIndex = 6;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(39, 84);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(64, 13);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Movie Year:";
            // 
            // yearTxtBox
            // 
            this.yearTxtBox.Location = new System.Drawing.Point(109, 81);
            this.yearTxtBox.Name = "yearTxtBox";
            this.yearTxtBox.Size = new System.Drawing.Size(179, 20);
            this.yearTxtBox.TabIndex = 8;
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(368, 81);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(82, 23);
            this.deleteMovieButton.TabIndex = 9;
            this.deleteMovieButton.Text = "Delete Movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            this.deleteMovieButton.Click += new System.EventHandler(this.deleteMovieButton_Click);
            // 
            // runtimeTxtBox
            // 
            this.runtimeTxtBox.Location = new System.Drawing.Point(109, 107);
            this.runtimeTxtBox.Name = "runtimeTxtBox";
            this.runtimeTxtBox.Size = new System.Drawing.Size(179, 20);
            this.runtimeTxtBox.TabIndex = 10;
            // 
            // runtimeLabel
            // 
            this.runtimeLabel.AutoSize = true;
            this.runtimeLabel.Location = new System.Drawing.Point(22, 110);
            this.runtimeLabel.Name = "runtimeLabel";
            this.runtimeLabel.Size = new System.Drawing.Size(81, 13);
            this.runtimeLabel.TabIndex = 11;
            this.runtimeLabel.Text = "Movie Runtime:";
            // 
            // movieTitlesListBox
            // 
            this.movieTitlesListBox.FormattingEnabled = true;
            this.movieTitlesListBox.Location = new System.Drawing.Point(12, 166);
            this.movieTitlesListBox.Name = "movieTitlesListBox";
            this.movieTitlesListBox.Size = new System.Drawing.Size(142, 186);
            this.movieTitlesListBox.TabIndex = 12;
            // 
            // titlesListLabel
            // 
            this.titlesListLabel.AutoSize = true;
            this.titlesListLabel.Location = new System.Drawing.Point(50, 150);
            this.titlesListLabel.Name = "titlesListLabel";
            this.titlesListLabel.Size = new System.Drawing.Size(67, 13);
            this.titlesListLabel.TabIndex = 13;
            this.titlesListLabel.Text = "Movie Titles:";
            // 
            // movieYearListBox
            // 
            this.movieYearListBox.FormattingEnabled = true;
            this.movieYearListBox.Location = new System.Drawing.Point(160, 166);
            this.movieYearListBox.Name = "movieYearListBox";
            this.movieYearListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.movieYearListBox.Size = new System.Drawing.Size(142, 186);
            this.movieYearListBox.TabIndex = 14;
            // 
            // yearListLabel
            // 
            this.yearListLabel.AutoSize = true;
            this.yearListLabel.Location = new System.Drawing.Point(194, 150);
            this.yearListLabel.Name = "yearListLabel";
            this.yearListLabel.Size = new System.Drawing.Size(64, 13);
            this.yearListLabel.TabIndex = 15;
            this.yearListLabel.Text = "Movie Year:";
            // 
            // movieRuntimeListBox
            // 
            this.movieRuntimeListBox.FormattingEnabled = true;
            this.movieRuntimeListBox.Location = new System.Drawing.Point(308, 166);
            this.movieRuntimeListBox.Name = "movieRuntimeListBox";
            this.movieRuntimeListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.movieRuntimeListBox.Size = new System.Drawing.Size(142, 186);
            this.movieRuntimeListBox.TabIndex = 16;
            // 
            // runtimeListBox
            // 
            this.runtimeListBox.AutoSize = true;
            this.runtimeListBox.Location = new System.Drawing.Point(338, 150);
            this.runtimeListBox.Name = "runtimeListBox";
            this.runtimeListBox.Size = new System.Drawing.Size(81, 13);
            this.runtimeListBox.TabIndex = 17;
            this.runtimeListBox.Text = "Movie Runtime:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 361);
            this.Controls.Add(this.runtimeListBox);
            this.Controls.Add(this.movieRuntimeListBox);
            this.Controls.Add(this.yearListLabel);
            this.Controls.Add(this.movieYearListBox);
            this.Controls.Add(this.titlesListLabel);
            this.Controls.Add(this.movieTitlesListBox);
            this.Controls.Add(this.runtimeLabel);
            this.Controls.Add(this.runtimeTxtBox);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.yearTxtBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.readDataButton);
            this.Controls.Add(this.filePathTxtBox);
            this.Controls.Add(this.directoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.TextBox filePathTxtBox;
        private System.Windows.Forms.Button readDataButton;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTxtBox;
        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.TextBox runtimeTxtBox;
        private System.Windows.Forms.Label runtimeLabel;
        private System.Windows.Forms.ListBox movieTitlesListBox;
        private System.Windows.Forms.Label titlesListLabel;
        private System.Windows.Forms.ListBox movieYearListBox;
        private System.Windows.Forms.Label yearListLabel;
        private System.Windows.Forms.ListBox movieRuntimeListBox;
        private System.Windows.Forms.Label runtimeListBox;
    }
}

