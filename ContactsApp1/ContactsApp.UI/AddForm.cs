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
        public AddForm(Contact contact)
        {
            InitializeComponent();
            this.contactControl.SurnameTextBox.Text = contact.Surname;
            this.contactControl.NameTextBox.Text = contact.Name;
            this.contactControl.BurthdayDateTimePicker.Value = contact.DateOfBirthday;
            this.contactControl.PhoneTextBox.Text = contact.Phone;
            this.contactControl.EmailTextBox.Text = contact.Email;
            this.contactControl.VkcomTextBox.Text = contact.VkId;
        }

        private void MyCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Contact _contact;
        
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
        private void OkButton_Click(object sender, EventArgs e)
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
    }
}
