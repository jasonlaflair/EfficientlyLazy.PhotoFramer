using System;
using System.Windows.Forms;
using EfficientlyLazy.PhotoFramer.Entities;

namespace EfficientlyLazy.PhotoFramer
{
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();

            txtArchivePath.Text = Configuration.ArchivePath;
            txtCameraPath.Text = Configuration.CameraPath;
            txtFramePath.Text = Configuration.FramePath;
            nudFrameHeight.Value = Configuration.FrameHeight;
            nudFrameWidth.Value = Configuration.FrameWidth;
            txtExtensionsCSV.Text = Configuration.ExtensionsCSV;
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {

        }

        private void cmdBrowseFrame_Click(object sender, EventArgs e)
        {
            BrowseFolder(txtFramePath, "Frame");
        }

        private void cmdBrowseArchive_Click(object sender, EventArgs e)
        {
            BrowseFolder(txtArchivePath, "Archive");
        }

        private void cmdBrowseCamera_Click(object sender, EventArgs e)
        {
            BrowseFolder(txtCameraPath, "Camera");
        }

        private void BrowseFolder(TextBox textBox, string heading)
        {
            using (var b = new FolderBrowserDialog())
            {
                b.Description = "Select path for " + heading;
                b.ShowNewFolderButton = true;


                if (b.ShowDialog(this) == DialogResult.OK)
                {
                    textBox.Text = b.SelectedPath;
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Configuration.ArchivePath = txtArchivePath.Text;
            Configuration.CameraPath = txtCameraPath.Text;
            Configuration.FramePath = txtFramePath.Text;
            Configuration.FrameHeight = (int)nudFrameHeight.Value;
            Configuration.FrameWidth = (int)nudFrameWidth.Value;
            Configuration.ExtensionsCSV = txtExtensionsCSV.Text;

            Configuration.Save();

            Close();
        }
    }
}
