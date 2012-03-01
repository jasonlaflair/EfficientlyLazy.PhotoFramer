using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EfficientlyLazy.PhotoFramer.Entities;
using EfficientlyLazy.PhotoFramer.Services;

namespace EfficientlyLazy.PhotoFramer
{
    public partial class frmDashboard : Form
    {
        private readonly Timer _timer;

        public frmDashboard()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Tick += TimerOnTick;
            _timer.Interval = 500;

            UpdatePathRequiredButtons();
            UpdateTotals();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            _timer.Stop();

            UpdatePathRequiredButtons();

            _timer.Start();
        }

        private void UpdatePathRequiredButtons()
        {
            var archiveExists = Directory.Exists(Configuration.ArchivePath);
            var cameraExists = Directory.Exists(Configuration.CameraPath);
            var frameExists = Directory.Exists(Configuration.FramePath);

            cmdSyncArchive.Enabled = archiveExists;
            cmdExtractFromCamera.Enabled = archiveExists && cameraExists;
            cmdUpdateFrame.Enabled = archiveExists && frameExists;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _timer.Start();
        }

        private void UpdateTotals()
        {
            var totals = new PhotoTotals();

            tsslTotal.Text = string.Format("Total: {0}", totals.Total);

            tsslFrameTotal.Text = totals.FrameCurrent != totals.FrameProjected
                                      ? string.Format("Frame: {0}/{1}", totals.FrameCurrent, totals.FrameProjected)
                                      : string.Format("Frame: {0}", totals.FrameCurrent);

            cmdProcessPending.Enabled = totals.Pending != 0;
            cmdProcessPending.Text = totals.Pending > 0
                                         ? string.Format("Process {0} Pending", totals.Pending)
                                         : "No Photos Pending";

            cmdViewIncluded.Enabled = totals.Included != 0;
            cmdViewIncluded.Text = totals.Included > 0
                                       ? string.Format("View {0} On Frame", totals.Included)
                                       : "No Photos Included";

            cmdReviewExcluded.Enabled = totals.Excluded != 0;
            cmdReviewExcluded.Text = totals.Excluded > 0
                                         ? string.Format("View {0} Excluded", totals.Excluded)
                                         : "No Photos Excluded";

            cmdUpdateFrame.BackColor = totals.FramePendingAdd == 0 && totals.FramePendingRemove == 0
                                           ? SystemColors.Control
                                           : Color.PaleGreen;

            cmdProcessPending.BackColor = totals.Pending == 0
                                              ? SystemColors.Control
                                              : Color.PaleGreen;
        }

        private void cmdProcessPending_Click(object sender, EventArgs e)
        {
            var list = Repository.Photos()
                .Where(x => x.Status == PhotoStatus.Pending)
                .ToList();

            using (var frm = new frmPhotoList(list))
            {
                frm.ShowDialog();
            }

            UpdateTotals();
        }

        private void cmdViewIncluded_Click(object sender, EventArgs e)
        {
            var list = Repository.Photos()
                .Where(x => x.Status == PhotoStatus.Included)
                .ToList();

            using (var frm = new frmPhotoList(list))
            {
                frm.ShowDialog();
            }

            UpdateTotals();
        }

        private void cmdReviewExcluded_Click(object sender, EventArgs e)
        {
            var list = Repository.Photos()
                .Where(x => x.Status == PhotoStatus.Excluded)
                .ToList();

            using (var frm = new frmPhotoList(list))
            {
                frm.ShowDialog();
            }

            UpdateTotals();
        }

        private void cmdSyncArchive_Click(object sender, EventArgs e)
        {
            var status = PhotoService.SyncArchive();

            UpdateTotals();

            MessageBox.Show(string.Format("Added: {0}\r\nRemoved: {1}\r\nExisting: {2}", status.Added, status.Removed, status.Existing), "Sync Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdConfiguration_Click(object sender, EventArgs e)
        {
            using (var frm = new frmConfiguration())
            {
                frm.ShowDialog();
            }

            UpdatePathRequiredButtons();
        }

        private void cmdUpdateFrame_Click(object sender, EventArgs e)
        {
            var status = PhotoService.UpdateFrame();

            UpdateTotals();

            MessageBox.Show(string.Format("Added: {0}\r\nRemoved: {1}\r\nExisting: {2}", status.Added, status.Removed, status.Existing), "Frame Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdExtractFromCamera_Click(object sender, EventArgs e)
        {
            var status = PhotoService.ExtractFromCamera();

            UpdateTotals();

            MessageBox.Show(string.Format("Added: {0}\r\nRemoved: {1}\r\nExisting: {2}", status.Added, status.Removed, status.Existing), "Camera Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdCleanup_Click(object sender, EventArgs e)
        {
            var status = PhotoService.Cleanup();

            UpdateTotals();

            MessageBox.Show(string.Format("Added: {0}\r\nRemoved: {1}\r\nExisting: {2}", status.Added, status.Removed, status.Existing), "Cleanup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
