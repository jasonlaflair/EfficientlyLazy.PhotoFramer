namespace EfficientlyLazy.PhotoFramer.UI
{
    partial class frmMain
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
            this.cmdLoadFromCamera = new System.Windows.Forms.Button();
            this.cmdViewer = new System.Windows.Forms.Button();
            this.cmdUpdateFrame = new System.Windows.Forms.Button();
            this.cmdSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdLoadFromCamera
            // 
            this.cmdLoadFromCamera.Location = new System.Drawing.Point(12, 12);
            this.cmdLoadFromCamera.Name = "cmdLoadFromCamera";
            this.cmdLoadFromCamera.Size = new System.Drawing.Size(215, 54);
            this.cmdLoadFromCamera.TabIndex = 0;
            this.cmdLoadFromCamera.Text = "Load Images From Camera";
            this.cmdLoadFromCamera.UseVisualStyleBackColor = true;
            this.cmdLoadFromCamera.Click += new System.EventHandler(this.cmdLoadFromCamera_Click);
            // 
            // cmdViewer
            // 
            this.cmdViewer.Location = new System.Drawing.Point(12, 72);
            this.cmdViewer.Name = "cmdViewer";
            this.cmdViewer.Size = new System.Drawing.Size(215, 54);
            this.cmdViewer.TabIndex = 1;
            this.cmdViewer.Text = "View";
            this.cmdViewer.UseVisualStyleBackColor = true;
            this.cmdViewer.Click += new System.EventHandler(this.cmdViewer_Click);
            // 
            // cmdUpdateFrame
            // 
            this.cmdUpdateFrame.Location = new System.Drawing.Point(12, 132);
            this.cmdUpdateFrame.Name = "cmdUpdateFrame";
            this.cmdUpdateFrame.Size = new System.Drawing.Size(215, 54);
            this.cmdUpdateFrame.TabIndex = 2;
            this.cmdUpdateFrame.Text = "Update Frame";
            this.cmdUpdateFrame.UseVisualStyleBackColor = true;
            this.cmdUpdateFrame.Click += new System.EventHandler(this.cmdUpdateFrame_Click);
            // 
            // cmdSettings
            // 
            this.cmdSettings.Location = new System.Drawing.Point(12, 192);
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(215, 54);
            this.cmdSettings.TabIndex = 3;
            this.cmdSettings.Text = "Settings";
            this.cmdSettings.UseVisualStyleBackColor = true;
            this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 259);
            this.Controls.Add(this.cmdSettings);
            this.Controls.Add(this.cmdUpdateFrame);
            this.Controls.Add(this.cmdViewer);
            this.Controls.Add(this.cmdLoadFromCamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Framer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLoadFromCamera;
        private System.Windows.Forms.Button cmdViewer;
        private System.Windows.Forms.Button cmdUpdateFrame;
        private System.Windows.Forms.Button cmdSettings;

    }
}

