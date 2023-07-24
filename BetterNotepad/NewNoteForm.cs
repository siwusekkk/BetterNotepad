using BetterNotepad.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BetterNotepad
{
    public partial class NewNoteForm : Form
    {
        public NewNoteForm()
        {
            InitializeComponent();
        }

        public void NewNoteForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.ColorMode.Contains("night"))
            {
                // night mode
                BackgroundPanel.BackColor = Color.FromArgb(21, 21, 21);
                TitleTextBox.FillColor = Color.FromArgb(21, 21, 21);
                TitleTextBox.BackColor = Color.FromArgb(21, 21, 21);
                TitleTextBox.BorderColor = Color.White;
                TitleTextBox.ForeColor = Color.White;
                TagsTextBox.FillColor = Color.FromArgb(21, 21, 21);
                TagsTextBox.BackColor = Color.FromArgb(21, 21, 21);
                TagsTextBox.BorderColor = Color.White;
                TagsTextBox.ForeColor = Color.White;
                TitleLabel.ForeColor = Color.White;
                TagsLabel.ForeColor = Color.White;
                NoteLabel.ForeColor = Color.White;
                NoteTextBox.FillColor = Color.FromArgb(21, 21, 21);
                NoteTextBox.BackColor = Color.FromArgb(21, 21, 21);
                NoteTextBox.BorderColor = Color.White;
                NoteTextBox.ForeColor = Color.White;
                SaveNoteButton.FillColor = Color.White;
                SaveNoteButton.ForeColor = Color.Black;
            }
            else if (Settings.Default.ColorMode.Contains("day"))
            {
                // day mode
                BackgroundPanel.BackColor = Color.White;
                TitleTextBox.FillColor = Color.White;
                TitleTextBox.BackColor = Color.White;
                TitleTextBox.BorderColor = Color.FromArgb(21,21,21);
                TitleTextBox.ForeColor = Color.FromArgb(21,21,21);
                TagsTextBox.FillColor = Color.White;
                TagsTextBox.BackColor = Color.White;
                TagsTextBox.BorderColor = Color.FromArgb(21, 21, 21);
                TagsTextBox.ForeColor = Color.FromArgb(21, 21, 21);
                TitleLabel.ForeColor = Color.FromArgb(21, 21, 21);
                TagsLabel.ForeColor = Color.FromArgb(21, 21, 21);
                NoteLabel.ForeColor = Color.FromArgb(21, 21, 21);
                NoteTextBox.FillColor = Color.White;
                NoteTextBox.BackColor = Color.White;
                NoteTextBox.BorderColor = Color.FromArgb(21, 21, 21);
                NoteTextBox.ForeColor = Color.FromArgb(21, 21, 21);
                SaveNoteButton.FillColor = Color.Black;
                SaveNoteButton.ForeColor = Color.White;
            }
        }

        public void SaveNoteButton_Click(object sender, EventArgs e)
        {

            string writtenNoteTitle = TitleTextBox.Text;
            string writtenNoteTags = TagsTextBox.Text;
            string writtenNote = NoteTextBox.Text;

            /*List<Notes> notes = new List<Notes>();
            notes.Add(new Notes { Title = writtenNoteTitle, Tags = writtenNoteTags, Note = writtenNote });*/
            Notes notes = new Notes()
            {
                Title = writtenNoteTitle,
                Tags = writtenNoteTags,
                Note = writtenNote
            };
            string json = JsonConvert.SerializeObject(notes);
            string dir = @"C:\BetterNotepad";
            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string dir2 = @"C:\BetterNotepad\notes";
            if (!Directory.Exists(dir2))
            {
                Directory.CreateDirectory(dir2);
            }
            File.WriteAllText(@"C:\BetterNotepad\notes\" + writtenNoteTitle + ".json", json);

        }
    }
}
