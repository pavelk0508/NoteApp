﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //функционал нужно дописать.
            NoteList.Sort((a, b) => a.TimeChanged.CompareTo(b.TimeChanged));
        }
    }
}
