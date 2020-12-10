using Newtonsoft.Json;
using System;
using System.IO;
using Formatting = Newtonsoft.Json.Formatting;

namespace ContactsAppBLL
{
    public class ProjectManager
    {
        public static string MainFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ContactApp\\Contacts.txt";

        /// <summary>
        /// Сохранение файла контактов по стандартному пути 
        /// </summary>
        /// <param name="project">Сохраняемый класс</param>
        public static void SaveToFile(Project project)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(MainFilePath));
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Include;
            serializer.TypeNameHandling = TypeNameHandling.All;
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter sw = new StreamWriter(MainFilePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            };
        }

        public static Project LoadFromFile()
        {
            Project project = new Project();
            // try
            // {
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Include;
                serializer.TypeNameHandling = TypeNameHandling.All;
                serializer.Formatting = Formatting.None;
                using (StreamReader sr = new StreamReader(MainFilePath))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = (Project)serializer.Deserialize<Project>(reader);
                }
            // }
            // catch (Exception)
            // {
            //     return project;
            // }
            return project;
        }
   
    }

}
