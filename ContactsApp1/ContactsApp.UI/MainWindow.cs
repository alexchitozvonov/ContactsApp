using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
            StringBuilder birdthdayBuilder = new StringBuilder();
            birdthdayBuilder.Append("Сегодня день рождения:");
            birdthdayBuilder.AppendLine();
            var sortedContacts = _project.GetSortedContacts();
            bool birthdaysDelimitter = false;
            for (int i = 0; i < sortedContacts.Count; i++)
            {
                if (sortedContacts[i].DateOfBirthday.Day == DateTime.Now.Day && sortedContacts[i].DateOfBirthday.Month == DateTime.Now.Month)
                {
                    birdthdayBuilder.Append($"{(birthdaysDelimitter ? ", " : "")}{sortedContacts[i].Surname}");
                    happyBirthdayPanel.Visible = true;
                    birthdaysDelimitter = true;
                }
            }
            BirthdayTextBox.Text = birdthdayBuilder.ToString();
        }



    }
}