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
    public partial class citeFormWindow : Form
    {
        /// <summary>
        /// The medium.
        /// </summary>
        public int medium;      // 0 = book; 1 = ebook; 2 = wiki
        protected int initialsCount;
		protected bool has_drawn = false;
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsFormsApplication1.apaWindow"/> class.
        /// </summary>
        public citeFormWindow()
        {
            InitializeComponent();
			has_drawn = true;
			medium = (int)Mediums.Undefined;
			Console.WriteLine ("Initializing citeFormWindow");
        }

        /// <summary>
        /// Sets the medium.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        public virtual void setMedium(int x)
        {
            medium = x;
			if (medium == (int)Mediums.Book)
            {
                urlBox.Enabled = false;
            }
			else if(medium == (int)Mediums.eBook)
            {
                cityBox.Enabled = false;
                stateBox.Enabled = false;
                publisherBox.Enabled = false;
            }
        }

		protected virtual void generateButton_Click(object sender, EventArgs e)
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
			FieldOps.AppendAsItalic (outputBox, titleBox.Text);

            //If Book
			if (medium == (int)Mediums.Book)
            {
                outputBox.AppendText(". " + cityBox.Text + ", " + stateBox.Text.ToUpper() + ": " + publisherBox.Text + ".");
            }
            //If ebook
			else if (medium== (int)Mediums.eBook)
            {
                outputBox.AppendText(" [E-Reader Version]. Retrieved from " + urlBox.Text);
            }
        }

        protected virtual void onSelfWindow_Load(object sender, EventArgs e)
        {

        }

        protected void copyButton_Click(object sender, EventArgs e)
        {
			FieldOps.CopyRTBtoClipboard (outputBox);
            MessageBox.Show("Copied to Clipboard!");

        }

        protected bool capitalizeFirstLetter()
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
			
    }
}
