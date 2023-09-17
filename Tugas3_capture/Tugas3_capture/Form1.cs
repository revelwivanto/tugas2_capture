using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace Tugas3_capture
{
    public partial class CameraApp : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice videoSource;
        public CameraApp()
        {
            InitializeComponent();
        }

        private void CameraApp_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo devicelist in captureDevice)
            {
                listCameraComboBox.Items.Add(devicelist.Name);
            }
            listCameraComboBox.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();

        }

        private void startBox_TextChanged(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }

            videoSource = new VideoCaptureDevice(captureDevice[listCameraComboBox.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void captureBox_TextChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void saveBox_TextChanged(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "save Image as";
            saveFileDialog.Filter = "Image Files (*.jpg, *.png) | *.jpg, *.png";
            ImageFormat imageFormat = ImageFormat.Png;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".Png":
                        imageFormat = ImageFormat.Png;
                        break;
                }
                pictureBox2.Image.Save(saveFileDialog.FileName, imageFormat);
            }
        }

        private void exitBxox_TextChanged(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                pictureBox2.Image = null;
                pictureBox2.Invalidate();
            }
            Application.Exit(null);
        }

        
    }
}
