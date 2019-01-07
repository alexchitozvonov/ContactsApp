using System;
using System.Windows.Forms;
using ContactsApp.UI.CustomEventArgs;

namespace ContactsApp.UI.Controls
{
    /// <summary>
    /// Элемент управления проектом.
    /// </summary>
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
        /// Обновляет список контактов.
        /// </summary>
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

        /// <summary>
        /// Устанавливает актуальное значение поля SelectedContact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedContact = (Contact) ProjectListBox.SelectedItem;
        }
        
        /// <summary>
        /// Создает диалоговое окно добавления контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Project.AddContact(addForm.Contact);
                UpdateContactsAction?.Invoke();
            }
        }

        /// <summary>
        /// Удаляет текущий контакт.
        /// </summary>
        private void RemoveCurrentContact()
        {
            var contact = ProjectListBox.SelectedItem as Contact;
            if (MessageBox.Show($"Do you really want to remove this contact: {contact.Surname}?", Form.ActiveForm.Text , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Project.RemoveContact(contact);
                UpdateContactsAction?.Invoke();
            }
        }

        /// <summary>
        /// Нажатие на кнопку удаления контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveCurrentContact();
        }

        /// <summary>
        /// Создает диалог редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            if (ProjectListBox.SelectedItem == null)
            {
                return;
            }
            var addForm = new AddForm(ProjectListBox.SelectedItem as Contact);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Project.RemoveContact(ProjectListBox.SelectedItem as Contact);
                Project.AddContact(addForm.Contact);
                UpdateContactsAction?.Invoke();
                ProjectListBox.SelectedItem = addForm.Contact;
            }
        }

        /// <summary>
        /// Закрывает активную форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        /// <summary>
        /// Показывает окно О программе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// Фильтрует элементы по строке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Позволяет удалить контакт по клавише Del.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveCurrentContact();
            }
        }
    }
}
