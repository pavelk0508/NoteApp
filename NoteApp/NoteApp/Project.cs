using System.Collections.Generic;
using System.Linq;

namespace NoteApp
{
    	/// <summary>
	/// Класс записок, отвечающий за весь список записок.
	/// </summary>
    public class Project
    {
        //Список заметок.
        public List<Note> NoteList;

        // Текущая заметка.
        public Note CurrentNote = null;

        /// <summary>
        /// Инициализация Project.
        /// </summary>
        public Project()
        {
            NoteList = new List<Note>();
        }

        /// <summary>
        /// Вывод заметок заданной категории.
        /// </summary>
        /// <param name="noteCategory">Категория.</param>
        /// <returns>Список заметок.</returns>
        public List<Note> Sort(int noteCategory)
        {
            if (noteCategory == 0)
            {
                return Sort();
            }
            else
            {
                return Sort().FindAll(a => a.Category == (NoteCategory)noteCategory);
            }
        } 

        /// <summary>
        /// Сортировка списка по дате изменения.
        /// </summary>
        /// <returns>Список заметок.</returns>
        public List<Note> Sort()
        {
            var list = NoteList;
            list.Sort((a, b) =>
            {
                if (a.TimeChanged > b.TimeChanged)
                    return -1;
                return 1;
            });
            return list;
        }


    }
}
