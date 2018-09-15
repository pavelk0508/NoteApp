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
    public partial class MainForm : Form
    {
        public Project notesList = new Project();

        public MainForm()
        {
            InitializeComponent();
        }

        //Событие при нажатие на кнопку "Добавить".
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Note note = new Note(DateTime.Now);
                note.Text = fldText.Text;
                note.Title = fldTitle.Text;
                note.Category = (NoteCategory)fldCategory.SelectedIndex;
                notesList.NoteList.Add(note);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateDataSet();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обновляет таблицу.
        /// </summary>
        private void UpdateDataSet()
        {
            dataGridView1.Rows.Clear();
            for(int i = 0; i < notesList.NoteList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["Title"].Value = notesList.NoteList[i].Title;
                dataGridView1.Rows[i].Cells["TimeAdded"].Value = notesList.NoteList[i].TimeCreated;
                dataGridView1.Rows[i].Cells["TimeChanged"].Value = notesList.NoteList[i].TimeChanged;
                dataGridView1.Rows[i].Cells["Text"].Value = notesList.NoteList[i].Text;
                dataGridView1.Rows[i].Cells["Category"].Value = notesList.NoteList[i].Category;
            }
        }

        private void noteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        //Событие при нажатие на кнопку "Сохранения".
        private void btnSave_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(notesList, @"e:\out.txt");
        }

        //Событие при нажатие на кнопку "Открыть".
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                notesList = ProjectManager.LoadFromFile(@"e:\out.txt");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateDataSet();

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
