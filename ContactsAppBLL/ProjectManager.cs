﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Formatting = Newtonsoft.Json.Formatting;

namespace ContactsAppBLL
{
    public class ProjectManager
    {
       
        public static readonly string DefaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                                    "\\ContactApp\\Contacts.txt";
        /// <summary>
        /// Сохранение файла контактов по указанному пути
        /// </summary>
        /// <param name="project">Сохраняемый класс</param>
        /// <param name="savePath">Путь для сохранения файла проекта</param>
        public static void SaveToFile(Project project, string savePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(savePath));
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Include;
            serializer.TypeNameHandling = TypeNameHandling.All;
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter sw = new StreamWriter(savePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            };
        }
        /// <summary>
        /// Загрузка файла из указанного пути
        /// </summary>
        /// <param name="loadPath"> Путь по которому необходимо произовдить загрузку</param>
        /// <returns></returns>
        public static Project LoadFromFile(string loadPath)
        {
            Project project = new Project();
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Include;
                serializer.TypeNameHandling = TypeNameHandling.All;
                serializer.Formatting = Formatting.None;
                using (StreamReader sr = new StreamReader(loadPath))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = (Project)serializer.Deserialize<Project>(reader);
                }
            }
            catch (Exception)
            {
                return project;
            }
            return project;
        }

        /// <summary>
        /// Метод поиска в списке , ищет совпадение во всех переменных списка
        /// </summary>
        /// <param name="finding"> Искомый параметр</param>
        /// <param name="FindThis"> Список в котором необходимо производить поиск</param>
        /// <returns>Возвращает СПИСОК с найденными совпадениями</returns>
        public static List<Contact> FindInProject(string finding,List<Contact> FindThis)
        {
            var _viewsContacts = new List<Contact>();
            if (string.IsNullOrEmpty(finding))
            {
                _viewsContacts = FindThis;
                return _viewsContacts;
            }
            _viewsContacts = FindThis.FindAll(o => o.Surname.Contains(finding));
            return _viewsContacts;
        }
    }

}
