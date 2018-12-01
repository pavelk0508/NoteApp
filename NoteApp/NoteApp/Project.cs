using System.Collections.Generic;
using System.Linq;

namespace NoteApp
{
    	/// <summary>
	/// ����� �������, ���������� �� ���� ������ �������.
	/// </summary>
    public class Project
    {
        //������ �������.
        public List<Note> NoteList;

        // ������� �������.
        public Note CurrentNote = null;

        /// <summary>
        /// ������������� Project.
        /// </summary>
        public Project()
        {
            NoteList = new List<Note>();
        }

        /// <summary>
        /// ����� ������� �������� ���������.
        /// </summary>
        /// <param name="noteCategory">���������.</param>
        /// <returns>������ �������.</returns>
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
        /// ���������� ������ �� ���� ���������.
        /// </summary>
        /// <returns>������ �������.</returns>
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
