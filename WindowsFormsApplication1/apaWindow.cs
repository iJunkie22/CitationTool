using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class apaWindow : Form
    {
        /// <summary>
        /// The medium.
        /// </summary>
        public int medium;      // 0 = book; 1 = ebook; 2 = wiki
        int initialsCount;
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsFormsApplication1.apaWindow"/> class.
        /// </summary>
        public apaWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the medium.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        public void setMedium(int x)
        {
            medium = x;
            if (medium == 0)
            {
                urlBox.Enabled = false;
            }
            else if(medium == 1)
            {
                cityBox.Enabled = false;
                stateBox.Enabled = false;
                publisherBox.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
			outputBox.ReadOnly = false;
			if (!capitalizeFirstLetter ()) {
				outputBox.Text = "Invalid Fields";
				outputBox.ReadOnly = true;
				return; // Stop progression
			};
            outputBox.Text = lastAuthorBox.Text + ", " ;
            // Get Initials
            try {
                string[] firstNames = firstAuthorBox.Text.Split();
                initialsCount = firstNames.Length;
                for(int i=0; i<firstNames.Length; i++)
                {
                    outputBox.AppendText(firstNames[i].Substring(0, 1).ToUpper() + ".");
                }
            }
            catch {
                MessageBox.Show("Author Names cannot be blank.");
				outputBox.Text = "Invalid Fields";
				outputBox.ReadOnly = true;
				return; // Stop progression
            }
            
            outputBox.AppendText(" " + yearBox.Text + ". ");
			fieldops.AppendAsItalic (outputBox, titleBox.Text);

            //If Book
            if (medium == 0)
            {
                outputBox.AppendText(". " + cityBox.Text + ", " + stateBox.Text.ToUpper() + ": " + publisherBox.Text + ".");
            }
            //If ebook
            else if (medium==1)
            {
                outputBox.AppendText(" [E-Reader Version]. Retrieved from " + urlBox.Text);
            }
        }

        private void apaWindow_Load(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
			fieldops.CopyRTBtoClipboard (outputBox);
            MessageBox.Show("Copied to Clipboard!");

        }

        private bool capitalizeFirstLetter()
        {
			try 
			{
            	//Capitalize first letter of each appropriate box
            	titleBox.Text = titleBox.Text.Substring(0, 1).ToUpper() + titleBox.Text.Substring(1);
            	cityBox.Text = cityBox.Text.Substring(0, 1).ToUpper() + cityBox.Text.Substring(1);
            	lastAuthorBox.Text = lastAuthorBox.Text.Substring(0, 1).ToUpper() + lastAuthorBox.Text.Substring(1);
            	publisherBox.Text = publisherBox.Text.Substring(0, 1).ToUpper() + publisherBox.Text.Substring(1);
				return true;
			}
			catch
			{
				MessageBox.Show("Do not leave fields blank.");
				return false;
			}
        }

        private void italicizeTitle()
        {
            // Italicize title
            outputBox.AppendText(titleBox.Text);
            int titleStart = lastAuthorBox.Text.Length + 2 + 2 * initialsCount + 7;
            outputBox.Select(titleStart, titleBox.Text.Length - 1);
            Console.Write(titleBox.Text.Length);
            outputBox.SelectionFont = new Font(outputBox.Font, FontStyle.Italic);
            outputBox.Select(0, 0);
        }

		private bool checkIsEmpty(TextBox tb)
		{
			return (tb.Text == "");
		}
    }
}
