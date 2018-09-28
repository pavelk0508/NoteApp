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
        private Project _project = new Project();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновление listNotes и сохранение в файле изменения.
        /// </summary>
        private void RefreshTable()
        {
            ListNotes.Items.Clear();
            //Заполняем listNotes.
            for (int i = 0; i < _project.NoteList.Count; i++)
            {
                ListNotes.Items.Add(_project.NoteList[i].Title);
            }
            ProjectManager.SaveToFile(_project);
        }

        // Попытка открыть файл с заметками. Если такового нет, то создать.
        // Также заполнить список записок listNotes.
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

            //Сортируем список.
            _project.Sort();
            _refreshTable();            
        }

        // Обновляем записи в информации о записке.
        private void listNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FieldTitle.Text = _project.NoteList[ListNotes.SelectedIndex].Title;
            FieldCategory.Text = _project.NoteList[ListNotes.SelectedIndex].Category.ToString();
            DateTimeCreated.Value = _project.NoteList[ListNotes.SelectedIndex].TimeCreated;
            DateTimeChanged.Value = _project.NoteList[ListNotes.SelectedIndex].TimeChanged;
            TextNote.Text = _project.NoteList[ListNotes.SelectedIndex].Text;
        }

        //Добавить записку.
        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            int selectedItem = ListNotes.SelectedIndex;
            FormEditNote form = new FormEditNote();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _project.NoteList.Add(form.Note);
                RefreshTable();
                ListNotes.SelectedIndex = selectedItem;
            }
        }

        //Редактировать записку.
        private void buttonEditNote_Click(object sender, EventArgs e)
        {
            int selectedItem = ListNotes.SelectedIndex;
            if (ListNotes.SelectedIndex >= 0)
            {
                FormEditNote form = new FormEditNote();
                form.Note = _project.NoteList[ListNotes.SelectedIndex];
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _project.NoteList[ListNotes.SelectedIndex] = form.Note;
                    RefreshTable();
                    ListNotes.SelectedIndex = selectedItem;
                }
            }
        }

        //Кнопка удаления
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedItem = ListNotes.SelectedIndex;
            if (ListNotes.SelectedIndex >= 0)
            {
                if(MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _project.NoteList.Remove(_project.NoteList[selectedItem]);
                    RefreshTable();
                    ListNotes.SelectedIndex = selectedItem - 1;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedItem = ListNotes.SelectedIndex;
            FormEditNote form = new FormEditNote();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _project.NoteList.Add(form.Note);
                RefreshTable();
                ListNotes.SelectedIndex = selectedItem;
            }
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedItem = ListNotes.SelectedIndex;
            if (ListNotes.SelectedIndex >= 0)
            {
                FormEditNote form = new FormEditNote();
                form.Note = _project.NoteList[ListNotes.SelectedIndex];
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _project.NoteList[ListNotes.SelectedIndex] = form.Note;
                    RefreshTable();
                    ListNotes.SelectedIndex = selectedItem;
                }
            }
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedItem = ListNotes.SelectedIndex;
            if (ListNotes.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _project.NoteList.Remove(_project.NoteList[selectedItem]);
                    RefreshTable();
                    ListNotes.SelectedIndex = selectedItem - 1;
                }
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
    }
}
