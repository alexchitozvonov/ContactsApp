using System;
using System.Windows.Forms;

namespace ContactsApp.UI.Controls
{
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        private void BurthdayLabel_Click(object sender, EventArgs e)
        {
        }

        public void UpdateData(Contact contact)
        {
            SurnameTextBox.Text = contact.Surname; 
            NameTextBox.Text = contact.Name;
            BurthdayDateTimePicker.Value = contact.DateOfBirthday;
            PhoneTextBox.Text = contact.Phone;
            EmailTextBox.Text = contact.Email;
            VkcomTextBox.Text = contact.VkId;

        }
    }
}