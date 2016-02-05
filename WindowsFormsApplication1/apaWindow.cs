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
    public class apaWindow : citeFormWindow
    {
        /// <summary>
        /// The medium.
        /// </summary>
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsFormsApplication1.apaWindow"/> class.
        /// </summary>
        public apaWindow()
        {
			if (!has_drawn) {
				InitializeComponent ();
			}
			medium = (int)Mediums.Undefined;
        }

        /// <summary>
        /// Sets the medium.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        public override void setMedium(int x)
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

		protected override void btnGenerate_Click(object sender, EventArgs e)
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

        protected override void onSelfWindow_Load(object sender, EventArgs e)
        {

        }
			
    }
}
