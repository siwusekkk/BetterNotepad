namespace BetterNotepad
{
    public partial class MainForm
    {

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.OpenNoteButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.NewNoteButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SearchNotesTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SearchNotesLabel = new System.Windows.Forms.Label();
            this.SunNight = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.MoonNight = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.SunDay = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.MoonDay = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.DayNightModeSwitch = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.MinimizeButton = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.CloseButton = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.AppTitle = new System.Windows.Forms.Label();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SunNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoonNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoonDay)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.BackgroundPanel.Controls.Add(this.OpenNoteButton);
            this.BackgroundPanel.Controls.Add(this.NewNoteButton);
            this.BackgroundPanel.Controls.Add(this.SearchNotesTextBox);
            this.BackgroundPanel.Controls.Add(this.SearchNotesLabel);
            this.BackgroundPanel.Controls.Add(this.SunNight);
            this.BackgroundPanel.Controls.Add(this.MoonNight);
            this.BackgroundPanel.Controls.Add(this.SunDay);
            this.BackgroundPanel.Controls.Add(this.MoonDay);
            this.BackgroundPanel.Controls.Add(this.DayNightModeSwitch);
            this.BackgroundPanel.Controls.Add(this.MinimizeButton);
            this.BackgroundPanel.Controls.Add(this.CloseButton);
            this.BackgroundPanel.Controls.Add(this.AppTitle);
            this.BackgroundPanel.Controls.Add(this.LinePanel);
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(625, 120);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // OpenNoteButton
            // 
            this.OpenNoteButton.BorderRadius = 15;
            this.OpenNoteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OpenNoteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OpenNoteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenNoteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OpenNoteButton.FillColor = System.Drawing.Color.White;
            this.OpenNoteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenNoteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.OpenNoteButton.Location = new System.Drawing.Point(425, 70);
            this.OpenNoteButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenNoteButton.Name = "OpenNoteButton";
            this.OpenNoteButton.Size = new System.Drawing.Size(71, 36);
            this.OpenNoteButton.TabIndex = 12;
            this.OpenNoteButton.Text = "Open";
            this.OpenNoteButton.Click += new System.EventHandler(this.OpenNoteButton_Click);
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.BorderRadius = 15;
            this.NewNoteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NewNoteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NewNoteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NewNoteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NewNoteButton.FillColor = System.Drawing.Color.White;
            this.NewNoteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewNoteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.NewNoteButton.Location = new System.Drawing.Point(505, 70);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(108, 36);
            this.NewNoteButton.TabIndex = 11;
            this.NewNoteButton.Text = "New Note";
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // SearchNotesTextBox
            // 
            this.SearchNotesTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchNotesTextBox.BorderColor = System.Drawing.Color.White;
            this.SearchNotesTextBox.BorderRadius = 15;
            this.SearchNotesTextBox.DefaultText = "";
            this.SearchNotesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchNotesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchNotesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchNotesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchNotesTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.SearchNotesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchNotesTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchNotesTextBox.ForeColor = System.Drawing.Color.White;
            this.SearchNotesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchNotesTextBox.Location = new System.Drawing.Point(161, 70);
            this.SearchNotesTextBox.Name = "SearchNotesTextBox";
            this.SearchNotesTextBox.PasswordChar = '\0';
            this.SearchNotesTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.SearchNotesTextBox.PlaceholderText = "Note title or note content";
            this.SearchNotesTextBox.SelectedText = "";
            this.SearchNotesTextBox.Size = new System.Drawing.Size(254, 36);
            this.SearchNotesTextBox.TabIndex = 10;
            // 
            // SearchNotesLabel
            // 
            this.SearchNotesLabel.AutoSize = true;
            this.SearchNotesLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchNotesLabel.ForeColor = System.Drawing.Color.White;
            this.SearchNotesLabel.Location = new System.Drawing.Point(12, 75);
            this.SearchNotesLabel.Name = "SearchNotesLabel";
            this.SearchNotesLabel.Size = new System.Drawing.Size(143, 23);
            this.SearchNotesLabel.TabIndex = 9;
            this.SearchNotesLabel.Text = "Search notes:";
            // 
            // SunNight
            // 
            this.SunNight.BackColor = System.Drawing.Color.Transparent;
            this.SunNight.FillColor = System.Drawing.Color.Transparent;
            this.SunNight.Image = global::BetterNotepad.Properties.Resources.SunNight;
            this.SunNight.ImageRotate = 0F;
            this.SunNight.Location = new System.Drawing.Point(470, 3);
            this.SunNight.Name = "SunNight";
            this.SunNight.Size = new System.Drawing.Size(50, 50);
            this.SunNight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SunNight.TabIndex = 8;
            this.SunNight.TabStop = false;
            // 
            // MoonNight
            // 
            this.MoonNight.BackColor = System.Drawing.Color.Transparent;
            this.MoonNight.FillColor = System.Drawing.Color.Transparent;
            this.MoonNight.Image = global::BetterNotepad.Properties.Resources.MoonNight;
            this.MoonNight.ImageRotate = 0F;
            this.MoonNight.Location = new System.Drawing.Point(358, 3);
            this.MoonNight.Name = "MoonNight";
            this.MoonNight.Size = new System.Drawing.Size(50, 50);
            this.MoonNight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoonNight.TabIndex = 7;
            this.MoonNight.TabStop = false;
            // 
            // SunDay
            // 
            this.SunDay.BackColor = System.Drawing.Color.Transparent;
            this.SunDay.FillColor = System.Drawing.Color.Transparent;
            this.SunDay.Image = global::BetterNotepad.Properties.Resources.SunDay;
            this.SunDay.ImageRotate = 0F;
            this.SunDay.Location = new System.Drawing.Point(470, 3);
            this.SunDay.Name = "SunDay";
            this.SunDay.Size = new System.Drawing.Size(50, 50);
            this.SunDay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SunDay.TabIndex = 6;
            this.SunDay.TabStop = false;
            // 
            // MoonDay
            // 
            this.MoonDay.BackColor = System.Drawing.Color.Transparent;
            this.MoonDay.FillColor = System.Drawing.Color.Transparent;
            this.MoonDay.Image = global::BetterNotepad.Properties.Resources.MoonDay1;
            this.MoonDay.ImageRotate = 0F;
            this.MoonDay.Location = new System.Drawing.Point(358, 3);
            this.MoonDay.Name = "MoonDay";
            this.MoonDay.Size = new System.Drawing.Size(50, 50);
            this.MoonDay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoonDay.TabIndex = 5;
            this.MoonDay.TabStop = false;
            // 
            // DayNightModeSwitch
            // 
            this.DayNightModeSwitch.BackColor = System.Drawing.Color.Transparent;
            this.DayNightModeSwitch.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.DayNightModeSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.DayNightModeSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.DayNightModeSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DayNightModeSwitch.Location = new System.Drawing.Point(414, 16);
            this.DayNightModeSwitch.Name = "DayNightModeSwitch";
            this.DayNightModeSwitch.Size = new System.Drawing.Size(50, 26);
            this.DayNightModeSwitch.TabIndex = 4;
            this.DayNightModeSwitch.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.DayNightModeSwitch.UncheckedState.FillColor = System.Drawing.Color.White;
            this.DayNightModeSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.DayNightModeSwitch.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.DayNightModeSwitch.CheckedChanged += new System.EventHandler(this.DayNightModeSwitch_CheckedChanged);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(526, 14);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 29);
            this.MinimizeButton.TabIndex = 3;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FillColor = System.Drawing.Color.Transparent;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(568, 14);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 29);
            this.CloseButton.TabIndex = 2;
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("Yu Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AppTitle.ForeColor = System.Drawing.Color.White;
            this.AppTitle.Location = new System.Drawing.Point(12, 14);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(219, 31);
            this.AppTitle.TabIndex = 1;
            this.AppTitle.Text = "BetterNotepad vx";
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.White;
            this.LinePanel.Location = new System.Drawing.Point(0, 55);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(1300, 1);
            this.LinePanel.TabIndex = 0;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.BackgroundPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 120);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SunNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoonNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoonDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel BackgroundPanel;
        private Label AppTitle;
        private Panel LinePanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox MinimizeButton;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox CloseButton;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch DayNightModeSwitch;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox MoonDay;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox SunDay;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox SunNight;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox MoonNight;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Label SearchNotesLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox SearchNotesTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton NewNoteButton;
        private System.ComponentModel.IContainer components;
        private Siticone.Desktop.UI.WinForms.SiticoneButton OpenNoteButton;
    }
}