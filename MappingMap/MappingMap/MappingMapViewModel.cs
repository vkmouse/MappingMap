using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using ViewerLib;

namespace MappingMap
{
    public class MappingMapViewModel
    {
        enum Mode { MAPPING_MODE, SETTING_MODE }

        MappingMapView view;
        MappingMapKerenl kernel;
        Mode mode;

        private Image pictureBox_Image
        {
            set
            {
                if (!(view.picDisplayImage.BackgroundImage is null))
                    view.picDisplayImage.BackgroundImage.Dispose();
                view.picDisplayImage.BackgroundImage = value;
            }
        }

        public MappingMapViewModel(MappingMapView view)
        {
            this.view = view;

            kernel = new MappingMapKerenl(view.picDisplayImage.Size);
            view.btnSetting.Click += new EventHandler(btnSetting_Click);
            view.cboMode.SelectedIndexChanged += new EventHandler(cboMode_SelectedIndexChanged);
            view.txtImagePath.TextChanged += new EventHandler(txtImagePath_TextChanged);
            view.vsbImageScale.ValueChanged += new EventHandler(vsbImageScale_ValueChanged);
            view.Load += new EventHandler(View_Load);
            view.picDisplayImage.MouseClick += new MouseEventHandler(picDisplayImage_MouseClick);
            view.picDisplayImage.MouseDown += new MouseEventHandler(picDisplayImage_MouseDown);
            view.picDisplayImage.MouseMove += new MouseEventHandler(picDisplayImage_MouseMove);
            view.picDisplayImage.MouseUp += new MouseEventHandler(picDisplayImage_MouseUp);
            view.picDisplayImage.MouseWheel += new MouseEventHandler(picDisplayImage_MouseWheel);
            view.picDisplayImage.Resize += new EventHandler(picDisplayImage_Resize);
            view.mnuSave.Click += new EventHandler(mnuSave_Click);
            view.mnuLoad.Click += new EventHandler(mnuLoad_Click);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            // Display setting panel or not
            view.pnlSetting.Visible = !view.pnlSetting.Visible;

            // Set mode to mapping mode or setting mode
            view.cboMode.SelectedIndex = view.pnlSetting.Visible ? 0 : 1;
        }

        private void View_Load(object sender, EventArgs e)
        {
            // Initial mode
            view.cboMode.SelectedIndex = 0;

            // Initial scale
            view.vsbImageScale.Value = 100;
            view.vsbImageScale.Minimum = 0;
            view.vsbImageScale.Maximum = 6400;
        }

        private void txtImagePath_TextChanged(object sender, EventArgs e)
        {
            // Set new image path to kernel
            kernel.ImagePath = view.txtImagePath.Text;

            // Update image and scale
            pictureBox_Image = kernel.Image;
            view.vsbImageScale.Value = (int)kernel.Scale;
        }

        private void picDisplayImage_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.Delta > 0 && mode is Mode.SETTING_MODE) // Zoom in
            {
                pictureBox_Image = kernel.Operate(OperateType.VIEWER_ZOOM_IN, e.Location);
                view.vsbImageScale.Value = (int)kernel.Scale; // Update scale
            }
            else if (Control.ModifierKeys == Keys.Control && e.Delta < 0 && mode is Mode.SETTING_MODE) // Zoom out
            {
                pictureBox_Image = kernel.Operate(OperateType.VIEWER_ZOOM_OUT, e.Location);
                view.vsbImageScale.Value = (int)kernel.Scale; // Update scale
            }
        }

        private void picDisplayImage_Resize(object sender, EventArgs e)
        {
            pictureBox_Image = kernel.Operate(OperateType.VIEWER_RESIZE, view.picDisplayImage.Size);
        }

        private void picDisplayImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && mode is Mode.SETTING_MODE)
            {
                pictureBox_Image = kernel.Operate(OperateType.VIEWER_PANNING_BEGIN, e.Location);
            }
        }

        private void picDisplayImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && mode is Mode.SETTING_MODE)
            {
                pictureBox_Image = kernel.Operate(OperateType.VIEWER_PANNING_MOVE, e.Location);
            }
            view.picDisplayImage.Refresh();
        }

        private void picDisplayImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && mode is Mode.SETTING_MODE)
            {
                pictureBox_Image = kernel.Operate(OperateType.VIEWER_PANNING_END, e.Location);
            }
            view.Cursor = Cursors.Default;
            view.picDisplayImage.Refresh();
        }

        private void picDisplayImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && mode is Mode.MAPPING_MODE)
            {
                // Mapping mode and click left mouse button, move to the archor
                pictureBox_Image = kernel.MoveToAnchor(e.Location); 
            }
            else if (e.Button == MouseButtons.Right && mode is Mode.SETTING_MODE)
            {
                // Setting mode and click right mouse button, set current location to the archor
                view.txtRelativeLocation.Text = kernel.SetAnchor(e.Location).ToString();
            }
        }

        private void vsbImageScale_ValueChanged(object sender, EventArgs e)
        {
            // Rescale the image
            kernel.Scale = view.vsbImageScale.Value;
            pictureBox_Image = kernel.Image;
        }

        private void cboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view.cboMode.Text == "Setting") // Enable the UI
            {
                mode = Mode.SETTING_MODE;
                view.vsbImageScale.Enabled = true;
                view.txtImagePath.Enabled = true;
                view.txtRelativeLocation.Enabled = true;
            }
            else if (view.cboMode.Text == "Mapping")  // Disable the UI
            {
                mode = Mode.MAPPING_MODE;
                view.vsbImageScale.Enabled = false;
                view.txtImagePath.Enabled = false;
                view.txtRelativeLocation.Enabled = false;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            // Save a config
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Config files (*.json)|*.json|All files (*.*)|*.*";
            fileDialog.Title = "Save a config";
            fileDialog.ShowDialog();
            if (fileDialog.FileName != string.Empty)
            {
                File.WriteAllText(fileDialog.FileName, MappingMapKerenl.ToJson(kernel));
            }
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            // Load a config
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Config files (*.json)|*.json|All files (*.*)|*.*";
            fileDialog.Title = "Load a config";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(fileDialog.FileName);
                kernel = MappingMapKerenl.FromJson(content);
                pictureBox_Image = kernel.Operate(OperateType.VIEWER_RESIZE, view.picDisplayImage.Size);
                view.txtImagePath.Text = kernel.ImagePath;
                view.vsbImageScale.Value = (int)kernel.Scale;
                view.txtRelativeLocation.Text = kernel.RelativeLocation.ToString();
            }
        }
    }
}
