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
    public partial class apaWindow : Form
    {
        public int medium;      // 0 = book; 1 = ebook; 2 = wiki
        int initialsCount;
        public apaWindow()
        {
            InitializeComponent();
        }

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
            }
            outputBox.AppendText(" " + yearBox.Text + ". ");
            // Italicize title
            outputBox.AppendText(titleBox.Text);
            int titleStart = lastAuthorBox.Text.Length + 2 + 2 * initialsCount + 7;
            outputBox.Select(titleStart, titleBox.Text.Length-1);
            Console.Write(titleBox.Text.Length);
            outputBox.SelectionFont = new Font(outputBox.Font, FontStyle.Italic);
            outputBox.Select(0, 0);

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
            DataObject m_data = new DataObject();

            m_data.SetData(DataFormats.Rtf, true, outputBox.Rtf);
            m_data.SetData(DataFormats.Text, true, outputBox.Text);
            Clipboard.SetDataObject(m_data, true);
            MessageBox.Show("Copied to Clipboard!");
        }
    }
}
