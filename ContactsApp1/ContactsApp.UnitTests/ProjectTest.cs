using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Тесты для класса Project.
    /// </summary>
    [TestFixture]
    public class ProjectTest
    {
        /// <summary>
        /// Тестирование конструктора Project с пустым списком.
        /// </summary>
        [Test(Description = "Тестирование конструктора Project с пустым списком.")]
        public void ProjectConstructorTest_CorrectList()
        {
            var list = new List<Contact>();
            var project = new Project(list);

            Assert.AreSame(list,project.Contacts, "Неправильно присваивается список Contacts через конструктор.");
        }

        /// <summary>
        /// Тестирование конструктора Project с null списком Contacts.
        /// </summary>
        [Test(Description = "Тестирование конструктора Project с null списком Contacts.")]
        public void ProjectConstructorTest_NullList()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var a = new Project(null);
            }, "Конструктор Project не создает исключение при null списке Contacts.");
        }

        /// <summary>
        /// Тестирование AddContact с корректным контактом.
        /// </summary>
        [Test(Description = "Тестирование AddContact с корректным контактом.")]
        public void AddContactTest_CorrectContact()
        {
            var project = new Project(new List<Contact>());

            var contact = new Contact();
            project.AddContact(contact);

            Assert.AreEqual(project.Contacts.Count, 1, "Ошибка при добавлении одного контакта. Итоговое количество контактов не равно 1.");
            Assert.AreSame(project.Contacts.First(), contact, "Неправильно добавляется контакт в методе AddContact.");
        }

        /// <summary>
        /// Тестирование AddContact с null контактом.
        /// </summary>
        [Test(Description = "Тестирование AddContact с null контактом.")]
        public void AddContactTest_NullContact()
        {
            var project = new Project(new List<Contact>());

            Assert.Throws<ArgumentException>(() =>
            {
                project.AddContact(null);
            }, "Список контактов позволяет добавить null значение.");
        }

        /// <summary>
        /// Тестирование RemoveContact при удалении контакта который есть в списке.
        /// </summary>
        [Test(Description = "Тестирование RemoveContact при удалении контакта который есть в списке.")]
        public void RemoveContactTest_CorrectContact()
        {
            var contact = new Contact();
            var project = new Project(new List<Contact>(){contact});
            
            project.RemoveContact(contact);
            Assert.IsFalse(project.Contacts.Contains(contact), "Контакт не удаляется из списка.");
        }

        /// <summary>
        /// Тестирование RemoveContact при удалении контакта которого нет в списке.
        /// </summary>
        [Test(Description = "Тестирование RemoveContact при удалении контакта которого нет в списке.")]
        public void RemoveContactTest_WithoutAddContact()
        {
            var contact = new Contact();
            var project = new Project(new List<Contact>() {});

            Assert.Throws<ArgumentException>(() => { project.RemoveContact(contact); }, "Не создается исключение при удалении недобавленного контакта");
        }

        /// <summary>
        /// Тестирование RemoveContact при удалении контакта которого нет в списке.
        /// </summary>
        [Test(Description = "Тестирование RemoveContact при удалении контакта которого нет в списке.")]
        public void RemoveContactTest_NullContact()
        {
            var project = new Project(new List<Contact>());

            Assert.Throws<ArgumentException>(() => { project.RemoveContact(null); }, "Не создается исключение при удалении null контакта.");
        }

    }
}