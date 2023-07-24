namespace BetterNotepad
{
    partial class NewNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNoteForm));
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.SaveNoteButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TagsLabel = new System.Windows.Forms.Label();
            this.TagsTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TitleTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneContextMenuStrip1 = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.BackgroundPanel.Controls.Add(this.SaveNoteButton);
            this.BackgroundPanel.Controls.Add(this.TagsLabel);
            this.BackgroundPanel.Controls.Add(this.TagsTextBox);
            this.BackgroundPanel.Controls.Add(this.TitleTextBox);
            this.BackgroundPanel.Controls.Add(this.TitleLabel);
            this.BackgroundPanel.Controls.Add(this.NoteLabel);
            this.BackgroundPanel.Controls.Add(this.NoteTextBox);
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(700, 715);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // SaveNoteButton
            // 
            this.SaveNoteButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.SaveNoteButton.BorderRadius = 20;
            this.SaveNoteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveNoteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveNoteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveNoteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveNoteButton.FillColor = System.Drawing.Color.White;
            this.SaveNoteButton.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveNoteButton.ForeColor = System.Drawing.Color.Black;
            this.SaveNoteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveNoteButton.Location = new System.Drawing.Point(497, 660);
            this.SaveNoteButton.Name = "SaveNoteButton";
            this.SaveNoteButton.Size = new System.Drawing.Size(153, 43);
            this.SaveNoteButton.TabIndex = 15;
            this.SaveNoteButton.Text = "Save";
            this.SaveNoteButton.Click += new System.EventHandler(this.SaveNoteButton_Click);
            // 
            // TagsLabel
            // 
            this.TagsLabel.AutoSize = true;
            this.TagsLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TagsLabel.ForeColor = System.Drawing.Color.White;
            this.TagsLabel.Location = new System.Drawing.Point(50, 76);
            this.TagsLabel.Name = "TagsLabel";
            this.TagsLabel.Size = new System.Drawing.Size(62, 23);
            this.TagsLabel.TabIndex = 14;
            this.TagsLabel.Text = "Tags:";
            // 
            // TagsTextBox
            // 
            this.TagsTextBox.BorderColor = System.Drawing.Color.White;
            this.TagsTextBox.BorderRadius = 20;
            this.TagsTextBox.DefaultText = "";
            this.TagsTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TagsTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TagsTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TagsTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TagsTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TagsTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TagsTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TagsTextBox.ForeColor = System.Drawing.Color.White;
            this.TagsTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TagsTextBox.Location = new System.Drawing.Point(112, 69);
            this.TagsTextBox.Name = "TagsTextBox";
            this.TagsTextBox.PasswordChar = '\0';
            this.TagsTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TagsTextBox.PlaceholderText = "Input note tags here. You will be able to find a note by them.";
            this.TagsTextBox.SelectedText = "";
            this.TagsTextBox.Size = new System.Drawing.Size(538, 40);
            this.TagsTextBox.TabIndex = 13;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderColor = System.Drawing.Color.White;
            this.TitleTextBox.BorderRadius = 20;
            this.TitleTextBox.DefaultText = "";
            this.TitleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TitleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TitleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TitleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TitleTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TitleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TitleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleTextBox.ForeColor = System.Drawing.Color.White;
            this.TitleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TitleTextBox.Location = new System.Drawing.Point(112, 20);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.PasswordChar = '\0';
            this.TitleTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TitleTextBox.PlaceholderText = "Input note title here.";
            this.TitleTextBox.SelectedText = "";
            this.TitleTextBox.Size = new System.Drawing.Size(538, 40);
            this.TitleTextBox.TabIndex = 12;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(50, 27);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(61, 23);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "Title:";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoteLabel.ForeColor = System.Drawing.Color.White;
            this.NoteLabel.Location = new System.Drawing.Point(50, 120);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(63, 23);
            this.NoteLabel.TabIndex = 10;
            this.NoteLabel.Text = "Note:";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.AutoScroll = true;
            this.NoteTextBox.BorderColor = System.Drawing.Color.White;
            this.NoteTextBox.BorderRadius = 20;
            this.NoteTextBox.DefaultText = "";
            this.NoteTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NoteTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NoteTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NoteTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NoteTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.NoteTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NoteTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoteTextBox.ForeColor = System.Drawing.Color.White;
            this.NoteTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NoteTextBox.Location = new System.Drawing.Point(50, 150);
            this.NoteTextBox.MaxLength = 1000000;
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.PasswordChar = '\0';
            this.NoteTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.NoteTextBox.PlaceholderText = "Input your note here.";
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NoteTextBox.SelectedText = "";
            this.NoteTextBox.Size = new System.Drawing.Size(600, 500);
            this.NoteTextBox.TabIndex = 0;
            this.NoteTextBox.WordWrap = false;
            // 
            // siticoneContextMenuStrip1
            // 
            this.siticoneContextMenuStrip1.Name = "siticoneContextMenuStrip1";
            this.siticoneContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip1.RenderStyle.ColorTable = null;
            this.siticoneContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.siticoneContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NewNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 711);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewNote";
            this.Load += new System.EventHandler(this.NewNoteForm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel BackgroundPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip siticoneContextMenuStrip1;
        private Label NoteLabel;
        private Label TitleLabel;
        private Label TagsLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SaveNoteButton;
        public Siticone.Desktop.UI.WinForms.SiticoneTextBox TitleTextBox;
        public Siticone.Desktop.UI.WinForms.SiticoneTextBox TagsTextBox;
        public Siticone.Desktop.UI.WinForms.SiticoneTextBox NoteTextBox;
    }
}