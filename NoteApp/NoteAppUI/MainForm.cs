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
            //Заполняем listNotes.
            ListNotes.DataSource = null;
            ListNotes.DataSource = _project.NoteList;
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
            RefreshTable();            
        }

        // Обновляем записи в информации о записке.
        private void listNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        //Добавить записку.
        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            FormEditNote form = new FormEditNote();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _project.NoteList.Add(form.Note);
                RefreshTable();
            }
        }

        //Редактировать записку.
        private void buttonEditNote_Click(object sender, EventArgs e)
        {
            if (ListNotes.CurrentRow != null)
            {
                FormEditNote form = new FormEditNote();
                form.Note = _project.NoteList[ListNotes.CurrentRow.Index];
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _project.NoteList[ListNotes.CurrentRow.Index] = form.Note;
                    RefreshTable();
                }
            }
        }

        //Кнопка удаления
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ListNotes.CurrentRow != null)
            {
                if(MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _project.NoteList.Remove((Note)ListNotes.CurrentRow.DataBoundItem);
                    RefreshTable();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditNote form = new FormEditNote();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _project.NoteList.Add(form.Note);
                RefreshTable();
            }
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListNotes.CurrentRow != null)
            {
                FormEditNote form = new FormEditNote();
                form.Note = _project.NoteList[ListNotes.CurrentRow.Index];
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _project.NoteList[ListNotes.CurrentRow.Index] = form.Note;
                    RefreshTable();
                }
            }
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListNotes.CurrentRow != null)
            {
                if (MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _project.NoteList.Remove((Note)ListNotes.CurrentRow.DataBoundItem);
                    RefreshTable();
                 
                }
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void TableLayoutTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListNotes_Click(object sender, EventArgs e)
        {
            FieldTitle.Text = _project.NoteList[ListNotes.CurrentRow.Index].Title;
            FieldCategory.Text = _project.NoteList[ListNotes.CurrentRow.Index].Category.ToString();
            DateTimeCreated.Value = _project.NoteList[ListNotes.CurrentRow.Index].TimeCreated;
            DateTimeChanged.Value = _project.NoteList[ListNotes.CurrentRow.Index].TimeChanged;
            TextNote.Text = _project.NoteList[ListNotes.CurrentRow.Index].Text;
        }
    }
}
