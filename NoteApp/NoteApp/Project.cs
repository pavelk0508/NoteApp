using System.Collections.Generic;

namespace NoteApp
{
    /// <summary>
    /// Класс записок, отвечающий за весь список записок.
    /// </summary>
    public class Project
    {
        //Список заметок.
        public List<Note> NoteList;

        /// <summary>
        /// Инициализация Project.
        /// </summary>
        public Project()
        {
            NoteList = new List<Note>();
        }

        /// <summary>
        /// Сортировка списка по дате изменения.
        /// </summary>
        public void Sort()
        {
            NoteList.Sort((a, b) => a.TimeChanged.CompareTo(b.TimeChanged));
        }
    }
}
