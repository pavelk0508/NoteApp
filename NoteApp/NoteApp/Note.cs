using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace NoteApp
{
    	/// <summary>
	/// ����� ����������� ������� Note.
	/// </summary>
    public class Note : ICloneable
    {
        private string _title = "��� ��������";
        private NoteCategory _noteCategory;
        private string _text;
        [JsonProperty("TimeCreated")]
        public readonly DateTime TimeCreated;
        private DateTime _timeChanged;

        /// <summary>
        /// �������� ������� � ��������� ������� �������� �������.
        /// </summary>
        /// <param name="dateTime">����� ��������.</param>
        public Note(DateTime dateTime)
        {
            if (dateTime <= DateTime.Now)
            {
                TimeCreated = dateTime;
                _timeChanged = dateTime;
            }
            else
            {
                throw new ArgumentException("���� ������� �������!");
            }
        }

        /// <summary>
        /// ������ ��������� ������� �� ������ �������.
        /// </summary>
        /// <param name="note">�������.</param>
        public void Set(Note note)
        {
            this._noteCategory = note.Category;
            this._text = note.Text;
            this._title = note.Title;
            this._timeChanged = note.TimeChanged;
        }

        /// <summary>
        /// ������� ���� ���������.
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
                    throw new ArgumentException("���� ��������� �� ����� ���� ������, ��� ������� ����.");
                }
            }
        }

        /// <summary>
        /// ��� �������.
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
                        throw new ArgumentException("����� ��������� ������ ���� ������ 50.");
                    }
                }
            }
        }

        /// <summary>
        /// ����� �������.
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
                    throw new ArgumentException("����� ������ ������ ���� ������ 0.");
                }
            }
        }

        /// <summary>
        /// ��������� �������.
        /// </summary>
        public NoteCategory Category
        {
            get
            {
                return _noteCategory;
            }
            set
            {
                if (value >= NoteCategory.Work && value <= NoteCategory.Miscellaneous)
                {
                    _noteCategory = value;
                }
                else
                {
                    throw new ArgumentException("������� ������������ ���������.");
                }
            }
        }

        /// <summary>
        /// ������������ �������.
        /// </summary>
        /// <returns>���������� �������� ������� �������.</returns>
        public object Clone()
        {
            Note note = new Note(this.TimeCreated);
            note.Title = this.Title;
            note.Text = this.Text;
            note.TimeChanged = this.TimeChanged;
            note.Category = this.Category;
            return note;
        }


        public string ToString()
        {
            return $"{this.Title} {this.TimeCreated} {this.TimeChanged} {this.Category} {this.Text}";
        }
    }
}
