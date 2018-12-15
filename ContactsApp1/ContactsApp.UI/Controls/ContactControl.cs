using System;
using System.Drawing;
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
            BurthdayDateTimePicker.Value = (System.DateTime)contact.DateOfBirthday;
            PhoneTextBox.Text = contact.Phone;
            EmailTextBox.Text = contact.Email;
            VkcomTextBox.Text = contact.VkId;

        }

        private void PhoneTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (!Contact.PhoneRegex.IsMatch(PhoneTextBox.Text))
            {
                var tooltip = new ToolTip();
                PhoneTextBox.BackColor = Color.Red;
                tooltip.SetToolTip(this.PhoneTextBox, "номер телефона +7000000000 или 80000000000");
            }
            
        }
    }
}