namespace EfficientlyLazy.PhotoFramer.UI
{
    partial class frmViewer
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
            this.lblCounter = new System.Windows.Forms.Label();
            this.cbxIncludeOnFrame = new System.Windows.Forms.CheckBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdLast = new System.Windows.Forms.Button();
            this.cmdNext = new System.Windows.Forms.Button();
            this.cmdFirst = new System.Windows.Forms.Button();
            this.cmdPrevious = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdRotateClockwise = new System.Windows.Forms.Button();
            this.cmdRotateCounterClockwise = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCounter
            // 
            this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(12, 518);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(858, 23);
            this.lblCounter.TabIndex = 2;
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxIncludeOnFrame
            // 
            this.cbxIncludeOnFrame.AutoSize = true;
            this.cbxIncludeOnFrame.Location = new System.Drawing.Point(15, 21);
            this.cbxIncludeOnFrame.Name = "cbxIncludeOnFrame";
            this.cbxIncludeOnFrame.Size = new System.Drawing.Size(142, 21);
            this.cbxIncludeOnFrame.TabIndex = 3;
            this.cbxIncludeOnFrame.Text = "Include On Frame";
            this.cbxIncludeOnFrame.UseVisualStyleBackColor = true;
            this.cbxIncludeOnFrame.CheckedChanged += new System.EventHandler(this.cbxIncludeOnFrame_CheckedChanged);
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.cmdClose);
            this.gbControls.Controls.Add(this.cmdLast);
            this.gbControls.Controls.Add(this.cbxIncludeOnFrame);
            this.gbControls.Controls.Add(this.cmdNext);
            this.gbControls.Controls.Add(this.cmdFirst);
            this.gbControls.Controls.Add(this.cmdPrevious);
            this.gbControls.Controls.Add(this.cmdDelete);
            this.gbControls.Controls.Add(this.cmdRotateClockwise);
            this.gbControls.Controls.Add(this.cmdRotateCounterClockwise);
            this.gbControls.Location = new System.Drawing.Point(12, 544);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(858, 93);
            this.gbControls.TabIndex = 0;
            this.gbControls.TabStop = false;
            // 
            // cmdClose
            // 
            this.cmdClose.Image = global::EfficientlyLazy.PhotoFramer.UI.Properties.Resources.close;
            this.cmdClose.Location = new System.Drawing.Point(771, 19);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClose.Size = new System.Drawing.Size(75, 62);
            this.cmdClose.TabIndex = 4;
            this.cmdClose.Text = "Close";
            this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdLast
            // 
            this.cmdLast.Image = global::EfficientlyLazy.PhotoFramer.UI.Properties.Resources.last;
            this.cmdLast.Location = new System.Drawing.Point(672, 19);
            this.cmdLast.Name = "cmdLast";
            this.cmdLast.Size = new System.Drawing.Size(75, 62);
            this.cmdLast.TabIndex = 1;
            this.cmdLast.Text = "Last";
            this.cmdLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdLast.UseVisualStyleBackColor = true;
            this.cmdLast.Click += new System.EventHandler(this.cmdLast_Click);
            // 
            // cmdNext
            // 
            this.cmdNext.Image = global::EfficientlyLazy.PhotoFramer.UI.Properties.Resources.next;
            this.cmdNext.Location = new System.Drawing.Point(591, 19);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(75, 62);
            this.cmdNext.TabIndex = 0;
            this.cmdNext.Text = "Next";
            this.cmdNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // cmdFirst
            // 
            this.cmdFirst.Image = global::EfficientlyLazy.PhotoFramer.UI.Properties.Resources.first;
            this.cmdFirst.Location = new System.Drawing.Point(429, 19);
            this.cmdFirst.Name = "cmdFirst";
            this.cmdFirst.Size = new System.Drawing.Size(75, 62);
            this.cmdFirst.TabIndex = 3;
            this.cmdFirst.Text = "First";
            this.cmdFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdFirst.UseVisualStyleBackColor = true;
            this.cmdFirst.Click += new System.EventHandler(this.cmdFirst_Click);
            // 
            // cmdPrevious
            // 
            this.cmdPrevious.Image = global::EfficientlyLazy.PhotoFramer.UI.Properties.Resources.back;
            this.cmdPrevious.Location = new System.Drawing.Point(510, 19);
            this.cmdPrevious.Name = "cmdPrevious";
            this.cmdPrevious.Size = new System.Drawing.Size(75, 62);
            this.cmdPrevious.TabIndex = 2;
            this.cmdPrevious.Text = "Previous";
            this.cmdPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdPrevious.UseVisualStyleBackColor = true;
            this.cmdPrevious.Click += new System.EventHandler(this.cmdPrevious_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Image = global::EfficientlyLazy.PhotoFramer.UI.Properties.Resources.delete;
            this.cmdDelete.Location = new System.Drawing.Point(337, 19);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 62);
            this.cmdDelete.TabIndex = 5;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdRotateClockwise
            // 
            this.cmdRotateClockwise.Image = global::EfficientlyLazy.PhotoFramer.UI.Properties.Resources.clockwise;
            this.cmdRotateClockwise.Location = new System.Drawing.Point(243, 19);
            this.cmdRotateClockwise.Name = "cmdRotateClockwise";
            this.cmdRotateClockwise.Size = new System.Drawing.Size(75, 62);
            this.cmdRotateClockwise.TabIndex = 4;
            this.cmdRotateClockwise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdRotateClockwise.UseVisualStyleBackColor = true;
            this.cmdRotateClockwise.Click += new System.EventHandler(this.cmdRotateClockwise_Click);
            // 
            // cmdRotateCounterClockwise
            // 
            this.cmdRotateCounterClockwise.Image = global::EfficientlyLazy.PhotoFramer.UI.Properties.Resources.counterclockwise;
            this.cmdRotateCounterClockwise.Location = new System.Drawing.Point(162, 19);
            this.cmdRotateCounterClockwise.Name = "cmdRotateCounterClockwise";
            this.cmdRotateCounterClockwise.Size = new System.Drawing.Size(75, 62);
            this.cmdRotateCounterClockwise.TabIndex = 4;
            this.cmdRotateCounterClockwise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdRotateCounterClockwise.UseVisualStyleBackColor = true;
            this.cmdRotateCounterClockwise.Click += new System.EventHandler(this.cmdRotateCounterClockwise_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(12, 12);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(858, 503);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            // 
            // frmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 646);
            this.ControlBox = false;
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.pbPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmViewer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Viewer";
            this.Load += new System.EventHandler(this.frmViewer_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmViewer_KeyUp);
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Button cmdPrevious;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.CheckBox cbxIncludeOnFrame;
        private System.Windows.Forms.Button cmdRotateClockwise;
        private System.Windows.Forms.Button cmdRotateCounterClockwise;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdFirst;
        private System.Windows.Forms.Button cmdLast;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Button cmdClose;
    }
}