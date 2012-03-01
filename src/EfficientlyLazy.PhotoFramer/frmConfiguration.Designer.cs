namespace EfficientlyLazy.PhotoFramer
{
    partial class frmConfiguration
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
            this.txtFramePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArchivePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCameraPath = new System.Windows.Forms.TextBox();
            this.cmdBrowseFrame = new System.Windows.Forms.Button();
            this.cmdBrowseArchive = new System.Windows.Forms.Button();
            this.cmdBrowseCamera = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.nudFrameHeight = new System.Windows.Forms.NumericUpDown();
            this.nudFrameWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExtensionsCSV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frame Path:";
            // 
            // txtFramePath
            // 
            this.txtFramePath.Location = new System.Drawing.Point(20, 36);
            this.txtFramePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFramePath.Name = "txtFramePath";
            this.txtFramePath.Size = new System.Drawing.Size(477, 22);
            this.txtFramePath.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Archive Path:";
            // 
            // txtArchivePath
            // 
            this.txtArchivePath.Location = new System.Drawing.Point(20, 94);
            this.txtArchivePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArchivePath.Name = "txtArchivePath";
            this.txtArchivePath.Size = new System.Drawing.Size(477, 22);
            this.txtArchivePath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Camera Path:";
            // 
            // txtCameraPath
            // 
            this.txtCameraPath.Location = new System.Drawing.Point(20, 153);
            this.txtCameraPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCameraPath.Name = "txtCameraPath";
            this.txtCameraPath.Size = new System.Drawing.Size(477, 22);
            this.txtCameraPath.TabIndex = 2;
            // 
            // cmdBrowseFrame
            // 
            this.cmdBrowseFrame.Location = new System.Drawing.Point(507, 33);
            this.cmdBrowseFrame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdBrowseFrame.Name = "cmdBrowseFrame";
            this.cmdBrowseFrame.Size = new System.Drawing.Size(35, 28);
            this.cmdBrowseFrame.TabIndex = 2;
            this.cmdBrowseFrame.TabStop = false;
            this.cmdBrowseFrame.Text = "...";
            this.cmdBrowseFrame.UseVisualStyleBackColor = true;
            this.cmdBrowseFrame.Click += new System.EventHandler(this.cmdBrowseFrame_Click);
            // 
            // cmdBrowseArchive
            // 
            this.cmdBrowseArchive.Location = new System.Drawing.Point(508, 91);
            this.cmdBrowseArchive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdBrowseArchive.Name = "cmdBrowseArchive";
            this.cmdBrowseArchive.Size = new System.Drawing.Size(35, 28);
            this.cmdBrowseArchive.TabIndex = 2;
            this.cmdBrowseArchive.TabStop = false;
            this.cmdBrowseArchive.Text = "...";
            this.cmdBrowseArchive.UseVisualStyleBackColor = true;
            this.cmdBrowseArchive.Click += new System.EventHandler(this.cmdBrowseArchive_Click);
            // 
            // cmdBrowseCamera
            // 
            this.cmdBrowseCamera.Location = new System.Drawing.Point(508, 150);
            this.cmdBrowseCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdBrowseCamera.Name = "cmdBrowseCamera";
            this.cmdBrowseCamera.Size = new System.Drawing.Size(35, 28);
            this.cmdBrowseCamera.TabIndex = 2;
            this.cmdBrowseCamera.TabStop = false;
            this.cmdBrowseCamera.Text = "...";
            this.cmdBrowseCamera.UseVisualStyleBackColor = true;
            this.cmdBrowseCamera.Click += new System.EventHandler(this.cmdBrowseCamera_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(399, 319);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 28);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(291, 319);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 28);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // nudFrameHeight
            // 
            this.nudFrameHeight.Location = new System.Drawing.Point(20, 213);
            this.nudFrameHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudFrameHeight.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudFrameHeight.Name = "nudFrameHeight";
            this.nudFrameHeight.Size = new System.Drawing.Size(112, 22);
            this.nudFrameHeight.TabIndex = 3;
            // 
            // nudFrameWidth
            // 
            this.nudFrameWidth.Location = new System.Drawing.Point(160, 213);
            this.nudFrameWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudFrameWidth.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudFrameWidth.Name = "nudFrameWidth";
            this.nudFrameWidth.Size = new System.Drawing.Size(112, 22);
            this.nudFrameWidth.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Frame Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Frame Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Photo Extensions (csv):";
            // 
            // txtExtensionsCSV
            // 
            this.txtExtensionsCSV.Location = new System.Drawing.Point(20, 273);
            this.txtExtensionsCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExtensionsCSV.Name = "txtExtensionsCSV";
            this.txtExtensionsCSV.Size = new System.Drawing.Size(477, 22);
            this.txtExtensionsCSV.TabIndex = 5;
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 361);
            this.ControlBox = false;
            this.Controls.Add(this.nudFrameWidth);
            this.Controls.Add(this.nudFrameHeight);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdBrowseCamera);
            this.Controls.Add(this.cmdBrowseArchive);
            this.Controls.Add(this.cmdBrowseFrame);
            this.Controls.Add(this.txtExtensionsCSV);
            this.Controls.Add(this.txtCameraPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArchivePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFramePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConfiguration";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFramePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArchivePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCameraPath;
        private System.Windows.Forms.Button cmdBrowseFrame;
        private System.Windows.Forms.Button cmdBrowseArchive;
        private System.Windows.Forms.Button cmdBrowseCamera;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.NumericUpDown nudFrameHeight;
        private System.Windows.Forms.NumericUpDown nudFrameWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExtensionsCSV;
    }
}