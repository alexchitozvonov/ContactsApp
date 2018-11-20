using System;
using System.Windows.Forms;

namespace ContactsApp.UI.Controls
{
    public partial class ProjectControl : UserControl
    {
        /// <summary>
        /// Проект.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Происходит, когда изменяется выбранный контакт.
        /// </summary>
        public Action<object, EventArgs> SelectedContactChanged;

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
        public Contact SelectedContact => (Contact) ProjectListBox.SelectedItem;

        /// <summary>
        /// Перерисовывает <see cref="ProjectListBox" />.
        /// </summary>
        private void UpdateContacts()
        {
            ProjectListBox.Items.Clear();

            _project?.Contacts.ForEach(contact => ProjectListBox.Items.Add(contact));

            ProjectListBox.Update();
        }

        private void ProjectListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedContactChanged.Invoke(this, e);
        }
    }
}