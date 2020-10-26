using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsDemonstration1
{
    public partial class WordProcessor : Form
    {
        //Global Variables.
        string path;

        public WordProcessor()
        {
            InitializeComponent();
        }

        //Menu Strip File options.
        //Save Option.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Saves to a file that is previously made.
            if (path.Length > 0) //if length is greater than 0.
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(path);
                file.Write(wordProcessorTextBox.Text);
                file.Close();
            }

            if (path.Length == 0) //if no path it empty.
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "A text File |*.txt|MS Word|*.Doc*";
                //Reads and writes the file to allow for it to save.
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter file = new
                        System.IO.StreamWriter(dialog.FileName);
                    file.Write(wordProcessorTextBox.Text);
                    file.Close();
                }

            }
        }

        //Save As Option.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Saving As a new file.
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "A text File |*.txt|MS word|*.doc";
            //This reads and writes the file to allow the file to save.
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter file = new
                    System.IO.StreamWriter(dialog.FileName);

                file.Write(wordProcessorTextBox.Text);
                file.Close();
            }
            path = dialog.FileName;
        }

        //Open Option.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opening a file that is already created.
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "A text File|*.txt|MS Word|*.doc*";
            //This reads and writes the file to allow for it to open the text within.
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader file = new
                    System.IO.StreamReader(dialog.FileName);
                wordProcessorTextBox.Text = file.ReadToEnd();
                file.Close();
            }

            path = dialog.FileName;
        }

        //Print Option.
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Printing the document.
            PrintDocument p = new PrintDocument();
            string output = wordProcessorTextBox.Text;

            //draws page for print.
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(
                    output,
                    new Font("Arial", 11),
                    new SolidBrush(Color.Black),
                    new RectangleF(0, 0,
                    p.DefaultPageSettings.PrintableArea.Width,
                    p.DefaultPageSettings.PrintableArea.Height));
            };

            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.Document = p;

            //prints the text to the pdf.
            if (PrintDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Print();
            }
        }

        //Close Form Option.
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Edit Options on Menu Strip.
        //Font Size Options.
        //Font size 8.
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Changes the font to a size of 8.
            if (toolStripMenuItem2.Text == "8")
            {
                wordProcessorTextBox.Font = new Font(wordProcessorTextBox.Font.ToString(), 8);
            }
        }

        //Font size 10.
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Changes the font to a size of 10.
            if (toolStripMenuItem3.Text == "10")
            {
                wordProcessorTextBox.Font = new Font(wordProcessorTextBox.Font.ToString(), 10);
            }
        }

        //Font size 12.
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //Changes the font to a size of 12.
            if (toolStripMenuItem4.Text == "12")
            {
                wordProcessorTextBox.Font = new Font(wordProcessorTextBox.Font.ToString(), 12);
            }
        }

        //Font size 14.
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //Changes the font to a size of 14.
            if (toolStripMenuItem5.Text == "14")
            {
                wordProcessorTextBox.Font = new Font(wordProcessorTextBox.Font.ToString(), 14);
            }
        }

        //Font size 16.
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //Changes the font to a size of 16.
            if (toolStripMenuItem6.Text == "16")
            {
                wordProcessorTextBox.Font = new Font(wordProcessorTextBox.Font.ToString(), 16);
            }
        }

        //Changing Font types for the text.
        //Font type "Times Roman".
        private void timesRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes the font type to "Times Roman".
            if (timesRomanToolStripMenuItem.Text == "Times Roman")
            {
                wordProcessorTextBox.Font = new Font(timesRomanToolStripMenuItem.Text, wordProcessorTextBox.Font.Size);
            }
        }

        //Font type "Calibri".
        private void calibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes the font type to "Calibri".
            if (calibriToolStripMenuItem.Text == "Calibri")
            {
                wordProcessorTextBox.Font = new Font(calibriToolStripMenuItem.Text, wordProcessorTextBox.Font.Size);
            }
        }

        //Font type "Courier".
        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes the font type to "Courier".
            if (courierToolStripMenuItem.Text == "Courier")
            {
                wordProcessorTextBox.Font = new Font(courierToolStripMenuItem.Text, wordProcessorTextBox.Font.Size);
            }
        }

        //Changing the Font's colour.
        //Font colour Black.
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes the font to Black.
            if (blackToolStripMenuItem.Text == "Black")
            {
                wordProcessorTextBox.ForeColor = Color.Black;
            }
        }

        //Font colour to Red.
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes the font to Red.
            if (redToolStripMenuItem.Text == "Red")
            {
                wordProcessorTextBox.ForeColor = Color.Red;
            }
        }

        //Font colour to Green.
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes the font to Green.
            if (greenToolStripMenuItem.Text == "Green")
            {
                wordProcessorTextBox.ForeColor = Color.Green;
            }
        }

        //Font colour to Blue.
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changes the font to Blue.
            if (blueToolStripMenuItem.Text == "Blue")
            {
                wordProcessorTextBox.ForeColor = Color.Blue;
            }
        }

        //Changing the Background of the Box.
        //Background colour White.
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes background to White.
            if (whiteToolStripMenuItem.Text == "White")
            {
                wordProcessorTextBox.BackColor = Color.White;
            }
        }

        //Background colour Yellow.
        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changes background to Yellow.
            if (yellowToolStripMenuItem.Text == "Yellow")
            {
                wordProcessorTextBox.BackColor = Color.Yellow;
            }
        }

        //Background colour Purple.
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changes background to Purple.
            if (purpleToolStripMenuItem.Text == "Purple")
            {
                wordProcessorTextBox.BackColor = Color.Purple;
            }
        }
        //Background colour Orange.
        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changes background to Orange.
            if (orangeToolStripMenuItem.Text == "Orange")
            {
                wordProcessorTextBox.BackColor = Color.Orange;
            }
        }

        //Opens the About Form to tell user about this Application
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }
}
