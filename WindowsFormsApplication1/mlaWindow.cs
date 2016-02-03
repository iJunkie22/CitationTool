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
			if (medium == (int)Mediums.Book)
            {
                urlBox.Enabled = false;
                stateBox.Enabled = false;
            }
			else if (medium == (int)Mediums.eBook)
            {
                stateBox.Enabled = false;
                urlBox.Enabled = false;
            }
        }

		protected override void generateButton_Click(object sender, EventArgs e)
        {
			outputBox.ReadOnly = false;
			titleBox.Text = FieldOps.CapLetter (titleBox.Text, 0);
			cityBox.Text = FieldOps.CapLetter (FieldOps.GetFieldText (cityBox, "Unknown City"), 0);
			firstAuthorBox.Text = FieldOps.CapLetter (firstAuthorBox.Text, 0);
			lastAuthorBox.Text = FieldOps.CapLetter (FieldOps.GetFieldText (lastAuthorBox, "Unknown"), 0);
			publisherBox.Text = FieldOps.CapLetter (FieldOps.GetFieldText (publisherBox, "Unknown Pubisher"), 0);
			stateBox.Text = FieldOps.GetFieldText (stateBox, "Unknown State").ToUpper ();

			if (yearBox.Text.Length == 0) {
				MessageBox.Show("Year number cannot be blank.");
				outputBox.Text = "Invalid Fields";
				outputBox.ReadOnly = true;
				return; // Stop progression
			}

			if (titleBox.Text.Length == 0) {
				MessageBox.Show("Title cannot be blank.");
				outputBox.Text = "Invalid Fields";
				outputBox.ReadOnly = true;
				return; // Stop progression
			}
			/*

			if (!capitalizeFirstLetter ()) {
				outputBox.Text = "Invalid Fields";
				outputBox.ReadOnly = true;
				return; // Stop progrlastession
			};
			*/

			outputBox.Text = lastAuthorBox.Text;
			if (firstAuthorBox.Text.Length > 0) {
				outputBox.AppendText (", "); // only add comma if fname is defined
			}
            // Capitalize first letter of each name
            try
            {
                string[] firstNames = firstAuthorBox.Text.Split();
                for (int i = 0; i < firstNames.Length; i++)
                {
					outputBox.AppendText(FieldOps.CapLetter(firstNames[i], 0));
                    if (i != firstNames.Length - 1)
                    {
                        outputBox.AppendText(" ");
                    }
                }   
            }
            catch
            {
                MessageBox.Show("Author Names cannot be blank.");
				outputBox.Text = "Invalid Fields";
				outputBox.ReadOnly = true;
				return; // Stop progression
            }

            outputBox.AppendText(". ");
			FieldOps.AppendAsItalic (outputBox, titleBox.Text);
            outputBox.AppendText(". " + cityBox.Text + ": " + publisherBox.Text + ", " + yearBox.Text);

			if (medium == (int)Mediums.Book)
            {
                outputBox.AppendText(". Print.");
            }
			else if (medium == (int)Mediums.eBook)
            {
                outputBox.AppendText(". Digital File.");
            }
        }
			
    }
}
