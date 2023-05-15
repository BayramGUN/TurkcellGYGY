namespace Movies.Forms
{
    partial class FormDirectors
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
            splitContainer1 = new SplitContainer();
            goMovies = new Button();
            titleLabel = new Label();
            addDirectorButton = new Button();
            directorInfoLabel = new Label();
            directorLastnameLabel = new Label();
            directorNameLabel = new Label();
            directorInfo = new TextBox();
            directorLastname = new TextBox();
            directorName = new TextBox();
            directorsGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)directorsGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(goMovies);
            splitContainer1.Panel1.Controls.Add(titleLabel);
            splitContainer1.Panel1.Controls.Add(addDirectorButton);
            splitContainer1.Panel1.Controls.Add(directorInfoLabel);
            splitContainer1.Panel1.Controls.Add(directorLastnameLabel);
            splitContainer1.Panel1.Controls.Add(directorNameLabel);
            splitContainer1.Panel1.Controls.Add(directorInfo);
            splitContainer1.Panel1.Controls.Add(directorLastname);
            splitContainer1.Panel1.Controls.Add(directorName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(directorsGridView);
            splitContainer1.Size = new Size(1087, 455);
            splitContainer1.SplitterDistance = 394;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // goMovies
            // 
            goMovies.Location = new Point(17, 20);
            goMovies.Margin = new Padding(4, 5, 4, 5);
            goMovies.Name = "goMovies";
            goMovies.Size = new Size(107, 38);
            goMovies.TabIndex = 4;
            goMovies.Text = "Filmler";
            goMovies.UseVisualStyleBackColor = true;
            goMovies.Click += goMovies_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = SystemColors.Control;
            titleLabel.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleLabel.Location = new Point(86, 52);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(240, 51);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Yönetmen Ekle";
            // 
            // addDirectorButton
            // 
            addDirectorButton.Location = new Point(149, 345);
            addDirectorButton.Margin = new Padding(4, 5, 4, 5);
            addDirectorButton.Name = "addDirectorButton";
            addDirectorButton.Size = new Size(179, 38);
            addDirectorButton.TabIndex = 2;
            addDirectorButton.Text = "Yönetmen Ekle";
            addDirectorButton.UseVisualStyleBackColor = true;
            addDirectorButton.Click += addDirectorButton_Click;
            // 
            // directorInfoLabel
            // 
            directorInfoLabel.AutoSize = true;
            directorInfoLabel.Location = new Point(17, 265);
            directorInfoLabel.Margin = new Padding(4, 0, 4, 0);
            directorInfoLabel.Name = "directorInfoLabel";
            directorInfoLabel.Size = new Size(44, 25);
            directorInfoLabel.TabIndex = 1;
            directorInfoLabel.Text = "Info";
            // 
            // directorLastnameLabel
            // 
            directorLastnameLabel.AutoSize = true;
            directorLastnameLabel.Location = new Point(17, 217);
            directorLastnameLabel.Margin = new Padding(4, 0, 4, 0);
            directorLastnameLabel.Name = "directorLastnameLabel";
            directorLastnameLabel.Size = new Size(62, 25);
            directorLastnameLabel.TabIndex = 1;
            directorLastnameLabel.Text = "Soyad";
            // 
            // directorNameLabel
            // 
            directorNameLabel.AutoSize = true;
            directorNameLabel.Location = new Point(17, 168);
            directorNameLabel.Margin = new Padding(4, 0, 4, 0);
            directorNameLabel.Name = "directorNameLabel";
            directorNameLabel.Size = new Size(35, 25);
            directorNameLabel.TabIndex = 1;
            directorNameLabel.Text = "Ad";
            // 
            // directorInfo
            // 
            directorInfo.Location = new Point(86, 260);
            directorInfo.Margin = new Padding(4, 5, 4, 5);
            directorInfo.Name = "directorInfo";
            directorInfo.Size = new Size(240, 31);
            directorInfo.TabIndex = 0;
            // 
            // directorLastname
            // 
            directorLastname.Location = new Point(86, 212);
            directorLastname.Margin = new Padding(4, 5, 4, 5);
            directorLastname.Name = "directorLastname";
            directorLastname.Size = new Size(240, 31);
            directorLastname.TabIndex = 0;
            // 
            // directorName
            // 
            directorName.Location = new Point(86, 163);
            directorName.Margin = new Padding(4, 5, 4, 5);
            directorName.Name = "directorName";
            directorName.Size = new Size(240, 31);
            directorName.TabIndex = 0;
            // 
            // directorsGridView
            // 
            directorsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            directorsGridView.Location = new Point(4, 0);
            directorsGridView.Margin = new Padding(4, 5, 4, 5);
            directorsGridView.Name = "directorsGridView";
            directorsGridView.RowHeadersWidth = 62;
            directorsGridView.RowTemplate.Height = 25;
            directorsGridView.Size = new Size(872, 462);
            directorsGridView.TabIndex = 0;
            // 
            // FormDirectors
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 455);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormDirectors";
            Text = "FormDirectors";
            Load += FormDirectors_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)directorsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView directorsGridView;
        private Label titleLabel;
        private Button addDirectorButton;
        private Label directorInfoLabel;
        private Label directorLastnameLabel;
        private Label directorNameLabel;
        private TextBox directorInfo;
        private TextBox directorLastname;
        private TextBox directorName;
        private Button goMovies;
    }
}