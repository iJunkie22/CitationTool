﻿using System;
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
                urlBox.Enabled = false;
            }
			else if(medium == (int)Mediums.eBook)
            {
                cityBox.Enabled = false;
                stateBox.Enabled = false;
                publisherBox.Enabled = false;
            }
        }

		protected override void generateButton_Click(object sender, EventArgs e)
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

        private void onSelfWindow_Load(object sender, EventArgs e)
        {

        }
			
    }
}
