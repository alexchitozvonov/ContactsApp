using System;
using System.IO;
using System.Windows.Forms;

namespace ContactsApp.UI
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Проект.
        /// </summary>
        private Project _project;

        public MainWindow()
        {
            var projectManager =
                new ProjectManager(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "ContactApp.contacts"));

            var _project = projectManager.LoadFromFile();

            InitializeComponent();

            ProjectControl.Project = _project;

            Closing += (sender, args) => projectManager.SaveToFile(_project);
        }
    }
}