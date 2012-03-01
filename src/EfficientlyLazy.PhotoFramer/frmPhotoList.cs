using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EfficientlyLazy.PhotoFramer.Entities;
using EfficientlyLazy.PhotoFramer.Services;

namespace EfficientlyLazy.PhotoFramer
{
    public partial class frmPhotoList : Form
    {
        private readonly BindingSource _bindingSource;

        public frmPhotoList(List<Photo> photos)
        {
            InitializeComponent();
            
            _bindingSource = new BindingSource
                                 {
                                     DataSource = photos
                                 };

            _bindingSource.CurrentItemChanged += BindingSource1OnCurrentItemChanged;

            bindingNavigator1.BindingSource = _bindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPhotoData();
        }

        private void BindingSource1OnCurrentItemChanged(object sender, EventArgs eventArgs)
        {
            LoadPhotoData();
        }

        private void LoadPhotoData()
        {
            var current = _bindingSource.Current as Photo;

            if (current == null)
            {
                pictureBox1.Image = null;
                tsbClockwise.Enabled = false;
                tsbCounterClockwise.Enabled = false;
                tsbInclude.Enabled = false;
                tsbExclude.Enabled = false;

                return;
            }

            pictureBox1.Load(current.ArchiveFullName);
            tsbClockwise.Enabled = true;
            tsbCounterClockwise.Enabled = true;
        
            SetIncludeExclude(current);
        }

        private void SetIncludeExclude(Photo record)
        {
            switch (record.Status)
            {
                case PhotoStatus.Excluded:
                    tslIncludedExcluded.Text = "Excluded";
                    tsbExclude.Enabled = false;
                    tsbInclude.Enabled = true;
                    tsbClockwise.Enabled = true;
                    tsbCounterClockwise.Enabled = true;
                    tsbDelete.Enabled = true;
                    tsbUndelete.Enabled = false;
                    break;
                case PhotoStatus.Included:
                    tslIncludedExcluded.Text = "Included";
                    tsbExclude.Enabled = true;
                    tsbInclude.Enabled = false;
                    tsbClockwise.Enabled = true;
                    tsbCounterClockwise.Enabled = true;
                    tsbDelete.Enabled = true;
                    tsbUndelete.Enabled = false;
                    break;
                case PhotoStatus.Deleted:
                    tslIncludedExcluded.Text = "Deleted";
                    tsbExclude.Enabled = false;
                    tsbInclude.Enabled = false;
                    tsbClockwise.Enabled = false;
                    tsbCounterClockwise.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbUndelete.Enabled = true;
                    break;
                //case PhotoOnFrame.Unknown:
                default:
                    tslIncludedExcluded.Text = "Pending";
                    tslIncludedExcluded.BackColor = SystemColors.Control;
                    tsbExclude.Enabled = true;
                    tsbInclude.Enabled = true;
                    tsbClockwise.Enabled = true;
                    tsbCounterClockwise.Enabled = true;
                    tsbDelete.Enabled = true;
                    tsbUndelete.Enabled = false;
                    break;
            }

            var totals = new PhotoTotals(_bindingSource.List.Cast<Photo>().ToList());

            tsbIncludeAll.Enabled = totals.Pending > 0;
            tsbExcludeAll.Enabled = totals.Pending > 0;

            tsslStatus.Text = string.Format("{0} Pending - {1} Included - {2} Excluded - {3} Deleted", totals.Pending, totals.Included, totals.Excluded, totals.Deleted);
        }

        private void tsbExclude_Click(object sender, EventArgs e)
        {
            var record = (Photo)_bindingSource.Current;

            record.Status = PhotoStatus.Excluded;
            
            record.Save(true);

            SetIncludeExclude(record);
        }

        private void tsbInclude_Click(object sender, EventArgs e)
        {
            var record = (Photo)_bindingSource.Current;

            record.Status = PhotoStatus.Included;

            record.Save(true);

            SetIncludeExclude(record);
        }

        private void tsbCounterClockwise_Click(object sender, EventArgs e)
        {
            var record = _bindingSource.Current as Photo;

            PhotoService.RotateImage(record, true);

            LoadPhotoData();
        }

        private void tsbClockwise_Click(object sender, EventArgs e)
        {
            var record = _bindingSource.Current as Photo;

            PhotoService.RotateImage(record);

            LoadPhotoData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var record = (Photo)_bindingSource.Current;

            if (record == null)
            {
                return;
            }

            if (MessageBox.Show("Are you SURE you want to delete this photo?", "Verify Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            record.Status = PhotoStatus.Deleted;
            record.DateDeleted = DateTime.Now;

            record.Save(true);

            SetIncludeExclude(record);
        }

        private void tsbUndelete_Click(object sender, EventArgs e)
        {
            var record = (Photo)_bindingSource.Current;

            if (record == null)
            {
                return;
            }

            if (MessageBox.Show("Are you SURE you want to undelete this photo?", "Verify Undelete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            record.Status = PhotoStatus.Pending;
            record.DateDeleted = null;

            record.Save(true);

            SetIncludeExclude(record);
        }

        private void tsbIncludeAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you SURE you want to include all pending photos?", "Verify Include All", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var list = _bindingSource.List.Cast<Photo>().ToList();

            foreach (var photo in list.Where(x => x.Status == PhotoStatus.Pending))
            {
                photo.Status = PhotoStatus.Included;
            }

            list.Save();

            Close();
        }

        private void tsbExcludeAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you SURE you want to exclude all pending photos?", "Verify Exclude All", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var list = _bindingSource.List.Cast<Photo>().ToList();

            foreach (var photo in list.Where(x => x.Status == PhotoStatus.Pending))
            {
                photo.Status = PhotoStatus.Excluded;
            }

            list.Save();

            Close();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
