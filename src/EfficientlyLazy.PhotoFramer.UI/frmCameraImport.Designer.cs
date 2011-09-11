namespace EfficientlyLazy.PhotoFramer.UI
{
    partial class frmCameraImport
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
            this.lblCameraRoot = new System.Windows.Forms.Label();
            this.cmdSetCameraRoot = new System.Windows.Forms.Button();
            this.cmdImportFromCamera = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cbxDeleteFromCamera = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera Path:";
            // 
            // lblCameraRoot
            // 
            this.lblCameraRoot.AutoEllipsis = true;
            this.lblCameraRoot.BackColor = System.Drawing.SystemColors.Window;
            this.lblCameraRoot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCameraRoot.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCameraRoot.Location = new System.Drawing.Point(123, 15);
            this.lblCameraRoot.Name = "lblCameraRoot";
            this.lblCameraRoot.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblCameraRoot.Size = new System.Drawing.Size(333, 22);
            this.lblCameraRoot.TabIndex = 0;
            this.lblCameraRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdSetCameraRoot
            // 
            this.cmdSetCameraRoot.Location = new System.Drawing.Point(462, 12);
            this.cmdSetCameraRoot.Name = "cmdSetCameraRoot";
            this.cmdSetCameraRoot.Size = new System.Drawing.Size(75, 23);
            this.cmdSetCameraRoot.TabIndex = 1;
            this.cmdSetCameraRoot.Text = "Set Path";
            this.cmdSetCameraRoot.UseVisualStyleBackColor = true;
            this.cmdSetCameraRoot.Click += new System.EventHandler(this.cmdSetCameraRoot_Click);
            // 
            // cmdImportFromCamera
            // 
            this.cmdImportFromCamera.Location = new System.Drawing.Point(300, 89);
            this.cmdImportFromCamera.Name = "cmdImportFromCamera";
            this.cmdImportFromCamera.Size = new System.Drawing.Size(75, 23);
            this.cmdImportFromCamera.TabIndex = 0;
            this.cmdImportFromCamera.Text = "Import";
            this.cmdImportFromCamera.UseVisualStyleBackColor = true;
            this.cmdImportFromCamera.Click += new System.EventHandler(this.cmdImportFromCamera_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(381, 89);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cbxDeleteFromCamera
            // 
            this.cbxDeleteFromCamera.AutoSize = true;
            this.cbxDeleteFromCamera.Checked = true;
            this.cbxDeleteFromCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDeleteFromCamera.Location = new System.Drawing.Point(123, 51);
            this.cbxDeleteFromCamera.Name = "cbxDeleteFromCamera";
            this.cbxDeleteFromCamera.Size = new System.Drawing.Size(306, 21);
            this.cbxDeleteFromCamera.TabIndex = 2;
            this.cbxDeleteFromCamera.Text = "Delete From Camera after successful import";
            this.cbxDeleteFromCamera.UseVisualStyleBackColor = true;
            // 
            // frmCameraImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 124);
            this.ControlBox = false;
            this.Controls.Add(this.cbxDeleteFromCamera);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdImportFromCamera);
            this.Controls.Add(this.cmdSetCameraRoot);
            this.Controls.Add(this.lblCameraRoot);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCameraImport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Camera Import";
            this.Load += new System.EventHandler(this.frmCameraImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCameraRoot;
        private System.Windows.Forms.Button cmdSetCameraRoot;
        private System.Windows.Forms.Button cmdImportFromCamera;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.CheckBox cbxDeleteFromCamera;
    }
}