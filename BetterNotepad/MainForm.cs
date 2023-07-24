using Newtonsoft.Json;
using System.Text.Json;

namespace BetterNotepad
{
    public partial class MainForm : Form
    {
        string version = "1.0";
        public static string dayNightModeSwitchCurrentMode = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AppTitle.Text = "BetterNotepad v" + version;
            /*if (Directory.Exists(@"C:\BetterNotepad\notes"))
            {
                string root = @"C:\BetterNotepad\notes";
                var files = from file in Directory.GetFiles(root) select file;
                foreach (var file in files)
                {
                    var label = new Label();
                    label.Text = file.ToString();
                    label.ForeColor = Color.White;
                    label.Location = new Point(100, 300);
                    label.BringToFront();
                    this.Controls.Add(label);
                }
            }*/
        }

        private void DayNightModeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            DayNightMode.ChangeMode(DayNightModeSwitch, MoonDay, SunDay, MoonNight, SunNight, BackgroundPanel, AppTitle, LinePanel, MinimizeButton, CloseButton, SearchNotesLabel, SearchNotesTextBox, NewNoteButton, OpenNoteButton);
            DayNightMode.GetDayNightModeSwitchCurrentMode(DayNightModeSwitch);
        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            NewNoteForm newNoteForm = new NewNoteForm();
            newNoteForm.Show();
        }

        private void OpenNoteButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\BetterNotepad\notes\";
            string searchedTitle = SearchNotesTextBox.Text;
            string text = File.ReadAllText(path + searchedTitle + ".json");
            var noteInfo = JsonConvert.DeserializeObject<Notes>(text);
            using (NewNoteForm form = new NewNoteForm())
            {
                form.TitleTextBox.Text = noteInfo.Title;
                form.TagsTextBox.Text = noteInfo.Tags;
                form.NoteTextBox.Text = noteInfo.Note;
                form.ShowDialog();
            }
        }
    }
}