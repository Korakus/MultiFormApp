using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsDemonstration1
{
    public partial class PictureViewer : Form
    {
        //Global variables.
        string path;
        public PictureViewer()
        {
            InitializeComponent();
        }
        //Opens a picture/image to the picture box.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the file pop up box to search for image.
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "BMP |*.bmp |Jpeg|*.jpg";
            //Checks if the image fits requirements to show.
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Shows it the picture viewer.
                pictureViewerPictureBox.Load(dialog.FileName);
                pictureViewerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        //Saving the iamge that was opened on the picture viewer.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the file pop up box to allow you to save the iamge.
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "BMP |*.bmp |Jpeg|*.jpg";
            //checks if the save file meets requirements to be saved.
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Writes it to the storage device so it will be saved.
                System.IO.StreamWriter file = new
                    System.IO.StreamWriter(dialog.FileName);
                //Finishes writing the image to storage device.
                file.Write(pictureViewerPictureBox.Text);
                //Closes the file.
                file.Close();
            }
            path = dialog.FileName;
        }
        //Closes the Picture viewer application.
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes picture viewer application.
            this.Close();
        }
        //Opens the about form.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }
}
