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
    public partial class citationStyleWindow : Form
    {
        bool allowed, allowed2;
        public citationStyleWindow()
        {
            InitializeComponent();
            allowed = false;
            allowed2 = false;
        }

        private void styleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            allowed = true;
        }

        private void mediaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            allowed2 = true;
        }

        private void citationStyleButton_Click(object sender, EventArgs e)
        {
            if (allowed&&allowed2) { 
                // APA
                this.Hide();
                if (styleBox.SelectedIndex == 0)
                {
                    apaWindow apa = new apaWindow();
                    apa.setMedium(mediaBox.SelectedIndex);
                    apa.ShowDialog();
                }
                else if (styleBox.SelectedIndex == 1)
                {
                    mlaWindow mla = new mlaWindow();
                    mla.ShowDialog();
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Choose Citation Style and Medium.");
            }
        }
    }
}
