using System;
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
            if (contacts == null)
            {
                throw new ArgumentException("Contacts не должен быть null.");
            }
            Contacts = contacts;
        }

        /// <summary>
        /// Контакты.
        /// </summary>
        public List<Contact> Contacts { get; }

        /// <summary>
        /// Добавление контакта.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        /// <summary>
        /// Удаление контакта.
        /// </summary>
        /// <param name="contact"></param>
        public void RemoveContact(Contact contact)
        {
            Contacts.Remove(contact);
        }
    }
}