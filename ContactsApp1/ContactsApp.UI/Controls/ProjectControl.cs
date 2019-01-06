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

        private Action UpdateContactsAction;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ProjectControl()
        {
            InitializeComponent();
            UpdateContactsAction = this.UpdateContacts;
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
                UpdateContactsAction?.Invoke();
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

            _project?.GetSortedContacts().ForEach(contact => ProjectListBox.Items.Add(contact));

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
                UpdateContactsAction?.Invoke();
            }
        }

        private void RemoveCurrentContact()
        {
            Project.RemoveContact(_project.Contacts[ProjectListBox.SelectedIndex]);
            UpdateContactsAction?.Invoke();
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveCurrentContact();
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            if (ProjectListBox.SelectedItem == null)
            {
                return;
            }
            var addForm = new AddForm(ProjectListBox.SelectedItem as Contact);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Project.RemoveContact(_project.Contacts[ProjectListBox.SelectedIndex]);
                Project.AddContact(addForm.Contact);
                UpdateContactsAction?.Invoke();
                ProjectListBox.SelectedItem = addForm.Contact;
            }
        }

        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text.Length > 0)
            {
                UpdateContactsAction = () =>
                {
                    ProjectListBox.Items.Clear();
                    _project?.GetSortedContacts(FindTextBox.Text).ForEach(contact => ProjectListBox.Items.Add(contact));
                    ProjectListBox.Update();
                };
            }
            else
            {
                UpdateContactsAction = UpdateContacts;
            }
            UpdateContactsAction?.Invoke();
        }

        private void ProjectListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ProjectListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Удалить контакт?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RemoveCurrentContact();
                }
            }
        }
    }
}
