namespace WindowsFormsApplication1
{
    partial class apaWindow
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.firstAuthorLabel = new System.Windows.Forms.Label();
            this.lastAuthorLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.firstAuthorBox = new System.Windows.Forms.TextBox();
            this.lastAuthorBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.publisherBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 51);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author";
            // 
            // firstAuthorLabel
            // 
            this.firstAuthorLabel.AutoSize = true;
            this.firstAuthorLabel.Location = new System.Drawing.Point(22, 73);
            this.firstAuthorLabel.Name = "firstAuthorLabel";
            this.firstAuthorLabel.Size = new System.Drawing.Size(60, 13);
            this.firstAuthorLabel.TabIndex = 2;
            this.firstAuthorLabel.Text = "First Name:";
            // 
            // lastAuthorLabel
            // 
            this.lastAuthorLabel.AutoSize = true;
            this.lastAuthorLabel.Location = new System.Drawing.Point(22, 98);
            this.lastAuthorLabel.Name = "lastAuthorLabel";
            this.lastAuthorLabel.Size = new System.Drawing.Size(61, 13);
            this.lastAuthorLabel.TabIndex = 3;
            this.lastAuthorLabel.Text = "Last Name:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(111, 128);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 158);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(12, 128);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "State:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(12, 188);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(53, 13);
            this.publisherLabel.TabIndex = 7;
            this.publisherLabel.Text = "Publisher:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(48, 26);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(224, 20);
            this.titleBox.TabIndex = 0;
            // 
            // firstAuthorBox
            // 
            this.firstAuthorBox.Location = new System.Drawing.Point(88, 70);
            this.firstAuthorBox.Name = "firstAuthorBox";
            this.firstAuthorBox.Size = new System.Drawing.Size(184, 20);
            this.firstAuthorBox.TabIndex = 1;
            // 
            // lastAuthorBox
            // 
            this.lastAuthorBox.Location = new System.Drawing.Point(88, 95);
            this.lastAuthorBox.Name = "lastAuthorBox";
            this.lastAuthorBox.Size = new System.Drawing.Size(184, 20);
            this.lastAuthorBox.TabIndex = 2;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(149, 125);
            this.yearBox.MaxLength = 4;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(42, 20);
            this.yearBox.TabIndex = 4;
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(48, 125);
            this.stateBox.MaxLength = 2;
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(42, 20);
            this.stateBox.TabIndex = 3;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(48, 155);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 5;
            // 
            // publisherBox
            // 
            this.publisherBox.Location = new System.Drawing.Point(71, 185);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(201, 20);
            this.publisherBox.TabIndex = 6;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(15, 236);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(42, 13);
            this.outputLabel.TabIndex = 15;
            this.outputLabel.Text = "Output:";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(25, 252);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(247, 42);
            this.outputBox.TabIndex = 10;
            this.outputBox.Text = "";
			this.outputBox.Font = new System.Drawing.Font ("Consolas", 8);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(197, 300);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(71, 211);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(201, 20);
            this.urlBox.TabIndex = 7;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 214);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(32, 13);
            this.urlLabel.TabIndex = 19;
            this.urlLabel.Text = "URL:";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(25, 300);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 9;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // apaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.publisherBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.lastAuthorBox);
            this.Controls.Add(this.firstAuthorBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.lastAuthorLabel);
            this.Controls.Add(this.firstAuthorLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "apaWindow";
            this.Text = "CitationTool 1.0";
            this.Load += new System.EventHandler(this.apaWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label firstAuthorLabel;
        private System.Windows.Forms.Label lastAuthorLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox firstAuthorBox;
        private System.Windows.Forms.TextBox lastAuthorBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox publisherBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button copyButton;


    }
}