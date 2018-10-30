using NUnit.Framework;
using System;
using System.Linq;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test(Description = "Позитивный тест добавления элемента в список")]
        public void TestProjectListAdd_CorrectValue()
        {
            Note note = new Note(DateTime.Now);
            note.Text = "aw";
            var project = new Project();
            project.NoteList.Add(note);
            var actual = project.NoteList.First();
            Assert.AreEqual(note, actual, "Project возвращает неправильное значение");
        }

    }
}
