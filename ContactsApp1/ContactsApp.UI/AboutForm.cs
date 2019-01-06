using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.UI
{
    /// <summary>
    /// Форма с описанием программы.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Отправляет пользователя на гитхаб.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/alexchitozvonov/ContactsApp1");
        }

        /// <summary>
        /// Отправить письмо по почте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Mailto:aleksandrr.nnn@gmail.com");
        }
    }
}
