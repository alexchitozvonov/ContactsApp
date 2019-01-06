using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ContactsApp.UI
{
    /// <summary>
    /// Главное окно программы.
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Проект.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public MainWindow()
        {

            var projectManager =
                new ProjectManager(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "ContactApp.contacts"));

            InitializeComponent();

            var _project = projectManager.LoadFromFile();
            ProjectControl.Project = _project;
            ProjectControl.SelectedContactChanged += (sender, args) => ContactControl.UpdateData(ProjectControl.SelectedContact);
            Closing += (sender, args) => projectManager.SaveToFile(_project);
            string birthdayed="Сегодня день рождения у:";
            foreach (var contact in _project.Contacts)
            {
                if (contact.DateOfBirthday.Day == DateTime.Now.Day && contact.DateOfBirthday.Month == DateTime.Now.Month)
                {
                    birthdayed += $"{contact.Surname},";
                }
            }
            BirthdayTextBox.Text = birthdayed;
        }



    }
}