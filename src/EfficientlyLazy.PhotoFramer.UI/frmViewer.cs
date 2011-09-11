using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EfficientlyLazy.PhotoFramer.Entities;
using EfficientlyLazy.PhotoFramer.Repositories;

namespace EfficientlyLazy.PhotoFramer.UI
{
    public partial class frmViewer : Form
    {
        private readonly IWriteableRepository<Photo> _photoRepository = ServiceFactory.Resolve<IWriteableRepository<Photo>>();

        private readonly List<Photo> _photos = new List<Photo>();

        private int _min = 0;
        private int _max = 0;
        private int _index = 0;
        private Image _indexImage;

        public frmViewer()
        {
            InitializeComponent();

            LoadImageCache();
        }

        private void LoadImageCache(bool tryToMaintainCurrentIndex = false)
        {
            _photos.Clear();

            var list = _photoRepository.Query().Where(x => !x.MarkedAsDeleted).OrderByDescending(x => x.DateAdded);

            _photos.AddRange(list);

            _min = 0;
            _max = _photos.Count - 1;

            _index = tryToMaintainCurrentIndex ? Math.Min(_index, _max) : 0;

            UpdateCounter();

            LoadIndexImage();
        }

        private void UpdateCounter()
        {
            var current = _index + 1;
            var total = _max + 1;

            var forFrame = _photos.Count(x => !x.MarkedAsDeleted && x.IncludeOnFrame);

            lblCounter.Text = string.Format("{0} of {1} - {2} included on frame", current, total, forFrame);
        }

        private void LoadIndexImage()
        {
            gbControls.Enabled = false;
            Refresh();
            Application.DoEvents();

            if (_indexImage != null)
            {
                _indexImage.Dispose();
            }

            var photo = _photos[_index];

            _indexImage = Image.FromFile(photo.FullFilename);

            pbPhoto.Image = _indexImage;
            cbxIncludeOnFrame.Checked = photo.IncludeOnFrame;

            UpdateCounter();

            gbControls.Enabled = true;
        }

        private void frmViewer_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdFirst_Click(object sender, EventArgs e)
        {
            _index = 0;

            LoadIndexImage();
        }

        private void cmdPrevious_Click(object sender, EventArgs e)
        {
            _index = Math.Max(_min, --_index);

            LoadIndexImage();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            _index = Math.Min(_max, ++_index);

            LoadIndexImage();
        }

        private void cmdLast_Click(object sender, EventArgs e)
        {
            _index = _max;

            LoadIndexImage();
        }

        private void cbxIncludeOnFrame_CheckedChanged(object sender, EventArgs e)
        {
            var photo = _photos[_index];
            photo.IncludeOnFrame = cbxIncludeOnFrame.Checked;
            _photoRepository.SaveAndFlush(photo);

            UpdateCounter();
        }

        private void cmdRotateClockwise_Click(object sender, EventArgs e)
        {
            gbControls.Enabled = false;
            Refresh();
            Application.DoEvents();

            _indexImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            _indexImage.Save(_photos[_index].FullFilename);

            pbPhoto.Image = _indexImage;

            gbControls.Enabled = true;
        }

        private void cmdRotateCounterClockwise_Click(object sender, EventArgs e)
        {
            _indexImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            _indexImage.Save(_photos[_index].FullFilename);

            pbPhoto.Image = _indexImage;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you SURE you want to delete this photo?", "Verify Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var photo = _photos[_index];
            photo.MarkedAsDeleted = true;
            _photoRepository.SaveAndFlush(photo);

            LoadImageCache(true);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<Keys> _interceptedKeys = new List<Keys>
                                                  {
                                                      Keys.Left,
                                                      Keys.Right
                                                  };

        private void frmViewer_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    cmdPrevious.PerformClick();
                    break;
                case Keys.Right:
                    cmdNext.PerformClick();
                    break;
            }

            e.Handled = _interceptedKeys.Contains(e.KeyCode);
        }
    }
}
