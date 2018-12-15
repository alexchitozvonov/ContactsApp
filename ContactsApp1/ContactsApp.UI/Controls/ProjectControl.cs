using System;
using System.Windows.Forms;
using ContactsApp.UI.CustomEventArgs;

namespace ContactsApp.UI.Controls
{
    public partial class ProjectControl : UserControl
    {
        /// <summary>
        /// Проект.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Выделенный контакт.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Происходит, когда изменяется выбранный контакт.
        /// </summary>
        public event Action<object, SelectedContactChangedEventArgs> SelectedContactChanged;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ProjectControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проект.
        /// </summary>
        public Project Project
        {
            get => _project;
            set
            {
                _project = value;
                UpdateContacts();
            }
        }

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                var oldSelectedContact = _selectedContact;
                _selectedContact = value; 
                SelectedContactChanged?.Invoke(this, new SelectedContactChangedEventArgs(oldSelectedContact, _selectedContact));
            }
        }
          
        /// <summary>
        /// Перерисовывает <see cref="ProjectListBox"/>.
        /// </summary>
        private void UpdateContacts()
        {
            ProjectListBox.Items.Clear();

            _project?.Contacts.ForEach(contact => ProjectListBox.Items.Add(contact));

            ProjectListBox.Update();
        }


        private void ProjectListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedContact = (Contact) ProjectListBox.SelectedItem;
        }
        
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Project.AddContact(addForm.Contact);
                UpdateContacts();
            }
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            Project.RemoveContact(_project.Contacts[ProjectListBox.SelectedIndex]);
            UpdateContacts();
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm(_project.Contacts[ProjectListBox.SelectedIndex]);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Project.RemoveContact(_project.Contacts[ProjectListBox.SelectedIndex]);
                Project.AddContact(addForm.Contact);
                UpdateContacts();
            }
        }
    }
}
