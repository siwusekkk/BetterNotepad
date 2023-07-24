using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using BetterNotepad.Properties;

namespace BetterNotepad
{
    class DayNightMode
    {

        public static string DayOrNight = "";

        public static void ChangeMode(SiticoneToggleSwitch DayNightModeSwitch, SiticonePictureBox MoonDay, SiticonePictureBox SunDay, SiticonePictureBox MoonNight, SiticonePictureBox SunNight, Panel panel, Label AppTitle, Panel LinePanel, SiticoneControlBox MinimizeButton, SiticoneControlBox CloseButton, Label SearchNotesLabel, SiticoneTextBox SearchNotesTextBox, SiticoneButton NewNoteButton, SiticoneButton OpenNoteButton)
        {
            if(!DayNightModeSwitch.Checked)
            {
                // night mode
                Settings.Default.ColorMode = "night";
                Settings.Default.Save();
                MoonDay.Visible = false;
                SunDay.Visible = false;
                MoonNight.Visible = true;
                SunNight.Visible = true;
                panel.BackColor = Color.FromArgb(21, 21, 21);
                AppTitle.ForeColor = Color.White;
                LinePanel.BackColor = Color.White;
                MinimizeButton.IconColor = Color.White;
                CloseButton.IconColor = Color.White;
                SearchNotesLabel.ForeColor = Color.White;
                SearchNotesTextBox.ForeColor = Color.White;
                SearchNotesTextBox.FillColor = Color.FromArgb(21, 21, 21);
                SearchNotesTextBox.BorderColor = Color.White;
                NewNoteButton.FillColor = Color.White;
                NewNoteButton.ForeColor = Color.FromArgb(21, 21, 21);
                NewNoteButton.BorderColor = Color.FromArgb(21, 21, 21);
                OpenNoteButton.FillColor = Color.White;
                OpenNoteButton.ForeColor = Color.FromArgb(21, 21, 21);
                OpenNoteButton.BorderColor = Color.FromArgb(21, 21, 21);
            }
            else
            {
                //day mode
                Settings.Default.ColorMode = "day";
                Settings.Default.Save();
                MoonDay.Visible = true;
                SunDay.Visible = true;
                MoonNight.Visible = false;
                SunNight.Visible = false;
                panel.BackColor = Color.White;
                AppTitle.ForeColor = Color.FromArgb(21, 21, 21);
                LinePanel.BackColor = Color.FromArgb(21, 21, 21);
                MinimizeButton.IconColor = Color.FromArgb(21, 21, 21);
                CloseButton.IconColor = Color.FromArgb(21, 21, 21);
                SearchNotesLabel.ForeColor =Color.FromArgb(21, 21, 21);
                SearchNotesTextBox.ForeColor = Color.FromArgb(21, 21, 21);
                SearchNotesTextBox.FillColor = Color.White;
                SearchNotesTextBox.BorderColor = Color.FromArgb(21, 21, 21);
                NewNoteButton.FillColor = Color.FromArgb(21, 21, 21);
                NewNoteButton.ForeColor = Color.White;
                NewNoteButton.BorderColor = Color.FromArgb(21, 21, 21);
                OpenNoteButton.FillColor = Color.FromArgb(21, 21, 21);
                OpenNoteButton.ForeColor = Color.White;
                OpenNoteButton.BorderColor = Color.FromArgb(21, 21, 21);
            }
        }

        public static void StartupMode(String Checked, Panel BackgroundPanel)
        {
            if (Checked == "0")
            {
                // night mode
                BackgroundPanel.BackColor = Color.FromArgb(21, 21, 21);
            }
            else
            {
                //day mode
                BackgroundPanel.BackColor = Color.White;
            }
        }

        public static void GetDayNightModeSwitchCurrentMode(SiticoneToggleSwitch DayNightModeSwitch)
        {
            if (DayNightModeSwitch.Checked)
            {
                MainForm.dayNightModeSwitchCurrentMode = "1";
            }
            else
            {
                MainForm.dayNightModeSwitchCurrentMode = "0";
            }
        }

    }
}
