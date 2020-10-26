using System;
using System.IO;
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
    public partial class DragAndDrop : Form
    {
        public DragAndDrop()
        {
            InitializeComponent();
        }
        //Opens the About Form.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
        //Closes the drag drop application.
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes this form.
            this.Close();
        }

        //Allows for the drag into the box to work properly as expected.
        private void DragandDropBox_DragEnter(object sender, DragEventArgs e)
        {
            //allows for the drag of the file to be droped onto the text box
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;   //if there is item in file, copies onto the text box
            }
            else
            {
                e.Effect = DragDropEffects.None;   //if there is nothing in the file, does not copy
            }
        }

        //Allows for the files to be droped in so it would be able to be viewed.
        private void DragandDropBox_DragDrop(object sender, DragEventArgs e)
        {
            //Allows for the process of reading and writing the file to be put into the textbox
            Array input = (Array)e.Data.GetData(DataFormats.FileDrop);

            if (input.Length != 0)
            {
                label2.Text = input.GetValue(0).ToString();
                //Reads the code to allow the computer to know what is in the file
                System.IO.StreamReader file = new
                System.IO.StreamReader(label2.Text);
                //writes to the code onto the textbox
                DragandDropBox.Text = file.ReadToEnd();
                file.Close();
            }
        }
    }
}
