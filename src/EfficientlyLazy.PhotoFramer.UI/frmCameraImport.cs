using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EfficientlyLazy.PhotoFramer.Services;

namespace EfficientlyLazy.PhotoFramer.UI
{
    public partial class frmCameraImport : Form
    {
        
        private readonly BackgroundWorker _worker;

        private class WorkerParameters
        {
            public string Directory { get; set; }
            public bool DeleteOriginals { get; set; }
        }

        public frmCameraImport()
        {
            InitializeComponent();

            lblCameraRoot.Text = AppSettings.CameraRoot;

            _worker = new BackgroundWorker();
            _worker.DoWork += WorkerDoWork;
            _worker.RunWorkerCompleted += WorkerRunWorkerCompleted;
        }

        private void WorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var imported = (int) e.Result;

            MessageBox.Show(string.Format("{0} Photo(s) were imported.", imported), "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }

            UseWaitCursor = false;
            Refresh();
            Application.DoEvents();
        }

        private void WorkerDoWork(object sender, DoWorkEventArgs e)
        {
            var photoService = ServiceFactory.Resolve<IPhotoService>();

            var workerParams = (WorkerParameters) e.Argument;

            e.Result = photoService.AddPhotos(workerParams.Directory, workerParams.DeleteOriginals);
        }

        private void frmCameraImport_Load(object sender, EventArgs e)
        {
            
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
                AppSettings.CameraRoot = bfd.SelectedPath;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdImportFromCamera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AppSettings.CameraRoot))
            {
                MessageBox.Show("Camera Path Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(AppSettings.CameraRoot))
            {
                MessageBox.Show("Camera Path Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;                
            }

            var workerParams = new WorkerParameters
                            {
                                DeleteOriginals = cbxDeleteFromCamera.Checked,
                                Directory = AppSettings.CameraRoot
                            };

            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            UseWaitCursor = true;
            Refresh();
            Application.DoEvents();

            _worker.RunWorkerAsync(workerParams);
        }
    }
}
