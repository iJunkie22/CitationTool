using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
	public enum Mediums {Undefined=-1, Book=0, eBook=1, Wiki=2};

	static class styles 
	{
		static public void SetDarkBG (Form form1) {
			form1.BackColor = Color.DimGray;
		}

		static public void FlattenButton(Button b1) {
			b1.FlatStyle = FlatStyle.Flat;
		}
	}

	static class mac_stuff
	{
		static public readonly bool isMac;

		static mac_stuff(){
			PlatformID my_plat = Environment.OSVersion.Platform;
			isMac = my_plat.Equals(PlatformID.MacOSX) || my_plat.Equals(PlatformID.Unix);
		}

		// This excerpt is from http://stackoverflow.com/a/33563898

		public class MacClipboard
		{
			/// <summary>
			/// Copy on MAC OS X using pbcopy commandline
			/// </summary>
			/// <param name="textToCopy"></param>
			public static void Copy(string textToCopy)
			{
				try
				{
					using (var p = new Process())
					{

						p.StartInfo = new ProcessStartInfo("pbcopy", "-pboard general -Prefer rtf"); // changed txt to rtf
						p.StartInfo.UseShellExecute = false;
						p.StartInfo.RedirectStandardOutput = false;
						p.StartInfo.RedirectStandardInput = true;
						p.Start();
						p.StandardInput.Write(textToCopy);
						p.StandardInput.Close();
						p.WaitForExit();
					}
				}
				catch (Exception ex)
				{
					Trace.WriteLine(ex.Message);
				}


			}

			/// <summary>
			/// Paste on MAC OS X using pbpaste commandline
			/// </summary>
			/// <returns></returns>
			public static string Paste()
			{
				try
				{
					string pasteText;
					using (var p = new Process())
					{

						p.StartInfo = new ProcessStartInfo("pbpaste", "-pboard general");
						p.StartInfo.UseShellExecute = false;
						p.StartInfo.RedirectStandardOutput = true;
						p.Start();
						pasteText = p.StandardOutput.ReadToEnd();
						p.WaitForExit();
					}

					return pasteText;
				}
				catch (Exception ex)
				{
					Trace.WriteLine(ex.Message);
					return null;
				}

			}
		}

		// End excerpt from http://stackoverflow.com/a/33563898


	}

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
			Font old_font = rtb.SelectionFont;
			rtb.Select (i_start, i_stop); // select the target text
			rtb.SelectionFont = new Font (rtb.Font, FontStyle.Italic); // italicize selected text
			rtb.DeselectAll();
			rtb.AppendText (""); // Resets Selection* to capture AppendText's settings
			rtb.SelectionFont = old_font;
			rtb.Invalidate (); // force the box to be re-drawn
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

		static public string[] GetInitials(string name_str)
		{
			string[] results = {""};
			if (name_str.Length == 0) {
				return results; // return an empty string for an empty string
			} 
			else {
				string[] names = name_str.Split ();
				for (int i = 0; i < name_str.Length; i++) {
					results [i] = names [i].Substring (0, 1).ToUpper();
				}

				return results;
			}
		}

		static public void CopyRTBtoClipboard(RichTextBox rtb_to_copy)
		{
			if (mac_stuff.isMac) {
				// Send to OSX clipboard
				mac_stuff.MacClipboard.Copy (rtb_to_copy.Rtf);

			} else {
				// Send to Windows clipboard
				DataObject m_data = new DataObject ();

				m_data.SetData (DataFormats.Rtf, true, rtb_to_copy.Rtf);
				m_data.SetData (DataFormats.Text, true, rtb_to_copy.Text);
				Clipboard.SetDataObject (m_data, true);
				if (mac_stuff.isMac) {
					mac_stuff.MacClipboard.Copy (rtb_to_copy.Rtf);

				}
				MessageBox.Show ("Copied to Clipboard!");
			}
		}



	}
}

