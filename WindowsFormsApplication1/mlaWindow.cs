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
    public partial class mlaWindow : Form
    {
        int medium;

        public mlaWindow()
        {
            InitializeComponent();
            medium = -1;
        }

        public void setMedium(int x)
        {
            medium = x;
            if (medium == 0)
            {
                urlBox.Enabled = false;
                stateBox.Enabled = false;
            }
            else if (medium == 1)
            {
                stateBox.Enabled = false;
                urlBox.Enabled = false;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
			outputBox.ReadOnly = false;
			titleBox.Text = fieldops.CapLetter (titleBox.Text, 0);
			cityBox.Text = fieldops.CapLetter (fieldops.GetFieldText (cityBox, "Unknown City"), 0);
			firstAuthorBox.Text = fieldops.CapLetter (firstAuthorBox.Text, 0);
			lastAuthorBox.Text = fieldops.CapLetter (fieldops.GetFieldText (lastAuthorBox, "Unknown"), 0);
			publisherBox.Text = fieldops.CapLetter (fieldops.GetFieldText (publisherBox, "Unknown Pubisher"), 0);
			stateBox.Text = fieldops.GetFieldText (stateBox, "Unknown State").ToUpper ();

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
					outputBox.AppendText(fieldops.CapLetter(firstNames[i], 0));
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
			fieldops.AppendAsItalic (outputBox, titleBox.Text);
            outputBox.AppendText(". " + cityBox.Text + ": " + publisherBox.Text + ", " + yearBox.Text);
            if (medium == 0)
            {
                outputBox.AppendText(". Print.");
            }
            else if (medium == 1)
            {
                outputBox.AppendText(". Digital File.");
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            DataObject m_data = new DataObject();

            m_data.SetData(DataFormats.Rtf, true, outputBox.Rtf);
            m_data.SetData(DataFormats.Text, true, outputBox.Text);
            Clipboard.SetDataObject(m_data, true);
            MessageBox.Show("Copied to Clipboard!");
        }

        private bool capitalizeFirstLetter()
        {
            try
            {
                //Capitalize appropriate letters in each appropriate box
                titleBox.Text = titleBox.Text.Substring(0, 1).ToUpper() + titleBox.Text.Substring(1);
                cityBox.Text = cityBox.Text.Substring(0, 1).ToUpper() + cityBox.Text.Substring(1);
                firstAuthorBox.Text = firstAuthorBox.Text.Substring(0, 1).ToUpper() + firstAuthorBox.Text.Substring(1);
                lastAuthorBox.Text = lastAuthorBox.Text.Substring(0, 1).ToUpper() + lastAuthorBox.Text.Substring(1);
                publisherBox.Text = publisherBox.Text.Substring(0, 1).ToUpper() + publisherBox.Text.Substring(1);
                stateBox.Text = stateBox.Text.ToUpper();
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
            int titleStart = lastAuthorBox.Text.Length + 2 + firstAuthorBox.Text.Length + 2;
            outputBox.Select(titleStart, titleBox.Text.Length - 1);
            Console.Write(titleBox.Text.Length);
            outputBox.SelectionFont = new Font(outputBox.Font, FontStyle.Italic);
            outputBox.Select(0, 0);
        }
    }
}
