namespace EfficientlyLazy.PhotoFramer.UI
{
    partial class frmSettings
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
            this.cmdSetCameraRoot = new System.Windows.Forms.Button();
            this.lblCameraRoot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSetFrameRoot = new System.Windows.Forms.Button();
            this.lblFrameRoot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxResize = new System.Windows.Forms.CheckBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdRevert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSetCameraRoot
            // 
            this.cmdSetCameraRoot.Location = new System.Drawing.Point(462, 9);
            this.cmdSetCameraRoot.Name = "cmdSetCameraRoot";
            this.cmdSetCameraRoot.Size = new System.Drawing.Size(75, 23);
            this.cmdSetCameraRoot.TabIndex = 0;
            this.cmdSetCameraRoot.Text = "Set Path";
            this.cmdSetCameraRoot.UseVisualStyleBackColor = true;
            this.cmdSetCameraRoot.Click += new System.EventHandler(this.cmdSetCameraRoot_Click);
            // 
            // lblCameraRoot
            // 
            this.lblCameraRoot.AutoEllipsis = true;
            this.lblCameraRoot.BackColor = System.Drawing.SystemColors.Window;
            this.lblCameraRoot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCameraRoot.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCameraRoot.Location = new System.Drawing.Point(123, 9);
            this.lblCameraRoot.Name = "lblCameraRoot";
            this.lblCameraRoot.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblCameraRoot.Size = new System.Drawing.Size(333, 22);
            this.lblCameraRoot.TabIndex = 3;
            this.lblCameraRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camera Path:";
            // 
            // cmdSetFrameRoot
            // 
            this.cmdSetFrameRoot.Location = new System.Drawing.Point(462, 43);
            this.cmdSetFrameRoot.Name = "cmdSetFrameRoot";
            this.cmdSetFrameRoot.Size = new System.Drawing.Size(75, 23);
            this.cmdSetFrameRoot.TabIndex = 1;
            this.cmdSetFrameRoot.Text = "Set Path";
            this.cmdSetFrameRoot.UseVisualStyleBackColor = true;
            this.cmdSetFrameRoot.Click += new System.EventHandler(this.cmdSetFrameRoot_Click);
            // 
            // lblFrameRoot
            // 
            this.lblFrameRoot.AutoEllipsis = true;
            this.lblFrameRoot.BackColor = System.Drawing.SystemColors.Window;
            this.lblFrameRoot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFrameRoot.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFrameRoot.Location = new System.Drawing.Point(123, 43);
            this.lblFrameRoot.Name = "lblFrameRoot";
            this.lblFrameRoot.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblFrameRoot.Size = new System.Drawing.Size(333, 22);
            this.lblFrameRoot.TabIndex = 6;
            this.lblFrameRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frame Path:";
            // 
            // cbxResize
            // 
            this.cbxResize.AutoSize = true;
            this.cbxResize.Location = new System.Drawing.Point(123, 79);
            this.cbxResize.Name = "cbxResize";
            this.cbxResize.Size = new System.Drawing.Size(142, 21);
            this.cbxResize.TabIndex = 2;
            this.cbxResize.Text = "Resize For Frame";
            this.cbxResize.UseVisualStyleBackColor = true;
            this.cbxResize.CheckedChanged += new System.EventHandler(this.cbxResize_CheckedChanged);
            // 
            // nudHeight
            // 
            this.nudHeight.Enabled = false;
            this.nudHeight.Location = new System.Drawing.Point(123, 106);
            this.nudHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 22);
            this.nudHeight.TabIndex = 3;
            this.nudHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudWidth
            // 
            this.nudWidth.Enabled = false;
            this.nudWidth.Location = new System.Drawing.Point(123, 134);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 22);
            this.nudWidth.TabIndex = 4;
            this.nudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Enabled = false;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(21, 108);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(96, 17);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Frame Path:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Enabled = false;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(21, 136);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(96, 17);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Frame Path:";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(381, 133);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(462, 133);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdRevert
            // 
            this.cmdRevert.Location = new System.Drawing.Point(300, 133);
            this.cmdRevert.Name = "cmdRevert";
            this.cmdRevert.Size = new System.Drawing.Size(75, 23);
            this.cmdRevert.TabIndex = 7;
            this.cmdRevert.TabStop = false;
            this.cmdRevert.Text = "Revert";
            this.cmdRevert.UseVisualStyleBackColor = true;
            this.cmdRevert.Click += new System.EventHandler(this.cmdRevert_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 168);
            this.ControlBox = false;
            this.Controls.Add(this.cmdRevert);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.cbxResize);
            this.Controls.Add(this.cmdSetFrameRoot);
            this.Controls.Add(this.lblFrameRoot);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdSetCameraRoot);
            this.Controls.Add(this.lblCameraRoot);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSetCameraRoot;
        private System.Windows.Forms.Label lblCameraRoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSetFrameRoot;
        private System.Windows.Forms.Label lblFrameRoot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxResize;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdRevert;
    }
}