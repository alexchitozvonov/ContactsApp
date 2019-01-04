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
            Contacts = contacts ?? throw new ArgumentException("Contacts не должен быть null.");
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
            if (contact == null)
            {
                throw new ArgumentException("Contact не должен быть null.");
            }
            Contacts.Add(contact);
        }

        /// <summary>
        /// Удаление контакта.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        public void RemoveContact(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentException("Контакт не должен быть null.");
            }
            if (!Contacts.Contains(contact))
            {
                throw new ArgumentException("Такого контакта нет в списке.");
            }
            Contacts.Remove(contact);
        }
    }
}