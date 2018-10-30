using NUnit.Framework;
using System;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        [Test(Description = "Позитивный тест геттера Title")]
        public void TestTitleGet_CorrectValue()
        {
            var Title = "Заметка";
            var note = new Note(DateTime.Now);
            note.Title = Title;
            var actual = note.Title;
            Assert.AreEqual(Title, actual, "Геттер Title возвращает неправильное значение");
        }
        [Test(Description = "Позитивный тест cеттера Title")]
        public void TestTitleSet_CorrectValue()
        {
            var Title = "Заметка";
            var note = new Note(DateTime.Now);
            note.Title = Title;

            var NewTitle = "Заметка";
            var actual = note.Title;
            Assert.AreEqual(NewTitle, actual, "Сеттер Title задает неверное значение");
        }
        [Test(Description = "Проверка на заголовок, длиной больше 50.")]
        public void TestTitleSet_Longer50()
        {
            var wrongTitle = "ЗаметкаЗаметкаЗаметкаЗаметкаЗаметкаЗаметкаЗаметкаЗаметкаЗаметкаЗаметка";
            var note = new Note(DateTime.Now);
            Assert.Throws<ArgumentException>(() => { note.Title = wrongTitle; }, "Должно возникать исключение, если длина заголовка длиннее 50 символов");
        }
        [Test(Description = "Проверка на заголовок, длиной равной 0.")]
        public void TestTitleSet_Equal0()
        {
            var wrongTitle = "";
            var note = new Note(DateTime.Now);
            note.Title = wrongTitle;
            Assert.AreEqual(note.Title, "Без названия", "Сеттер Title задает неверное значение");
        }
        [Test(Description = "Позитивный тест геттера Text")]
        public void TestTextGet_CorrectValue()
        {
            var Text = "Заметка";
            var note = new Note(DateTime.Now);
            note.Text = Text;
            var actual = note.Text;
            Assert.AreEqual(Text, actual, "Геттер Text возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест cеттера Text")]
        public void TestTextSet_CorrectValue()
        {
            var text = "Заметка";
            var note = new Note(DateTime.Now);
            note.Text = text;

            var NewText = "Заметка";
            var actual = note.Text;
            Assert.AreEqual(NewText, actual, "Сеттер Text задает неверное значение");
        }
        [Test(Description = "Проверка текста, длиной равной 0.")]
        public void TestTextSet_Equal0()
        {
            var wrongText = "";
            var note = new Note(DateTime.Now);
            Assert.Throws<ArgumentException>(() => { note.Text = wrongText; }, "Должно возникать исключение, если длина текста равно 0");
        }
        [Test(Description = "Позитивный тест геттера Category")]
        public void TestCategoryGet_CorrectValue()
        {
            var Text = NoteCategory.Home;
            var note = new Note(DateTime.Now);
            note.Category = Text;
            var actual = note.Category;
            Assert.AreEqual(Text, actual, "Геттер Category возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест cеттера Category")]
        public void TestCategorySet_CorrectValue()
        {
            var category = NoteCategory.Home;
            var note = new Note(DateTime.Now);
            note.Category = category;

            var newCategory = NoteCategory.Home;
            var actual = note.Category;
            Assert.AreEqual(newCategory, actual, "Сеттер Category задает неверное значение");
        }
        [Test(Description = "Проверка на категорию, невходящую в диапазон категорий.")]
        public void TestCategorySet_Null ()
        {
            NoteCategory wrongCategory = (NoteCategory)10;
            var note = new Note(DateTime.Now);
            Assert.Throws<ArgumentException>(() => { note.Category = wrongCategory; }, "Должно возникать исключение, если не входит в диапазон.");
        }
        [Test(Description = "Позитивный тест геттера NoteCreated")]
        public void TestNoteCreatedGet_CorrectValue()
        {
            var time = DateTime.Now;
            var note = new Note(time);
            var actual = note.TimeCreated;
            Assert.AreEqual(time, actual, "Геттер TimeCreated возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест геттера TimeChanged")]
        public void TestNoteChangedGet_CorrectValue()
        {
            var time = DateTime.Now;
            var note = new Note(time);
            var actual = note.TimeChanged;
            Assert.AreEqual(time, actual, "Геттер TimeChanged возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест сеттера TimeChanged")]
        public void TestNoteChangedSet_CorrectValue()
        {
            var time = DateTime.Now;
            var note = new Note(time);
            note.TimeChanged = time;
            var current = note.TimeChanged;
            Assert.AreEqual(time, current, "Сеттер TimeChanged возвращает неправильное значение");
        }

        [Test(Description = "Дата изменения больше, чем текущая дата")]
        public void TestNoteChangedSet_LongerCurrentDate()
        {
            var time = DateTime.Now;
            var note = new Note(time);
            time = time.AddDays(100);
            Assert.Throws<ArgumentException>(() => { note.TimeChanged = time; }, "Должно возникать исключение, если дата изменения больше, чем текущая.");
        }

        [Test(Description = "Дата создания больше, чем текущая дата")]
        public void TestNoteCreatedSet_LongerCurrentDate()
        {
            var time = DateTime.Now;
            time = time.AddDays(100);    
            Assert.Throws<ArgumentException>(() => { var note = new Note(time); }, "Должно возникать исключение, если дата создания больше, чем текущая.");
        }

        [Test(Description = "Позитивный тест Clone()")]
        public void TestClone_CorrectValue()
        {
            var note = new Note(DateTime.Now);
            note.Text = "Заметка";
            Note clone = (Note)note.Clone();
            Assert.AreEqual(note.ToString(), clone.ToString(), "Метод Clone возвращает неверное значение.");
        }

        [Test(Description = "Позитивный тест ToString()")]
        public void TestToString_CorrectValue()
        {
            var time = DateTime.Now;
            var text = "Заметка";
            var note = new Note(time);
            var cat = NoteCategory.Work;
            note.Text = text;
            note.Category = cat;
            var success = $"Без названия {time} {time} {cat} {text}";
            Assert.AreEqual(note.ToString(), success, "Метод ToString() возвращает неверное значение.");

        }

    }
}
