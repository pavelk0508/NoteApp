using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUi
{
    /// <summary>
    /// Основная форма.
    /// </summary>
    public partial class MainForm : Form
    {
        //Основной список заметок.
        private Project _project = new Project();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Edit selected note.
        /// </summary>
        private void EditNote()
        {
            if (ListNotes.SelectedItem != null)
            {
                var item = (Note) ListNotes.SelectedItem;
                FormEditNote form = new FormEditNote();
                form.Note = (Note)item.Clone();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    item.Set(form.Note);
                    RefreshTable();
                }
            }
        }

        /// <summary>
        /// Add new note.
        /// </summary>
        private void AddNote()
        {
            FormEditNote form = new FormEditNote();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _project.NoteList.Add(form.Note);
                RefreshTable();
            }
        }

        /// <summary>
        /// Delete selected note.
        /// </summary>
        private void DeleteNote()
        {
            if (ListNotes.SelectedItem != null)
            {
                if (MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _project.NoteList.Remove((Note)ListNotes.SelectedItem);
                    RefreshTable();
                }
            }
        }

        /// <summary>
        /// Обновление listNotes и сохранение в файле изменения.
        /// </summary>
        private void RefreshTable()
        {        
            ProjectManager.SaveToFile(_project);

            //Заполняем listNotes.
            ListNotes.DataSource = null;
            ListNotes.DataSource = _project.Sort(ComboCategory.SelectedIndex);
            ListNotes.DisplayMember = "Title";
        }

        /// <summary>
        /// Попытка открыть файл с заметками. Если такового нет, то создать. Заполняем список заметок.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _project = ProjectManager.LoadFromFile();
            }
            catch (Exception ex)
            {
                ProjectManager.SaveToFile(_project);
            }

            ComboCategory.SelectedIndex = 0;

            //Сортируем список.     
            RefreshTable();

            if (_project.CurrentNote != null)
            {
                var index = ((List<Note>) ListNotes.DataSource).FindIndex(a => a.ToString() == _project.CurrentNote.ToString());
                if (ListNotes.Items.Count > 0 && index >= 0)
                {
                    ListNotes.SelectedIndex = index;
                }
            }
        }

        /// <summary>
        /// Добавить записку.
        /// </summary>
        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Редактировать записку.
        /// </summary>
        private void buttonEditNote_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Кнопка удаления
        /// </summary>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        /// <summary>
        /// Кнопка выхода.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Добавить заметку.
        /// </summary>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Редактировать заметку.
        /// </summary>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Удаление заметки.
        /// </summary>
        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        /// <summary>
        /// Кнопка вызова окна "О программе".
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        /// <summary>
        /// Событие при выделение ячейки. Вывод информации о заметке.
        /// </summary>
        private void ListNotes_Click(object sender, EventArgs e)
        {
            if (ListNotes.SelectedItem != null)
            {
                var item = (Note)ListNotes.SelectedItem;
                FieldTitle.Text = item.Title;
                FieldCategory.Text = item.Category.ToString();
                DateTimeCreated.Value = item.TimeCreated;
                DateTimeChanged.Value = item.TimeChanged;
                TextNote.Text = item.Text;
                _project.CurrentNote = item;

                RefreshTable();
            }
        }

        /// <summary>
        /// Выбор категории.
        /// </summary>
        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }

        /// <summary>
        /// Кнопка сортировки.
        /// </summary>
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            ListNotes.DataSource = null;
            ListNotes.DataSource = _project.Sort();
        }

        /// <summary>
        /// Удаление заметки по нажатию на кнопку Delete.
        /// </summary>
        private void ListNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteNote();
            }
        }

        private void ComboCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void ListNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListNotes.SelectedItem != null)
            {
                var note = (Note) ListNotes.SelectedItem;
                FieldTitle.Text = note.Title;
                FieldCategory.Text = note.Category.ToString();
                DateTimeCreated.Value = note.TimeCreated;
                DateTimeChanged.Value = note.TimeChanged;
                TextNote.Text = note.Text;
            }
        }
    }
}
