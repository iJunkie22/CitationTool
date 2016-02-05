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
                txtInUrl.Enabled = false;
            }
			else if(medium == (int)Mediums.eBook)
            {
                txtInCity.Enabled = false;
                txtInState.Enabled = false;
                txtInPublisher.Enabled = false;
            }
        }

		protected virtual void btnGenerate_Click(object sender, EventArgs e)
        {
			rtfOutGenerated.ReadOnly = false;
			if (!capitalizeFirstLetter ()) {
				rtfOutGenerated.Text = "Invalid Fields";
				rtfOutGenerated.ReadOnly = true;
				return; // Stop progression
			};
            rtfOutGenerated.Text = txtInAuthorLN.Text + ", " ;
            // Get Initials
            try {
                string[] firstNames = txtInAuthorFN.Text.Split();
                initialsCount = firstNames.Length;
                for(int i=0; i<firstNames.Length; i++)
                {
                    rtfOutGenerated.AppendText(firstNames[i].Substring(0, 1).ToUpper() + ".");
                }
            }
            catch {
                MessageBox.Show("Author Names cannot be blank.");
				rtfOutGenerated.Text = "Invalid Fields";
				rtfOutGenerated.ReadOnly = true;
				return; // Stop progression
            }
            
            rtfOutGenerated.AppendText(" " + txtInYear.Text + ". ");
			FieldOps.AppendAsItalic (rtfOutGenerated, txtInTitle.Text);

            //If Book
			if (medium == (int)Mediums.Book)
            {
                rtfOutGenerated.AppendText(". " + txtInCity.Text + ", " + txtInState.Text.ToUpper() + ": " + txtInPublisher.Text + ".");
            }
            //If ebook
			else if (medium== (int)Mediums.eBook)
            {
                rtfOutGenerated.AppendText(" [E-Reader Version]. Retrieved from " + txtInUrl.Text);
            }
        }

        protected virtual void onSelfWindow_Load(object sender, EventArgs e)
        {

        }

        protected void btnCopy_Click(object sender, EventArgs e)
        {
			FieldOps.CopyRTBtoClipboard (rtfOutGenerated);
            MessageBox.Show("Copied to Clipboard!");

        }

        protected bool capitalizeFirstLetter()
        {
			try 
			{
            	//Capitalize first letter of each appropriate box
            	txtInTitle.Text = txtInTitle.Text.Substring(0, 1).ToUpper() + txtInTitle.Text.Substring(1);
            	txtInCity.Text = txtInCity.Text.Substring(0, 1).ToUpper() + txtInCity.Text.Substring(1);
            	txtInAuthorLN.Text = txtInAuthorLN.Text.Substring(0, 1).ToUpper() + txtInAuthorLN.Text.Substring(1);
            	txtInPublisher.Text = txtInPublisher.Text.Substring(0, 1).ToUpper() + txtInPublisher.Text.Substring(1);
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
