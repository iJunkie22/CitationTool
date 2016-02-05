namespace WindowsFormsApplication1
{
    partial class mlaWindow
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtInUrl = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rtfOutGenerated = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInPublisher = new System.Windows.Forms.TextBox();
            this.txtInCity = new System.Windows.Forms.TextBox();
            this.txtInState = new System.Windows.Forms.TextBox();
            this.txtInYear = new System.Windows.Forms.TextBox();
            this.txtInAuthorLN = new System.Windows.Forms.TextBox();
            this.txtInAuthorFN = new System.Windows.Forms.TextBox();
            this.txtInTitle = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAuthorLN = new System.Windows.Forms.Label();
            this.lblAuthorFN = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(25, 300);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 37;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 214);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 40;
            this.lblUrl.Text = "URL:";
            // 
            // txtInUrl
            // 
            this.txtInUrl.Location = new System.Drawing.Point(71, 211);
            this.txtInUrl.Name = "txtInUrl";
            this.txtInUrl.Size = new System.Drawing.Size(201, 20);
            this.txtInUrl.TabIndex = 34;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(197, 300);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 36;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rtfOutGenerated
            // 
            this.rtfOutGenerated.Location = new System.Drawing.Point(25, 252);
            this.rtfOutGenerated.Name = "rtfOutGenerated";
            this.rtfOutGenerated.Size = new System.Drawing.Size(247, 42);
            this.rtfOutGenerated.TabIndex = 38;
            this.rtfOutGenerated.Text = "";
			this.rtfOutGenerated.Font = new System.Drawing.Font ("Consolas", 8);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(15, 236);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 39;
            this.lblOutput.Text = "Output:";
            // 
            // txtInPublisher
            // 
            this.txtInPublisher.Location = new System.Drawing.Point(71, 185);
            this.txtInPublisher.Name = "txtInPublisher";
            this.txtInPublisher.Size = new System.Drawing.Size(201, 20);
            this.txtInPublisher.TabIndex = 32;
            // 
            // txtInCity
            // 
            this.txtInCity.Location = new System.Drawing.Point(48, 155);
            this.txtInCity.Name = "txtInCity";
            this.txtInCity.Size = new System.Drawing.Size(100, 20);
            this.txtInCity.TabIndex = 30;
            // 
            // txtInState
            // 
            this.txtInState.Location = new System.Drawing.Point(48, 125);
            this.txtInState.MaxLength = 2;
            this.txtInState.Name = "txtInState";
            this.txtInState.Size = new System.Drawing.Size(42, 20);
            this.txtInState.TabIndex = 26;
            // 
            // txtInYear
            // 
            this.txtInYear.Location = new System.Drawing.Point(149, 125);
            this.txtInYear.MaxLength = 4;
            this.txtInYear.Name = "txtInYear";
            this.txtInYear.Size = new System.Drawing.Size(42, 20);
            this.txtInYear.TabIndex = 28;
            // 
            // txtInAuthorLN
            // 
            this.txtInAuthorLN.Location = new System.Drawing.Point(88, 95);
            this.txtInAuthorLN.Name = "txtInAuthorLN";
            this.txtInAuthorLN.Size = new System.Drawing.Size(184, 20);
            this.txtInAuthorLN.TabIndex = 25;
            // 
            // txtInAuthorFN
            // 
            this.txtInAuthorFN.Location = new System.Drawing.Point(88, 70);
            this.txtInAuthorFN.Name = "txtInAuthorFN";
            this.txtInAuthorFN.Size = new System.Drawing.Size(184, 20);
            this.txtInAuthorFN.TabIndex = 22;
            // 
            // txtInTitle
            // 
            this.txtInTitle.Location = new System.Drawing.Point(48, 26);
            this.txtInTitle.Name = "txtInTitle";
            this.txtInTitle.Size = new System.Drawing.Size(224, 20);
            this.txtInTitle.TabIndex = 21;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(12, 188);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblPublisher.TabIndex = 35;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(12, 128);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 33;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 158);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 31;
            this.lblCity.Text = "City:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(111, 128);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 29;
            this.lblYear.Text = "Year:";
            // 
            // lblAuthorLN
            // 
            this.lblAuthorLN.AutoSize = true;
            this.lblAuthorLN.Location = new System.Drawing.Point(22, 98);
            this.lblAuthorLN.Name = "lblAuthorLN";
            this.lblAuthorLN.Size = new System.Drawing.Size(61, 13);
            this.lblAuthorLN.TabIndex = 27;
            this.lblAuthorLN.Text = "Last Name:";
            // 
            // lblAuthorFN
            // 
            this.lblAuthorFN.AutoSize = true;
            this.lblAuthorFN.Location = new System.Drawing.Point(22, 73);
            this.lblAuthorFN.Name = "lblAuthorFN";
            this.lblAuthorFN.Size = new System.Drawing.Size(60, 13);
            this.lblAuthorFN.TabIndex = 24;
            this.lblAuthorFN.Text = "First Name:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 51);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 23;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Title:";
            // 
            // mlaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtInUrl);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.rtfOutGenerated);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInPublisher);
            this.Controls.Add(this.txtInCity);
            this.Controls.Add(this.txtInState);
            this.Controls.Add(this.txtInYear);
            this.Controls.Add(this.txtInAuthorLN);
            this.Controls.Add(this.txtInAuthorFN);
            this.Controls.Add(this.txtInTitle);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblAuthorLN);
            this.Controls.Add(this.lblAuthorFN);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Name = "mlaWindow";
            this.Text = "CitationTool 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtInUrl;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox rtfOutGenerated;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInPublisher;
        private System.Windows.Forms.TextBox txtInCity;
        private System.Windows.Forms.TextBox txtInState;
        private System.Windows.Forms.TextBox txtInYear;
        private System.Windows.Forms.TextBox txtInAuthorLN;
        private System.Windows.Forms.TextBox txtInAuthorFN;
        private System.Windows.Forms.TextBox txtInTitle;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAuthorLN;
        private System.Windows.Forms.Label lblAuthorFN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
    }
}