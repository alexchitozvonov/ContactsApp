using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ContactsApp.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            var project = new Project(new List<Contact>
            {
                new Contact
                {
                    Name = "hhgf",
                    DateOfBirthday = new DateTime(2017, 5, 4),
                    Email = "agjdd@mdw.ru",
                    Phone = "+78945612301",
                    Surname = "jlwjlxw"
                },
                new Contact
                {
                    Name = "hhgf",
                    DateOfBirthday = new DateTime(1800, 5, 4),
                    Email = "agjdddw.ru",
                    Phone = "+78945688812301",
                    Surname = "jlwjlxw"
                },
                new Contact
                {
                    Name = "hhgf",
                    DateOfBirthday = new DateTime(2017, 5, 4),
                    Email = "agjdd@mdwu",
                    Phone = "+789456301",
                    Surname = "jlwjlxw"
                },
                new Contact
                {
                    Name = "hhgf",
                    DateOfBirthday = new DateTime(2019, 5, 4),
                    Email = "agjdd@mdw.ru",
                    Phone = "+7894561dcsdc2301",
                    Surname = "jlwjlxw"
                }
            });

            var pm = new ProjectManager(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "jkfje.conts"));

            pm.SaveToFile(project);

            var proj = pm.LoadFromFile();

            InitializeComponent();
        }
    }
}