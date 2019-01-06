using System;
using ContactsApp.UI.Controls;

namespace ContactsApp.UI.CustomEventArgs
{
    /// <summary>
    /// Аргументы события <see cref="ProjectControl.SelectedContactChanged"/>.
    /// </summary>
    public class SelectedContactChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Конструктор, устанавливающий старый и новый выбранные контакты.
        /// </summary>
        /// <param name="oldSelectedContact">Старый выбранный контакт.</param>
        /// <param name="newSelectedContact">Новый выбранный контакт.</param>
        public SelectedContactChangedEventArgs(Contact oldSelectedContact, Contact newSelectedContact)
        {
            OldSelectedContact = oldSelectedContact;
            NewSelectedContact = newSelectedContact;
        }

        /// <summary>
        /// Новый выбранный контакт.
        /// </summary>
        public Contact NewSelectedContact { get; }

        /// <summary>
        /// Старый выбранный контакт.
        /// </summary>
        public Contact OldSelectedContact { get; }
    }
}
