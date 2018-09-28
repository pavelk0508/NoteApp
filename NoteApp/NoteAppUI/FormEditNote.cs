using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    /// <summary>
    /// Окно добавления/редактирования заметки.
    /// </summary>
    public partial class FormEditNote : Form
    {
        public Note _note;

        public FormEditNote()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Работа с запиской.
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Note.Title = FieldTitle.Text;
                Note.Category = (NoteCategory)ComboBoxCategory.SelectedIndex;
                Note.Text = TextNote.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Инициализация формы.
        private void formEditNote_Load(object sender, EventArgs e)
        {
            ComboBoxCategory.Items.Add(NoteCategory.Work);
            ComboBoxCategory.Items.Add(NoteCategory.Home);
            ComboBoxCategory.Items.Add(NoteCategory.HealthAndSport);
            ComboBoxCategory.Items.Add(NoteCategory.People);
            ComboBoxCategory.Items.Add(NoteCategory.Documents);
            ComboBoxCategory.Items.Add(NoteCategory.Finance);
            ComboBoxCategory.Items.Add(NoteCategory.Miscellaneous);

            if (Note == null)
            {
                Note = new Note(DateTime.Now);
            }
            FieldTitle.Text = Note.Title;
            ComboBoxCategory.SelectedIndex = (int)Note.Category;
            DateTimeCreated.Value = Note.TimeCreated;
            DateTimeChanged.Value = Note.TimeChanged;
            TextNote.Text = Note.Text;
        }

        //Отклонение изменений.
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
