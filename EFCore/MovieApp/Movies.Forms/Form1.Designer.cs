namespace Movies.Forms
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
            directorsGridView = new DataGridView();
            goMovies = new Button();
            titleLabel = new Label();
            addDirectorButton = new Button();
            playerInfoLabel = new Label();
            playerLastnameLabel = new Label();
            playerNameLabel = new Label();
            playerInfo = new TextBox();
            playerLastname = new TextBox();
            playerName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)directorsGridView).BeginInit();
            SuspendLayout();
            // 
            // directorsGridView
            // 
            directorsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            directorsGridView.Location = new Point(434, -7);
            directorsGridView.Margin = new Padding(4, 5, 4, 5);
            directorsGridView.Name = "directorsGridView";
            directorsGridView.RowHeadersWidth = 62;
            directorsGridView.RowTemplate.Height = 25;
            directorsGridView.Size = new Size(574, 462);
            directorsGridView.TabIndex = 5;
            // 
            // goMovies
            // 
            goMovies.Location = new Point(29, 31);
            goMovies.Margin = new Padding(4, 5, 4, 5);
            goMovies.Name = "goMovies";
            goMovies.Size = new Size(107, 38);
            goMovies.TabIndex = 14;
            goMovies.Text = "Filmler";
            goMovies.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = SystemColors.Control;
            titleLabel.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleLabel.Location = new Point(98, 63);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(204, 51);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Oyuncu Ekle";
            // 
            // addDirectorButton
            // 
            addDirectorButton.Location = new Point(161, 356);
            addDirectorButton.Margin = new Padding(4, 5, 4, 5);
            addDirectorButton.Name = "addDirectorButton";
            addDirectorButton.Size = new Size(179, 38);
            addDirectorButton.TabIndex = 12;
            addDirectorButton.Text = "Oyuncu Ekle";
            addDirectorButton.UseVisualStyleBackColor = true;
            addDirectorButton.Click += addDirectorButton_Click;
            // 
            // playerInfoLabel
            // 
            playerInfoLabel.AutoSize = true;
            playerInfoLabel.Location = new Point(29, 276);
            playerInfoLabel.Margin = new Padding(4, 0, 4, 0);
            playerInfoLabel.Name = "playerInfoLabel";
            playerInfoLabel.Size = new Size(44, 25);
            playerInfoLabel.TabIndex = 9;
            playerInfoLabel.Text = "Info";
            // 
            // playerLastnameLabel
            // 
            playerLastnameLabel.AutoSize = true;
            playerLastnameLabel.Location = new Point(29, 228);
            playerLastnameLabel.Margin = new Padding(4, 0, 4, 0);
            playerLastnameLabel.Name = "playerLastnameLabel";
            playerLastnameLabel.Size = new Size(62, 25);
            playerLastnameLabel.TabIndex = 10;
            playerLastnameLabel.Text = "Soyad";
            // 
            // playerNameLabel
            // 
            playerNameLabel.AutoSize = true;
            playerNameLabel.Location = new Point(29, 179);
            playerNameLabel.Margin = new Padding(4, 0, 4, 0);
            playerNameLabel.Name = "playerNameLabel";
            playerNameLabel.Size = new Size(35, 25);
            playerNameLabel.TabIndex = 11;
            playerNameLabel.Text = "Ad";
            // 
            // playerInfo
            // 
            playerInfo.Location = new Point(98, 271);
            playerInfo.Margin = new Padding(4, 5, 4, 5);
            playerInfo.Name = "playerInfo";
            playerInfo.Size = new Size(240, 31);
            playerInfo.TabIndex = 6;
            // 
            // playerLastname
            // 
            playerLastname.Location = new Point(98, 223);
            playerLastname.Margin = new Padding(4, 5, 4, 5);
            playerLastname.Name = "playerLastname";
            playerLastname.Size = new Size(240, 31);
            playerLastname.TabIndex = 7;
            // 
            // playerName
            // 
            playerName.Location = new Point(98, 174);
            playerName.Margin = new Padding(4, 5, 4, 5);
            playerName.Name = "playerName";
            playerName.Size = new Size(240, 31);
            playerName.TabIndex = 8;
            playerName.TextChanged += directorName_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 452);
            Controls.Add(goMovies);
            Controls.Add(titleLabel);
            Controls.Add(addDirectorButton);
            Controls.Add(playerInfoLabel);
            Controls.Add(playerLastnameLabel);
            Controls.Add(playerNameLabel);
            Controls.Add(playerInfo);
            Controls.Add(playerLastname);
            Controls.Add(playerName);
            Controls.Add(directorsGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)directorsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView directorsGridView;
        private Button goMovies;
        private Label titleLabel;
        private Button addDirectorButton;
        private Label playerInfoLabel;
        private Label playerLastnameLabel;
        private Label playerNameLabel;
        private TextBox playerInfo;
        private TextBox playerLastname;
        private TextBox playerName;
    }
}