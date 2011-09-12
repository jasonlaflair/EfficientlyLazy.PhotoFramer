using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EfficientlyLazy.PhotoFramer.Services;

namespace EfficientlyLazy.PhotoFramer.UI
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            LoadSettings();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void LoadSettings()
        {
            lblCameraRoot.Text = AppSettings.CameraRoot;
            lblFrameRoot.Text = AppSettings.FrameRoot;
            cbxResize.Checked = AppSettings.ResizeForFrame;
            nudHeight.Value = AppSettings.FrameHeight;
            nudWidth.Value = AppSettings.FrameWidth;
        }

        private void cmdSetCameraRoot_Click(object sender, EventArgs e)
        {
            using (var bfd = new FolderBrowserDialog())
            {
                bfd.ShowNewFolderButton = false;
                bfd.RootFolder = Environment.SpecialFolder.MyComputer;

                if (bfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                lblCameraRoot.Text = bfd.SelectedPath;
            }
        }

        private void cmdSetFrameRoot_Click(object sender, EventArgs e)
        {
            using (var bfd = new FolderBrowserDialog())
            {
                bfd.ShowNewFolderButton = false;
                bfd.RootFolder = Environment.SpecialFolder.MyComputer;

                if (bfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                lblFrameRoot.Text = bfd.SelectedPath;
            }
        }

        private void cmdRevert_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            AppSettings.CameraRoot = lblCameraRoot.Text;
            AppSettings.FrameRoot = lblFrameRoot.Text;
            AppSettings.ResizeForFrame = cbxResize.Checked;
            AppSettings.FrameHeight = (int)nudHeight.Value;
            AppSettings.FrameWidth = (int)nudWidth.Value;

            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxResize_CheckedChanged(object sender, EventArgs e)
        {
            nudHeight.Enabled = cbxResize.Checked;
            nudWidth.Enabled = cbxResize.Checked;
        }
    }
}
