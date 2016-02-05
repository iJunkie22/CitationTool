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
    public partial class mlaWindow : citeFormWindow
    {

        public mlaWindow()
        {
			if (!has_drawn) {
				InitializeComponent ();
			}
			medium = (int)Mediums.Undefined;
        }

        public override void setMedium(int x)
        {
            medium = x;
			Console.Write ("testing mla medium");
			Console.Write (medium);
			if (medium == (int)Mediums.Book)
            {
                txtInUrl.Enabled = false;
                txtInState.Enabled = false;
            }
			else if (medium == (int)Mediums.eBook)
            {
                txtInState.Enabled = false;
                txtInUrl.Enabled = false;
            }
			Console.WriteLine (txtInState.Enabled);
        }

		protected override void btnGenerate_Click(object sender, EventArgs e)
        {
			rtfOutGenerated.ReadOnly = false;
			txtInTitle.Text = FieldOps.CapLetter (txtInTitle.Text, 0);
			txtInCity.Text = FieldOps.CapLetter (FieldOps.GetFieldText (txtInCity, "Unknown City"), 0);
			txtInAuthorFN.Text = FieldOps.CapLetter (txtInAuthorFN.Text, 0);
			txtInAuthorLN.Text = FieldOps.CapLetter (FieldOps.GetFieldText (txtInAuthorLN, "Unknown"), 0);
			txtInPublisher.Text = FieldOps.CapLetter (FieldOps.GetFieldText (txtInPublisher, "Unknown Pubisher"), 0);
			txtInState.Text = FieldOps.GetFieldText (txtInState, "Unknown State").ToUpper ();

			if (txtInYear.Text.Length == 0) {
				MessageBox.Show("Year number cannot be blank.");
				rtfOutGenerated.Text = "Invalid Fields";
				rtfOutGenerated.ReadOnly = true;
				return; // Stop progression
			}

			if (txtInTitle.Text.Length == 0) {
				MessageBox.Show("Title cannot be blank.");
				rtfOutGenerated.Text = "Invalid Fields";
				rtfOutGenerated.ReadOnly = true;
				return; // Stop progression
			}
			/*

			if (!capitalizeFirstLetter ()) {
				rtfOutGenerated.Text = "Invalid Fields";
				rtfOutGenerated.ReadOnly = true;
				return; // Stop progrlastession
			};
			*/

			rtfOutGenerated.Text = txtInAuthorLN.Text;
			if (txtInAuthorFN.Text.Length > 0) {
				rtfOutGenerated.AppendText (", "); // only add comma if fname is defined
			}
            // Capitalize first letter of each name
            try
            {
                string[] firstNames = txtInAuthorFN.Text.Split();
                for (int i = 0; i < firstNames.Length; i++)
                {
					rtfOutGenerated.AppendText(FieldOps.CapLetter(firstNames[i], 0));
                    if (i != firstNames.Length - 1)
                    {
                        rtfOutGenerated.AppendText(" ");
                    }
                }   
            }
            catch
            {
                MessageBox.Show("Author Names cannot be blank.");
				rtfOutGenerated.Text = "Invalid Fields";
				rtfOutGenerated.ReadOnly = true;
				return; // Stop progression
            }

            rtfOutGenerated.AppendText(". ");
			FieldOps.AppendAsItalic (rtfOutGenerated, txtInTitle.Text);
            rtfOutGenerated.AppendText(". " + txtInCity.Text + ": " + txtInPublisher.Text + ", " + txtInYear.Text);

			if (medium == (int)Mediums.Book)
            {
                rtfOutGenerated.AppendText(". Print.");
            }
			else if (medium == (int)Mediums.eBook)
            {
                rtfOutGenerated.AppendText(". Digital File.");
            }
        }
			
    }
}
