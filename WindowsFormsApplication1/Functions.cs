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
	static class fieldops
	{
		static public string CapLetter(string lc_str, int cap_pos)
		{
			string s1, s2, s3;
			int lc_len = lc_str.Length;

			if (lc_len == 0) {
				return ""; // return an empty string for an empty string
			} 
			else { // the string isnt empty
				s1 = lc_str.Substring (0, cap_pos);
				s2 = lc_str.Substring (cap_pos, 1).ToUpper();

				if (cap_pos + 1 < lc_len) {
					s3 = lc_str.Substring (cap_pos + 1, lc_len - (cap_pos + 1));
				} 
				else {
					s3 = "";
				}

				return s1 + s2 + s3;
			}
				
		}

		static public bool ItalicizeTextRange(RichTextBox rtb, int i_start, int i_stop)
		{
			rtb.Select (i_start, i_stop); // select the target text
			rtb.SelectionFont = new Font (rtb.Font, FontStyle.Italic); // italicize selected text
			rtb.Select (0, 0); // deselect the text
			return true; // return that it worked
		}

		static public bool AppendAsItalic(RichTextBox rtb2, string i_str)
		{
			int i_str_len = i_str.Length; // Insertion length
			int pre_len = rtb2.Text.Length; // Insertion start position
			rtb2.AppendText (i_str);
			return ItalicizeTextRange (rtb2, pre_len, i_str_len); // return whether it worked
		}

		static public string GetFieldText(TextBox tb_in, string default_text)
		{
			if (tb_in.Text.Length == 0) {
				return default_text;
			} 
			else {
				return tb_in.Text;
			}
		}
	}
}

