using System;
using System.Collections.Generic;
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

            

            InitializeComponent();

            var _project = projectManager.LoadFromFile();
           //var data = DateTime.Now.AddYears(-1);
           //var Contact = new Contact("vasa","da",data, "+78945612301", "agjdd@mdw.ru","12");
           //var list = new List<Contact>();
           // list.Add(Contact);
           // var _project = new Project(list);
            ProjectControl.Project = _project;
            ProjectControl.SelectedContactChanged += (sender, args) => ContactControl.UpdateData(ProjectControl.SelectedContact); 

            Closing += (sender, args) => projectManager.SaveToFile(_project);
        }

        private void ContactControl_Load(object sender, EventArgs e)
        {
            
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //var projectManager =
            //    new ProjectManager(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            //        "ContactApp.contacts"));
           // projectManager.SaveToFile(_project);
        }
    }
}