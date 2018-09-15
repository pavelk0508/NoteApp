using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace NoteApp
{
    /// <summary>
    /// Класс описывающий записку Note.
    /// </summary>
    public class Note : ICloneable
    {
        private string _title = "Без названия";
        private NoteCategory _noteCategory;
        private string _text;
        [JsonProperty("TimeCreated")]
        public readonly DateTime TimeCreated;
        private DateTime _timeChanged;

        /// <summary>
        /// Создание заметки с указанием времени создания заметки.
        /// </summary>
        /// <param name="dateTime">Время создания.</param>
        public Note(DateTime dateTime)
        {
            if (dateTime <= DateTime.Now)
            {
                TimeCreated = dateTime;
                _timeChanged = dateTime;
            }
            else
            {
                throw new ArgumentException("Дата указана неверно!");
            }
        }

        /// <summary>
        /// Задание даты изменения.
        /// </summary>
        public DateTime TimeChanged
        {
            get
            {
                return _timeChanged;
            }
            set
            {
                if (value <= DateTime.Now)
                {
                    _timeChanged = value;
                }
                else
                {
                    throw new ArgumentException("Дата изменения не может быть больше, чем текущая дата.");
                }
            }
        }

        /// <summary>
        /// Имя заметки.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 0 && value.Length < 50)
                {
                    _title = value;
                }
                else
                {
                    if (value.Length >= 50)
                    {
                        throw new ArgumentException("Длина заголовка должна быть меньше 50.");
                    }
                }
            }
        }

        /// <summary>
        /// Текст заметки.
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (value.Length > 0)
                {
                    _text = value;
                }
                else
                {
                    throw new ArgumentException("Длина текста должна быть больше 0.");
                }
            }
        }

        /// <summary>
        /// Категория записки.
        /// </summary>
        public NoteCategory Category
        {
            get
            {
                return _noteCategory;
            }
            set
            {
                if (value >= 0)
                {
                    _noteCategory = value;
                }
                else
                {
                    throw new ArgumentException("Указана неправильная категория.");
                }
            }
        }

        /// <summary>
        /// Клонирование объекта.
        /// </summary>
        /// <returns>Возвращает дубликат текущей записки.</returns>
        public object Clone()
        {
            return new Note(this.TimeCreated) { Title = this.Title, TimeChanged = this.TimeChanged, Category = this.Category, Text=this.Text };
        }
    }
}
