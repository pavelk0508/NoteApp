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
	/// ������������ ��� ������ Note.
	/// </summary>
    public class ProjectManager
    {
        // ���� � ����� "���������".
        private static string _defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal)+@"\NoteApp.notes";

        /// <summary>
        /// ���������� ������ ������� � ����.
        /// </summary>
        /// <param name="listNotes">������ �������.</param>
        /// <param name="fileName">��� ����� ����������.</param>
        public static void SaveToFile(Project listNotes, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();
            //��������� ����� ��� ������ � ���� � ��������� ����
            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //�������� ������������ � �������� ������, ������� ����� �������������
                serializer.Serialize(writer, (Project)listNotes);
            }
        }

        /// <summary>
        /// ���������� ������� � ���� �� ���������.
        /// </summary>
        /// <param name="listNotes">������ �������</param>
        public static void SaveToFile(Project listNotes)
        {
            SaveToFile(listNotes, _defaultPath);
        }

        /// <summary>
        /// ��������� ������ ������� �� �����.
        /// </summary>
        /// <param name="filename">��� �����.</param>
        /// <returns></returns>
        public static Project LoadFromFile(string fileName)
        {
            Project notes = new Project();
            //������ ��������� �������������.
            JsonSerializer serializer = new JsonSerializer();
            //��������� ����� ��� ������ �� ����� � ��������� ����.
            using (StreamReader sr = new StreamReader(fileName))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //�������� �������������� � ���� ����������� ��������� � ������� ��� ������.
                var noteList = (Project)serializer.Deserialize<Project>(reader);
                notes = noteList;
            }
            return notes;
        }

        /// <summary>
        /// ���������� ������ ������� �� ����� �� ���������.
        /// </summary>
        /// <returns>������ �������.</returns>
        public static Project LoadFromFile()
        {
            return LoadFromFile(_defaultPath);
        }
    }
}
