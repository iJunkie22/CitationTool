namespace WindowsFormsApplication1
{
    partial class citeFormWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
		protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAuthorFN = new System.Windows.Forms.Label();
            this.lblAuthorLN = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtInTitle = new System.Windows.Forms.TextBox();
            this.txtInAuthorFN = new System.Windows.Forms.TextBox();
            this.txtInAuthorLN = new System.Windows.Forms.TextBox();
            this.txtInYear = new System.Windows.Forms.TextBox();
            this.txtInState = new System.Windows.Forms.TextBox();
            this.txtInCity = new System.Windows.Forms.TextBox();
            this.txtInPublisher = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.rtfOutGenerated = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtInUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 51);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // lblAuthorFN
            // 
            this.lblAuthorFN.AutoSize = true;
            this.lblAuthorFN.Location = new System.Drawing.Point(22, 73);
            this.lblAuthorFN.Name = "lblAuthorFN";
            this.lblAuthorFN.Size = new System.Drawing.Size(60, 13);
            this.lblAuthorFN.TabIndex = 2;
            this.lblAuthorFN.Text = "First Name:";
            // 
            // lblAuthorLN
            // 
            this.lblAuthorLN.AutoSize = true;
            this.lblAuthorLN.Location = new System.Drawing.Point(22, 98);
            this.lblAuthorLN.Name = "lblAuthorLN";
            this.lblAuthorLN.Size = new System.Drawing.Size(61, 13);
            this.lblAuthorLN.TabIndex = 3;
            this.lblAuthorLN.Text = "Last Name:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(111, 128);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 158);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(12, 128);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(12, 188);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Publisher:";
            // 
            // txtInTitle
            // 
            this.txtInTitle.Location = new System.Drawing.Point(48, 26);
            this.txtInTitle.Name = "txtInTitle";
            this.txtInTitle.Size = new System.Drawing.Size(224, 20);
            this.txtInTitle.TabIndex = 0;
            // 
            // txtInAuthorFN
            // 
            this.txtInAuthorFN.Location = new System.Drawing.Point(88, 70);
            this.txtInAuthorFN.Name = "txtInAuthorFN";
            this.txtInAuthorFN.Size = new System.Drawing.Size(184, 20);
            this.txtInAuthorFN.TabIndex = 1;
            // 
            // txtInAuthorLN
            // 
            this.txtInAuthorLN.Location = new System.Drawing.Point(88, 95);
            this.txtInAuthorLN.Name = "txtInAuthorLN";
            this.txtInAuthorLN.Size = new System.Drawing.Size(184, 20);
            this.txtInAuthorLN.TabIndex = 2;
            // 
            // txtInYear
            // 
            this.txtInYear.Location = new System.Drawing.Point(149, 125);
            this.txtInYear.MaxLength = 4;
            this.txtInYear.Name = "txtInYear";
            this.txtInYear.Size = new System.Drawing.Size(42, 20);
            this.txtInYear.TabIndex = 4;
            // 
            // txtInState
            // 
            this.txtInState.Location = new System.Drawing.Point(48, 125);
            this.txtInState.MaxLength = 2;
            this.txtInState.Name = "txtInState";
            this.txtInState.Size = new System.Drawing.Size(42, 20);
            this.txtInState.TabIndex = 3;
            // 
            // txtInCity
            // 
            this.txtInCity.Location = new System.Drawing.Point(48, 155);
            this.txtInCity.Name = "txtInCity";
            this.txtInCity.Size = new System.Drawing.Size(100, 20);
            this.txtInCity.TabIndex = 5;
            // 
            // txtInPublisher
            // 
            this.txtInPublisher.Location = new System.Drawing.Point(71, 185);
            this.txtInPublisher.Name = "txtInPublisher";
            this.txtInPublisher.Size = new System.Drawing.Size(201, 20);
            this.txtInPublisher.TabIndex = 6;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(15, 236);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 15;
            this.lblOutput.Text = "Output:";
            // 
            // rtfOutGenerated
            // 
            this.rtfOutGenerated.Location = new System.Drawing.Point(25, 252);
            this.rtfOutGenerated.Name = "rtfOutGenerated";
            this.rtfOutGenerated.Size = new System.Drawing.Size(247, 42);
            this.rtfOutGenerated.TabIndex = 10;
            this.rtfOutGenerated.Text = "";
			this.rtfOutGenerated.Font = new System.Drawing.Font ("Consolas", 8);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(197, 300);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtInUrl
            // 
            this.txtInUrl.Location = new System.Drawing.Point(71, 211);
            this.txtInUrl.Name = "txtInUrl";
            this.txtInUrl.Size = new System.Drawing.Size(201, 20);
            this.txtInUrl.TabIndex = 7;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 214);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 19;
            this.lblUrl.Text = "URL:";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(25, 300);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // apaWindow
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
            this.Name = "citeFormWindow";
            this.Text = "CitationTool 1.0";
            this.Load += new System.EventHandler(this.onSelfWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblTitle;
		protected System.Windows.Forms.Label lblAuthor;
		protected System.Windows.Forms.Label lblAuthorFN;
		protected System.Windows.Forms.Label lblAuthorLN;
		protected System.Windows.Forms.Label lblYear;
		protected System.Windows.Forms.Label lblCity;
		protected System.Windows.Forms.Label lblState;
		protected System.Windows.Forms.Label lblPublisher;
		protected System.Windows.Forms.TextBox txtInTitle;
		protected System.Windows.Forms.TextBox txtInAuthorFN;
		protected System.Windows.Forms.TextBox txtInAuthorLN;
		protected System.Windows.Forms.TextBox txtInYear;
		protected System.Windows.Forms.TextBox txtInState;
		protected System.Windows.Forms.TextBox txtInCity;
		protected System.Windows.Forms.TextBox txtInPublisher;
		protected System.Windows.Forms.Label lblOutput;
		protected System.Windows.Forms.RichTextBox rtfOutGenerated;
		protected System.Windows.Forms.Button btnGenerate;
		protected System.Windows.Forms.TextBox txtInUrl;
		protected System.Windows.Forms.Label lblUrl;
		protected System.Windows.Forms.Button btnCopy;


    }
}