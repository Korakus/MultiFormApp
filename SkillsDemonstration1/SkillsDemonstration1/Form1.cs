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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Application opened from button on Main Form.
        //Opens the Word Processor form when button is clicked.
        private void WordProcessor_Click(object sender, EventArgs e)
        {
            WordProcessor wordProcessorForm = new WordProcessor();
            wordProcessorForm.Show();
        }

        //Opens the Picture Viewer form when button is clicked.
        private void PictureViewer_Click(object sender, EventArgs e)
        {
            PictureViewer pictureViewerForm = new PictureViewer();
            pictureViewerForm.Show();
        }

        //Opens the Web Browser form when button is clicked.
        private void WebBrowser_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowserForm = new WebBrowser();
            webBrowserForm.Show();
        }

        //Opens the Calculator form when button is clicked.
        private void Calculator_Click(object sender, EventArgs e)
        {
            Calculator calculatorForm = new Calculator();
            calculatorForm.Show();
        }

        //Opens Drag and Drop form when button is clicked.
        private void DragAndDrop_Click(object sender, EventArgs e)
        {
            DragAndDrop dragAndDropForm = new DragAndDrop();
            dragAndDropForm.Show();
        }

        //Opens About form when button is clicked.
        private void About_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        //Applications when opened through Menu Strip.
        //Opens Word Processor through the menu.
        private void wordProcessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordProcessor wordProcessorForm = new WordProcessor();
            wordProcessorForm.Show();
        }

        //Opens Picture Viewer through the menu.
        private void pictureViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureViewer pictureViewerForm = new PictureViewer();
            pictureViewerForm.Show();
        }

        //Opens Web Browser through the menu.
        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowserForm = new WebBrowser();
            webBrowserForm.Show();
        }

        //Opens Calculator through the menu.
        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculatorForm = new Calculator();
            calculatorForm.Show();
        }

        //Opens Drag and Drop through the menu.
        private void dragAndDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DragAndDrop dragAndDropForm = new DragAndDrop();
            dragAndDropForm.Show();
        }

        //Exits the application.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Changes Colour's of the Background of Main Form.
        //Changes background colour to White.
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (whiteToolStripMenuItem.Text == "White")
            {
                panel1.BackColor = Color.White;
            }
        }

        //Changes background colour to Blue.
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (blueToolStripMenuItem.Text == "Blue")
            {
                panel1.BackColor = Color.Blue;
            }
        }

        //Changes background colour to Red.
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redToolStripMenuItem.Text == "Red")
            {
                panel1.BackColor = Color.Red;
            }
        }

        //Changes background colour to Yellow.
        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yellowToolStripMenuItem.Text == "Yellow")
            {
                panel1.BackColor = Color.Yellow;
            }
        }

        //Changes background colour to Green.
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (greenToolStripMenuItem.Text == "Green")
            {
                panel1.BackColor = Color.Green;
            }
        }

        //Opens the About Form through the menu strip.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }
}
