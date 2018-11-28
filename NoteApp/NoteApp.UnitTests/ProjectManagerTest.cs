using NUnit.Framework;
using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        [Test(Description = "Позитивный тест сериализации. Сохранение")]
        public void TestProjectManagerSaveTToFile_CorrectValue()
        {
            Note note = new Note(DateTime.Now);
            note.Text = "aw";
            var project = new Project();
            project.NoteList.Add(note);
            ProjectManager.SaveToFile(project);

            var actual = ProjectManager.LoadFromFile().NoteList.Last();
            Assert.AreEqual(note.Text, actual.Text, "Сериализация работает неверно!");
        }
        [Test(Description = "Сохранение в неверный путь.")]
        public void TestProjectManagerSaveToFile_NotCorrectPath()
        {
            Note note = new Note(DateTime.Now);
            note.Text = "aw";
            var project = new Project();
            project.NoteList.Add(note);
            Assert.Throws<System.IO.IOException>(() => { ProjectManager.SaveToFile(project, "c:\\distribution\\"); }, "Должно возникать исключение, если путь неверен.");
        }
        [Test(Description = "Открытие из неверного пути.")]
        public void TestProjectManagerLoadFromFile_NotCorrectPath()
        {
            Assert.Throws<System.IO.FileNotFoundException>(() => { var project = ProjectManager.LoadFromFile("c:\\distribution\\"); }, "Должно возникать исключение, если путь неверен.");
        }

        [Test(Description = "Открытие испорченного файла пути.")]
        public void TestProjectManagerLoadFromFile_NotCorrectFile ()
        {
            var text = "I not correct file";
            var fileName = "c:\\users\\admin\\test.txt";
            File.WriteAllText(fileName, text);
            Assert.Throws<JsonReaderException>(() => { var project = ProjectManager.LoadFromFile(fileName); }, "Должно возникать исключение, если файл испорчен.");
        }

    }
}
