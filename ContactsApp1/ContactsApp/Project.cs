using System;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// Позволяет получить список контактов отсортированный по алфавиту.
        /// </summary>
        /// <returns>Список контактов отсортированный по алфавиту.</returns>
        public List<Contact> GetSortedContacts()
        {
            return Contacts.OrderBy(o => o.ToString()).ToList();
        }

        /// <summary>
        /// Позволяет получить список контактов,строковое представление которых содержит строку, отсортированный по алфавиту.
        /// </summary>
        /// <param name="filter">Строка, которую должно содержать строковое представление контакта.</param>
        /// <returns>Отфильтрованный список контактов по алфавиту, строковое представление которых содержит строку.</returns>
        public List<Contact> GetSortedContacts(string filter)
        {
            return Contacts.Where(s=>s.ToString().Contains(filter)).OrderBy(o => o.ToString()).ToList();
        }


    }
}