using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    	/// <summary>
	/// Сериализация для класса Note.
	/// </summary>
    public class ProjectManager
    {
        // Путь в папку "Документы".
        private static string _defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal)+@"\NoteApp.notes";

        /// <summary>
        /// Сохранение списка заметок в файл.
        /// </summary>
        /// <param name="listNotes">Список заметок.</param>
        /// <param name="fileName">Имя файла назначения.</param>
        public static void SaveToFile(Project listNotes, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, (Project)listNotes);
            }
        }

        /// <summary>
        /// Сохранение заметок в путь по умолчанию.
        /// </summary>
        /// <param name="listNotes">Список записок</param>
        public static void SaveToFile(Project listNotes)
        {
            SaveToFile(listNotes, _defaultPath);
        }

        /// <summary>
        /// Получение список заметок из файла.
        /// </summary>
        /// <param name="filename">Имя файла.</param>
        /// <returns></returns>
        public static Project LoadFromFile(string fileName)
        {
            Project notes = new Project();
            //Создаём экземпляр сериализатора.
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути.
            using (StreamReader sr = new StreamReader(fileName))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных.
                var noteList = (Project)serializer.Deserialize<Project>(reader);
                notes = noteList;
            }
            return notes;
        }

        /// <summary>
        /// Возвращает список заметок из файла по умолчанию.
        /// </summary>
        /// <returns>Список заметок.</returns>
        public static Project LoadFromFile()
        {
            return LoadFromFile(_defaultPath);
        }
    }
}
