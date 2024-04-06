namespace TextEditor
{
    partial class TextEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxContent = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.replaceTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.toUpperCaseButton = new System.Windows.Forms.Button();
            this.toLowerCaseButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.boldButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.alignLeftButton = new System.Windows.Forms.Button();
            this.alignCenterButton = new System.Windows.Forms.Button();
            this.alignRightButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxContent
            // 
            this.textBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContent.Location = new System.Drawing.Point(0, 28);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(1336, 585);
            this.textBoxContent.TabIndex = 0;
            this.textBoxContent.Text = "";
            this.textBoxContent.TextChanged += new System.EventHandler(this.textBoxContent_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(160, 0);
            this.searchTextbox.Multiline = true;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(100, 29);
            this.searchTextbox.TabIndex = 2;
            // 
            // replaceTextbox
            // 
            this.replaceTextbox.Location = new System.Drawing.Point(362, -1);
            this.replaceTextbox.Multiline = true;
            this.replaceTextbox.Name = "replaceTextbox";
            this.replaceTextbox.Size = new System.Drawing.Size(100, 29);
            this.replaceTextbox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(266, -1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 29);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // toUpperCaseButton
            // 
            this.toUpperCaseButton.Location = new System.Drawing.Point(571, -1);
            this.toUpperCaseButton.Name = "toUpperCaseButton";
            this.toUpperCaseButton.Size = new System.Drawing.Size(120, 29);
            this.toUpperCaseButton.TabIndex = 5;
            this.toUpperCaseButton.Text = "To Upper Case";
            this.toUpperCaseButton.UseVisualStyleBackColor = true;
            this.toUpperCaseButton.Click += new System.EventHandler(this.toUpperCaseButton_Click);
            // 
            // toLowerCaseButton
            // 
            this.toLowerCaseButton.Location = new System.Drawing.Point(709, 0);
            this.toLowerCaseButton.Name = "toLowerCaseButton";
            this.toLowerCaseButton.Size = new System.Drawing.Size(117, 29);
            this.toLowerCaseButton.TabIndex = 6;
            this.toLowerCaseButton.Text = "To Lower Case";
            this.toLowerCaseButton.UseVisualStyleBackColor = true;
            this.toLowerCaseButton.Click += new System.EventHandler(this.toLowerCaseButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(468, 0);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(97, 29);
            this.replaceButton.TabIndex = 7;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // boldButton
            // 
            this.boldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldButton.Location = new System.Drawing.Point(982, -1);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(30, 30);
            this.boldButton.TabIndex = 8;
            this.boldButton.Text = "B";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicButton.Location = new System.Drawing.Point(910, 0);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(30, 30);
            this.italicButton.TabIndex = 9;
            this.italicButton.Text = "I";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineButton.Location = new System.Drawing.Point(946, 0);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(30, 30);
            this.underlineButton.TabIndex = 10;
            this.underlineButton.Text = "U";
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // alignLeftButton
            // 
            this.alignLeftButton.Location = new System.Drawing.Point(1088, 0);
            this.alignLeftButton.Name = "alignLeftButton";
            this.alignLeftButton.Size = new System.Drawing.Size(75, 30);
            this.alignLeftButton.TabIndex = 11;
            this.alignLeftButton.Text = "A - L";
            this.alignLeftButton.Click += new System.EventHandler(this.alignLeftButton_Click);
            // 
            // alignCenterButton
            // 
            this.alignCenterButton.Location = new System.Drawing.Point(1169, 0);
            this.alignCenterButton.Name = "alignCenterButton";
            this.alignCenterButton.Size = new System.Drawing.Size(75, 29);
            this.alignCenterButton.TabIndex = 12;
            this.alignCenterButton.Text = "A - C";
            this.alignCenterButton.Click += new System.EventHandler(this.alignCenterButton_Click);
            // 
            // alignRightButton
            // 
            this.alignRightButton.Location = new System.Drawing.Point(1250, -1);
            this.alignRightButton.Name = "alignRightButton";
            this.alignRightButton.Size = new System.Drawing.Size(74, 30);
            this.alignRightButton.TabIndex = 13;
            this.alignRightButton.Text = "A - R";
            this.alignRightButton.Click += new System.EventHandler(this.alignRightButton_Click);
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 613);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.alignRightButton);
            this.Controls.Add(this.alignCenterButton);
            this.Controls.Add(this.alignLeftButton);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.toLowerCaseButton);
            this.Controls.Add(this.toUpperCaseButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.replaceTextbox);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditorForm";
            this.Text = "Text File Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RichTextBox textBoxContent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.TextBox replaceTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button toUpperCaseButton;
        private System.Windows.Forms.Button toLowerCaseButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.Button alignLeftButton;
        private System.Windows.Forms.Button alignCenterButton;
        private System.Windows.Forms.Button alignRightButton;
    }
}
