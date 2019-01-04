using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Тесты для класса ProjectManager.
    /// </summary>
    [TestFixture]
    public class ProjectManagerTest
    {
        /// <summary>
        /// Путь к тестовому файлу.
        /// </summary>
        private const string TEST_FILE_PATH = @"\..\..\TestFiles\Project.txt";

        /// <summary>
        /// Контакт, который сохранен в файле.
        /// </summary>
        private readonly Contact _contact = new Contact("Name", "Surname", new DateTime(2019, 01, 01,22,59,29), "8111111",
            "email@email.com", "vkid");

        /// <summary>
        /// Проект, котоырый сохранен в файле.
        /// </summary>
        private readonly Project _project = new Project(new List<Contact>());
        
        /// <summary>
        /// Конструктор.
        /// </summary>
        public ProjectManagerTest()
        {
            _project.AddContact(_contact);
        }

        /// <summary>
        /// Тестирование LoadFromFile с корректным файлом.
        /// </summary>
        [Test(Description = "Тестирование LoadFromFile с корректным файлом.")]
        public void LoadFromFileTest_CorrectFile()
        {
            var correctFilePath = AppDomain.CurrentDomain.BaseDirectory+TEST_FILE_PATH;

            var manager = new ProjectManager(correctFilePath);
            var project = manager.LoadFromFile();
            Assert.IsTrue(project.Contacts != null, "LoadFromFile не загружает список.");
            Assert.IsTrue(project.Contacts.Count == 1, $"LoadFromFile загружает список, где более 1 контакта: {project.Contacts.Count}");
            
            var contact = project.Contacts.First();
            Assert.AreEqual(contact.Name,_contact.Name, "Name контакта загружено неправильно.");
            Assert.AreEqual(contact.DateOfBirthday,_contact.DateOfBirthday, "DateOfBirthday контакта загружено неправильно.");
            Assert.AreEqual(contact.Email,_contact.Email, "Email контакта загружено неправильно.");
            Assert.AreEqual(contact.Phone,_contact.Phone, "Phone контакта загружено неправильно.");
            Assert.AreEqual(contact.Surname,_contact.Surname, "Surname контакта загружено неправильно.");
            Assert.AreEqual(contact.VkId,_contact.VkId, "VkId контакта загружено неправильно.");
        }

        /// <summary>
        /// Тестирование LoadFromFile, когда файл отсутствует.
        /// </summary>
        [Test(Description = "Тестирование LoadFromFile, когда файл отсутствует.")]
        public void LoadFromFileTest_IncorrectFile()
        {
            var correctFilePath = AppDomain.CurrentDomain.BaseDirectory + TEST_FILE_PATH+".err";

            var manager = new ProjectManager(correctFilePath);
            var project = manager.LoadFromFile();
            Assert.IsTrue(project != null, "LoadFromFile не создает проект.");
            Assert.IsTrue(project.Contacts != null, "LoadFromFile не создает список.");
            Assert.IsTrue(project.Contacts.Count == 0, $"LoadFromFile загружает список из файла, которого быть не должно: {project.Contacts.Count}");
        }

        /// <summary>
        /// Тестирование SaveToFile.
        /// </summary>
        [Test(Description = "Тестирование SaveToFile.")]
        public void SaveToFileTest()
        {
            var correctFilePath = AppDomain.CurrentDomain.BaseDirectory + TEST_FILE_PATH + ".test";

            var manager = new ProjectManager(correctFilePath);
            manager.SaveToFile(_project);
            FileAssert.AreEqual(AppDomain.CurrentDomain.BaseDirectory + TEST_FILE_PATH, correctFilePath,"SaveToFile сохраняет файл, который отличается от заданного.");            
        }

        /// <summary>
        /// Удаляет тестовый файл, который был создан методом SaveToFile.
        /// </summary>
        [TearDown]
        public void RemoveTestFile()
        {
            var file = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + TEST_FILE_PATH + ".test");
            if (file.Exists)
            {
                File.Delete(file.FullName);
            }
        }
    }
}