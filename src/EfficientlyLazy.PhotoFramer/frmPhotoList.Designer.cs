namespace EfficientlyLazy.PhotoFramer
{
    partial class frmPhotoList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhotoList));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslIncludedExcluded = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tsbInclude = new System.Windows.Forms.ToolStripButton();
            this.tsbExclude = new System.Windows.Forms.ToolStripButton();
            this.tsbIncludeAll = new System.Windows.Forms.ToolStripButton();
            this.tsbExcludeAll = new System.Windows.Forms.ToolStripButton();
            this.tsbCounterClockwise = new System.Windows.Forms.ToolStripButton();
            this.tsbClockwise = new System.Windows.Forms.ToolStripButton();
            this.tsbUndelete = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbInclude,
            this.tslIncludedExcluded,
            this.tsbExclude,
            this.toolStripSeparator1,
            this.tsbIncludeAll,
            this.tsbExcludeAll,
            this.toolStripSeparator3,
            this.tsbCounterClockwise,
            this.tsbClockwise,
            this.toolStripSeparator2,
            this.tsbDelete,
            this.tsbUndelete,
            this.toolStripSeparator4,
            this.tsbClose});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 575);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(931, 43);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 40);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // tslIncludedExcluded
            // 
            this.tslIncludedExcluded.BackColor = System.Drawing.Color.Orange;
            this.tslIncludedExcluded.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslIncludedExcluded.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslIncludedExcluded.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tslIncludedExcluded.Name = "tslIncludedExcluded";
            this.tslIncludedExcluded.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tslIncludedExcluded.Size = new System.Drawing.Size(77, 40);
            this.tslIncludedExcluded.Text = "Pending";
            this.tslIncludedExcluded.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::EfficientlyLazy.PhotoFramer.Properties.Resources.DeleteIcon;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(57, 40);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 550);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(931, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(911, 20);
            this.tsslStatus.Spring = true;
            this.tsslStatus.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(931, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 40);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 40);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 40);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // tsbInclude
            // 
            this.tsbInclude.BackColor = System.Drawing.Color.LightGreen;
            this.tsbInclude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInclude.Image = global::EfficientlyLazy.PhotoFramer.Properties.Resources.ImageIncludeIcon;
            this.tsbInclude.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInclude.Name = "tsbInclude";
            this.tsbInclude.Size = new System.Drawing.Size(23, 40);
            this.tsbInclude.Text = "Include";
            this.tsbInclude.Click += new System.EventHandler(this.tsbInclude_Click);
            // 
            // tsbExclude
            // 
            this.tsbExclude.BackColor = System.Drawing.Color.Salmon;
            this.tsbExclude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExclude.Image = global::EfficientlyLazy.PhotoFramer.Properties.Resources.ImageExcludeIcon;
            this.tsbExclude.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExclude.Name = "tsbExclude";
            this.tsbExclude.Size = new System.Drawing.Size(23, 40);
            this.tsbExclude.Text = "Exclude";
            this.tsbExclude.Click += new System.EventHandler(this.tsbExclude_Click);
            // 
            // tsbIncludeAll
            // 
            this.tsbIncludeAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbIncludeAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbIncludeAll.Image")));
            this.tsbIncludeAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIncludeAll.Name = "tsbIncludeAll";
            this.tsbIncludeAll.Size = new System.Drawing.Size(83, 40);
            this.tsbIncludeAll.Text = "Include All";
            this.tsbIncludeAll.Click += new System.EventHandler(this.tsbIncludeAll_Click);
            // 
            // tsbExcludeAll
            // 
            this.tsbExcludeAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExcludeAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcludeAll.Image")));
            this.tsbExcludeAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcludeAll.Name = "tsbExcludeAll";
            this.tsbExcludeAll.Size = new System.Drawing.Size(86, 40);
            this.tsbExcludeAll.Text = "Exclude All";
            this.tsbExcludeAll.Click += new System.EventHandler(this.tsbExcludeAll_Click);
            // 
            // tsbCounterClockwise
            // 
            this.tsbCounterClockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCounterClockwise.Image = global::EfficientlyLazy.PhotoFramer.Properties.Resources.RotateCounterClockwiseIcon;
            this.tsbCounterClockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCounterClockwise.Name = "tsbCounterClockwise";
            this.tsbCounterClockwise.Size = new System.Drawing.Size(23, 40);
            this.tsbCounterClockwise.Text = "Rotate Counter Clockwise";
            this.tsbCounterClockwise.Click += new System.EventHandler(this.tsbCounterClockwise_Click);
            // 
            // tsbClockwise
            // 
            this.tsbClockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClockwise.Image = global::EfficientlyLazy.PhotoFramer.Properties.Resources.RotateClockwiseIcon;
            this.tsbClockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClockwise.Name = "tsbClockwise";
            this.tsbClockwise.Size = new System.Drawing.Size(23, 40);
            this.tsbClockwise.Text = "Rotate Clockwise";
            this.tsbClockwise.Click += new System.EventHandler(this.tsbClockwise_Click);
            // 
            // tsbUndelete
            // 
            this.tsbUndelete.Image = global::EfficientlyLazy.PhotoFramer.Properties.Resources.UndeleteIcon;
            this.tsbUndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndelete.Name = "tsbUndelete";
            this.tsbUndelete.Size = new System.Drawing.Size(73, 40);
            this.tsbUndelete.Text = "Undelete";
            this.tsbUndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUndelete.Click += new System.EventHandler(this.tsbUndelete_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(49, 40);
            this.tsbClose.Text = "Close";
            this.tsbClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // frmPhotoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhotoList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Photos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsbExclude;
        private System.Windows.Forms.ToolStripButton tsbInclude;
        private System.Windows.Forms.ToolStripButton tsbCounterClockwise;
        private System.Windows.Forms.ToolStripButton tsbClockwise;
        private System.Windows.Forms.ToolStripLabel tslIncludedExcluded;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbIncludeAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripButton tsbUndelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbExcludeAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbClose;
    }
}

