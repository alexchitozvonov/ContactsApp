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

      /// <summary>
      /// Обновить данные в полях.
      /// </summary>
      /// <param name="contact"></param>
        public void UpdateData(Contact contact)
        {
            SurnameTextBox.Text = contact.Surname; 
            NameTextBox.Text = contact.Name;
            BurthdayDateTimePicker.Value = (System.DateTime)contact.DateOfBirthday;
            PhoneTextBox.Text = contact.Phone;
            EmailTextBox.Text = contact.Email;
            VkcomTextBox.Text = contact.VkId;

        }

        /// <summary>
        /// Подсказка для телефона при изменении поля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneTextBox_TextChanged_1(object sender, EventArgs e)
        { 
            if (!Contact.PhoneRegex.IsMatch(PhoneTextBox.Text))
            {
                var tooltip = new ToolTip();
                PhoneTextBox.BackColor = Color.FromArgb(255,140,105);
                tooltip.SetToolTip(this.PhoneTextBox, "номер телефона +7000000000 или 80000000000");
            }
            else
            {
                PhoneTextBox.BackColor = Color.White;
            }
            
        }

        /// <summary>
        /// Подсказка для E-mail при изменении поля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Contact.EmailRegex.IsMatch(EmailTextBox.Text))
            {
                var tooltip = new ToolTip();
                EmailTextBox.BackColor = Color.FromArgb(255, 140, 105);
                tooltip.SetToolTip(this.EmailTextBox, "E-mail aaaaaaaaaaaa@mail.com");
            }
            else
            {
                EmailTextBox.BackColor = Color.White;
            }
        }
    }
}