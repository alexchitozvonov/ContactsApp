using System.Collections.Generic;

namespace ContactsApp
{
    /// <summary>
    /// Проект.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Конструктор, устанавливающий значения контактов.
        /// </summary>
        /// <param name="contacts">Контакты.</param>
        public Project(List<Contact> contacts)
        {
            Contacts = contacts;
        }

        /// <summary>
        /// Контакты.
        /// </summary>
        public List<Contact> Contacts { get; }
    }
}