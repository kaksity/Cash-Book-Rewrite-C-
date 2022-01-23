using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBook.UI.Utilities
{
    public partial class FrmAcquirePhoto : Form
    {
        public FrmAcquirePhoto()
        {
            InitializeComponent();
        }

        private Image originalImage = null;
        private bool okClicked = false;
        private Rectangle rectangle;
        private Graphics graphics = null;
        private Pen biro = null;


        private void btnClearPreview_Click(object sender, EventArgs e)
        {
            if (picPreview.Image != null)
            {
                picPreview.Image = null;
            }
        }

        private void btnHorizontal_Click(object sender, EventArgs e)
        {
            Image img;

            if (picPhoto.Image == null) return;
            img = picPhoto.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipY);
            picPhoto.Image = img;
        }

        private void btnVertical_Click(object sender, EventArgs e)
        {
            Image img;

            if (picPhoto.Image == null) return;
            img = picPhoto.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipX);
            picPhoto.Image = img;
        }
        private Image LoadImageFromFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "(*.jpg)|*jpg| (*.jpeg)|*.jpeg| (*.png)|*.png| (*.bmp)|*.bmp| (*.gif)|*gif| (*.svg)|*.svg";

            dialog.ShowDialog();

            string fileName = dialog.FileName;

            if (string.IsNullOrWhiteSpace(fileName) == true)
                return null;
            else
                return Image.FromFile(fileName);   
        }

        private void btnAcquire_Click(object sender, EventArgs e)
        {
            if(chkFile.Checked == true)
            {
                picPhoto.Image = LoadImageFromFile();
                originalImage = picPhoto.Image;
            }
        }

        private void Slider_Scroll(object sender, EventArgs e)
        {
            if (picPhoto.Image == null) return;

            var newImage = Zoom(picPhoto.Image, Slider.Value);

            if(newImage != null)
            {
                picPhoto.Image = (Image)newImage.Clone();
                newImage.Dispose();
            }
            
        }
        private Image Zoom(Image image,int zoomFactor)
        {
            // Get the height and width of the new image
            int height = Convert.ToInt32(image.Height * zoomFactor) / 100;
            int width = Convert.ToInt32(image.Width * zoomFactor) / 100;

            if(height == 0 || width == 0) return null;

            // Create a new image based on the width and the height;
            var newImage = new Bitmap(image,width,height);

            var convertedImage = Graphics.FromImage(newImage);

            // Clean up the Image

            convertedImage.InterpolationMode = InterpolationMode.HighQualityBicubic;


            return newImage;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            okClicked = true;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            okClicked = false;
            this.Close();
        }
        private void DrawRectangle(int mouseX, int mouseY)
        {
            rectangle.X = (int)(mouseX - (0.5 * rectangle.Width));
            rectangle.Y = (int)(mouseY - (0.5 * rectangle.Height));

            this.Refresh();
            graphics.DrawRectangle(biro,rectangle);
        }
        private void CropRegion(Image imgOriginal,Rectangle area)
        {

            int height = area.Height;
            int width = area.Width;

            //var recF = imgOriginal.GetBounds(GraphicsUnit.Point);
            var bmCropped = new Bitmap(width,height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            var grCropped = Graphics.FromImage(bmCropped);

            graphics.DrawImage(imgOriginal, new Rectangle(0,0,width,height),rectangle,GraphicsUnit.Pixel);

            var mem = new MemoryStream();
            bmCropped.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);

            bmCropped.Dispose();
            grCropped.Dispose();

            picPreview.Image = Image.FromStream(mem);

        }
        public static Image AcquirePhoto()
        {
            var frmAcquire = new FrmAcquirePhoto();
            Image returnImage = null;
            frmAcquire.ShowDialog();

            if (frmAcquire.okClicked == true )
            {
                if (frmAcquire.picPreview != null)
                {
                    returnImage = frmAcquire.picPreview.Image;
                }
                else if (frmAcquire.picPreview.Image == null)
                {
                    returnImage = frmAcquire.picPhoto.Image;
                }
            }

            frmAcquire.okClicked = false;
            return returnImage;
        }

        private void chkFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFile.Checked == true)
            {
                chkDialog.Enabled = false;
                btnSelect.Enabled = false;
            }
            else
            {
                chkDialog.Enabled = true;
                btnSelect.Enabled = true;
            }
        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            if (picPhoto.Image == null) return;
            CropRegion(picPhoto.Image,rectangle);
        }

        private void picPhoto_MouseMove(object sender, MouseEventArgs e)
        {
            DrawRectangle(e.X,e.Y);
        }

        private void FrmAcquirePhoto_Load(object sender, EventArgs e)
        {
            biro = new Pen(Color.Black);
            rectangle = new Rectangle(100,100,250,250);
            graphics = picPhoto.CreateGraphics();
        }
    }
}
