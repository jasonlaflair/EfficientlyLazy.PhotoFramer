namespace EfficientlyLazy.PhotoFramer
{
    partial class frmDashboard
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
            this.cmdProcessPending = new System.Windows.Forms.Button();
            this.cmdReviewExcluded = new System.Windows.Forms.Button();
            this.cmdViewIncluded = new System.Windows.Forms.Button();
            this.cmdSyncArchive = new System.Windows.Forms.Button();
            this.cmdConfiguration = new System.Windows.Forms.Button();
            this.cmdUpdateFrame = new System.Windows.Forms.Button();
            this.cmdExtractFromCamera = new System.Windows.Forms.Button();
            this.cmdCleanup = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.tsslFrameTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdProcessPending
            // 
            this.cmdProcessPending.Location = new System.Drawing.Point(16, 19);
            this.cmdProcessPending.Name = "cmdProcessPending";
            this.cmdProcessPending.Size = new System.Drawing.Size(195, 23);
            this.cmdProcessPending.TabIndex = 0;
            this.cmdProcessPending.Text = "Process Pending";
            this.cmdProcessPending.UseVisualStyleBackColor = true;
            this.cmdProcessPending.Click += new System.EventHandler(this.cmdProcessPending_Click);
            // 
            // cmdReviewExcluded
            // 
            this.cmdReviewExcluded.Location = new System.Drawing.Point(16, 77);
            this.cmdReviewExcluded.Name = "cmdReviewExcluded";
            this.cmdReviewExcluded.Size = new System.Drawing.Size(195, 23);
            this.cmdReviewExcluded.TabIndex = 2;
            this.cmdReviewExcluded.Text = "Review Excluded";
            this.cmdReviewExcluded.UseVisualStyleBackColor = true;
            this.cmdReviewExcluded.Click += new System.EventHandler(this.cmdReviewExcluded_Click);
            // 
            // cmdViewIncluded
            // 
            this.cmdViewIncluded.Location = new System.Drawing.Point(16, 48);
            this.cmdViewIncluded.Name = "cmdViewIncluded";
            this.cmdViewIncluded.Size = new System.Drawing.Size(195, 23);
            this.cmdViewIncluded.TabIndex = 1;
            this.cmdViewIncluded.Text = "View Included";
            this.cmdViewIncluded.UseVisualStyleBackColor = true;
            this.cmdViewIncluded.Click += new System.EventHandler(this.cmdViewIncluded_Click);
            // 
            // cmdSyncArchive
            // 
            this.cmdSyncArchive.Location = new System.Drawing.Point(16, 77);
            this.cmdSyncArchive.Name = "cmdSyncArchive";
            this.cmdSyncArchive.Size = new System.Drawing.Size(90, 23);
            this.cmdSyncArchive.TabIndex = 2;
            this.cmdSyncArchive.Text = "Sync Archive";
            this.cmdSyncArchive.UseVisualStyleBackColor = true;
            this.cmdSyncArchive.Click += new System.EventHandler(this.cmdSyncArchive_Click);
            // 
            // cmdConfiguration
            // 
            this.cmdConfiguration.Location = new System.Drawing.Point(16, 19);
            this.cmdConfiguration.Name = "cmdConfiguration";
            this.cmdConfiguration.Size = new System.Drawing.Size(90, 23);
            this.cmdConfiguration.TabIndex = 0;
            this.cmdConfiguration.Text = "Configuration";
            this.cmdConfiguration.UseVisualStyleBackColor = true;
            this.cmdConfiguration.Click += new System.EventHandler(this.cmdConfiguration_Click);
            // 
            // cmdUpdateFrame
            // 
            this.cmdUpdateFrame.Location = new System.Drawing.Point(16, 48);
            this.cmdUpdateFrame.Name = "cmdUpdateFrame";
            this.cmdUpdateFrame.Size = new System.Drawing.Size(195, 23);
            this.cmdUpdateFrame.TabIndex = 1;
            this.cmdUpdateFrame.Text = "Update Frame";
            this.cmdUpdateFrame.UseVisualStyleBackColor = true;
            this.cmdUpdateFrame.Click += new System.EventHandler(this.cmdUpdateFrame_Click);
            // 
            // cmdExtractFromCamera
            // 
            this.cmdExtractFromCamera.Location = new System.Drawing.Point(16, 19);
            this.cmdExtractFromCamera.Name = "cmdExtractFromCamera";
            this.cmdExtractFromCamera.Size = new System.Drawing.Size(195, 23);
            this.cmdExtractFromCamera.TabIndex = 0;
            this.cmdExtractFromCamera.Text = "Extract From Camera";
            this.cmdExtractFromCamera.UseVisualStyleBackColor = true;
            this.cmdExtractFromCamera.Click += new System.EventHandler(this.cmdExtractFromCamera_Click);
            // 
            // cmdCleanup
            // 
            this.cmdCleanup.Location = new System.Drawing.Point(121, 77);
            this.cmdCleanup.Name = "cmdCleanup";
            this.cmdCleanup.Size = new System.Drawing.Size(90, 23);
            this.cmdCleanup.TabIndex = 3;
            this.cmdCleanup.Text = "Cleanup";
            this.cmdCleanup.UseVisualStyleBackColor = true;
            this.cmdCleanup.Click += new System.EventHandler(this.cmdCleanup_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotal,
            this.tsslFrameTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(250, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTotal
            // 
            this.tsslTotal.Name = "tsslTotal";
            this.tsslTotal.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tsslTotal.Size = new System.Drawing.Size(61, 17);
            this.tsslTotal.Text = "Total: XXX";
            this.tsslTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdProcessPending);
            this.groupBox1.Controls.Add(this.cmdReviewExcluded);
            this.groupBox1.Controls.Add(this.cmdViewIncluded);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdExtractFromCamera);
            this.groupBox2.Controls.Add(this.cmdSyncArchive);
            this.groupBox2.Controls.Add(this.cmdUpdateFrame);
            this.groupBox2.Controls.Add(this.cmdCleanup);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdClose);
            this.groupBox3.Controls.Add(this.cmdConfiguration);
            this.groupBox3.Location = new System.Drawing.Point(12, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(121, 19);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(90, 23);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // tsslFrameTotal
            // 
            this.tsslFrameTotal.Name = "tsslFrameTotal";
            this.tsslFrameTotal.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tsslFrameTotal.Size = new System.Drawing.Size(67, 17);
            this.tsslFrameTotal.Text = "Frame: XXX";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 354);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdProcessPending;
        private System.Windows.Forms.Button cmdReviewExcluded;
        private System.Windows.Forms.Button cmdViewIncluded;
        private System.Windows.Forms.Button cmdSyncArchive;
        private System.Windows.Forms.Button cmdConfiguration;
        private System.Windows.Forms.Button cmdUpdateFrame;
        private System.Windows.Forms.Button cmdExtractFromCamera;
        private System.Windows.Forms.Button cmdCleanup;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.ToolStripStatusLabel tsslFrameTotal;
    }
}