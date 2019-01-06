using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsApp.UI
{
    public partial class AddForm : Form
    {

        public AddForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        /// <param name="contact"></param>
        public AddForm(Contact contact)
        {
            InitializeComponent();
            this.contactControl.SurnameTextBox.Text = contact.Surname;
            this.contactControl.NameTextBox.Text = contact.Name;
            this.contactControl.BurthdayDateTimePicker.Value = (System.DateTime)contact.DateOfBirthday;
            this.contactControl.PhoneTextBox.Text = contact.Phone;
            this.contactControl.EmailTextBox.Text = contact.Email;
            this.contactControl.VkcomTextBox.Text = contact.VkId;
        }

        private void MyCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Contact _contact;
        
        /// <summary>
        /// Свойство Контакт.
        /// </summary>
        public Contact Contact
        {
            private set
            {
                _contact = value;
            }
            get
            {
                return _contact;
            }
        }

        /// <summary>
        /// Обработка кнопки ОК.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                var contact = new Contact(this.contactControl.NameTextBox.Text,
                    this.contactControl.SurnameTextBox.Text,
                    this.contactControl.BurthdayDateTimePicker.Value,
                    this.contactControl.PhoneTextBox.Text,
                    this.contactControl.EmailTextBox.Text,
                    this.contactControl.VkcomTextBox.Text);
                Contact = contact;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message, this.Text);
            }
            
        }
    }
}
