using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EfficientlyLazy.PhotoFramer.Entities;

namespace EfficientlyLazy.PhotoFramer.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
      }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void cmdLoadFromCamera_Click(object sender, EventArgs e)
        {
            using (var frm = new frmCameraImport())
            {
                frm.ShowDialog();
            }
        }

        private void cmdViewer_Click(object sender, EventArgs e)
        {
            using (var frm = new frmViewer())
            {
                frm.ShowDialog();
            }
        }

    }
}
