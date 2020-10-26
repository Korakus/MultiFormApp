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
    public partial class WebBrowser : Form
    {
        //This is the WebBrowser Form
        public WebBrowser()
        {
            InitializeComponent();
        }
        //When the WebBrowser Form is opened, It will navigate to Google.com if has connection to internet.
        private void WebBrowser_Load(object sender, EventArgs e)
        {
            //goes to google.com
            webBrowser1.Navigate("www.google.com");
        }
        //When the home button is clicked it will go to home search engine, which is google.com.
        private void home_Click(object sender, EventArgs e)
        {
            //goes to google.com
            webBrowser1.Navigate("www.google.com");
        }
        //This is the search engine for when the user wishes to search for something through the URL.
        private void search_Click(object sender, EventArgs e)
        {
            //Goes the the "Search" method
            Search();
        }
        //This is the Search method which searches for the url.
        private void Search()
        {
            //If statement, if textbox contains url code it will navigate to writen url code.
            if (textBox1.Text.Contains(".") && !textBox1.Text.Contains(" "))
            {
                webBrowser1.Navigate(textBox1.Text);
            }
            //Else it will not and display this is not url link/safe search link.
            else
            {
                webBrowser1.Navigate(@"https://www.google.ie/webhp?ion=1&espv=2&ieUTF-8#safe=strict&q=" + textBox1.Text);
            }
        }
        //When key pressed (Enter) it will allow for the user to hit Enter key to search from the URL bar.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //Initiates the Search method
                Search();
                e.Handled = true;
            }
        }
        //This is the return button, Goes back a page.
        private void backButton_Click(object sender, EventArgs e)
        {
            //Sends the webbrowser back a page.
            webBrowser1.GoBack();
        }
        //This is the forward button, Goes forward a page.
        private void forwardButton_Click(object sender, EventArgs e)
        {
            //Sends the webbrowser forward a page.
            webBrowser1.GoForward();
        }
        //This is the Refresh button, will refresh the website you are on.
        private void refreshButton_Click(object sender, EventArgs e)
        {
            //Refreshes the webbrowser.
            webBrowser1.Refresh();
        }
        //This is the Stop button, will stop the page from loading.
        private void stopButton_Click(object sender, EventArgs e)
        {
            //Stops the browser from loading.
            webBrowser1.Stop();
        }
        //This will allow for the webbrowser to navigate through the URL string
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //Reads through the URL that the user has typed out.
            textBox1.Text = webBrowser1.Url.ToString();
        }
        
        //Closes the Webbrowser Application.
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the Webbrowser application.
            this.Close();
        }
        //Opens the about Form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
