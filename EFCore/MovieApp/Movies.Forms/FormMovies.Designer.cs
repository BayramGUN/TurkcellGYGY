namespace Movies.Forms
{
    partial class FormMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovies));
            splitContainer1 = new SplitContainer();
            moviesDataGridView = new DataGridView();
            playerProcess = new Button();
            directorsProcess = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moviesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            splitContainer1.Panel1.Controls.Add(moviesDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            splitContainer1.Panel2.Controls.Add(playerProcess);
            splitContainer1.Panel2.Controls.Add(directorsProcess);
            // 
            // moviesDataGridView
            // 
            resources.ApplyResources(moviesDataGridView, "moviesDataGridView");
            moviesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesDataGridView.Name = "moviesDataGridView";
            moviesDataGridView.RowTemplate.Height = 25;
            // 
            // playerProcess
            // 
            resources.ApplyResources(playerProcess, "playerProcess");
            playerProcess.Name = "playerProcess";
            playerProcess.UseVisualStyleBackColor = true;
            playerProcess.Click += playerProcess_Click;
            // 
            // directorsProcess
            // 
            resources.ApplyResources(directorsProcess, "directorsProcess");
            directorsProcess.Name = "directorsProcess";
            directorsProcess.UseVisualStyleBackColor = true;
            directorsProcess.Click += directorsProcess_Click;
            // 
            // FormMovies
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "FormMovies";
            Load += FormMovies_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)moviesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView moviesDataGridView;
        private Button playerProcess;
        private Button directorsProcess;
    }
}