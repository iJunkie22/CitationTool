namespace WindowsFormsApplication1
{
    partial class citationStyleWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.styleLabel = new System.Windows.Forms.Label();
            this.citationStyleButton = new System.Windows.Forms.Button();
            this.mediaLabel = new System.Windows.Forms.Label();
            this.mediaBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "APA: American Psychological Association",
            "MLA: Modern Language Association"});
            this.styleBox.Location = new System.Drawing.Point(87, 21);
            this.styleBox.Name = "styleBox";
            //this.styleBox.Size = new System.Drawing.Size(173, 21);
			this.styleBox.Size = new System.Drawing.Size(233, 21);
            this.styleBox.TabIndex = 0;
            this.styleBox.SelectedIndexChanged += new System.EventHandler(this.styleBox_SelectedIndexChanged);
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Location = new System.Drawing.Point(10, 24);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(71, 13);
            this.styleLabel.TabIndex = 1;
            this.styleLabel.Text = "Citation Style:";
            // 
            // citationStyleButton
            // 
            this.citationStyleButton.Location = new System.Drawing.Point(197, 81);
            this.citationStyleButton.Name = "citationStyleButton";
            this.citationStyleButton.Size = new System.Drawing.Size(75, 23);
            this.citationStyleButton.TabIndex = 2;
            this.citationStyleButton.Text = "Next";
            this.citationStyleButton.UseVisualStyleBackColor = true;
            this.citationStyleButton.Click += new System.EventHandler(this.citationStyleButton_Click);
            // 
            // mediaLabel
            // 
            this.mediaLabel.AutoSize = true;
            this.mediaLabel.Location = new System.Drawing.Point(10, 51);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(39, 13);
            this.mediaLabel.TabIndex = 4;
            this.mediaLabel.Text = "Media:";
            // 
            // mediaBox
            // 
            this.mediaBox.FormattingEnabled = true;
            this.mediaBox.Items.AddRange(new object[] {
            "Book (Print)",
            "eBook"});
            this.mediaBox.Location = new System.Drawing.Point(87, 48);
            this.mediaBox.Name = "mediaBox";
            //this.mediaBox.Size = new System.Drawing.Size(173, 21);
			this.mediaBox.Size = new System.Drawing.Size(233, 21);
            this.mediaBox.TabIndex = 3;
            this.mediaBox.SelectedIndexChanged += new System.EventHandler(this.mediaBox_SelectedIndexChanged);
            // 
            // citationStyleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(284, 116);
			this.ClientSize = new System.Drawing.Size(344, 116);
            this.Controls.Add(this.mediaLabel);
            this.Controls.Add(this.mediaBox);
            this.Controls.Add(this.citationStyleButton);
            this.Controls.Add(this.styleLabel);
            this.Controls.Add(this.styleBox);
            this.Name = "citationStyleWindow";
            this.Text = "CitationTool 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.Button citationStyleButton;
        private System.Windows.Forms.Label mediaLabel;
        private System.Windows.Forms.ComboBox mediaBox;
    }
}

