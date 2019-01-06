using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactsApp.UI.Controls
{
    /// <summary>
    /// Создает новый контакт с указанными данными.
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
        }

      /// <summary>
      /// Обновить данные в полях.
      /// </summary>
      /// <param name="contact">Контакт, данные которого будут в полях.</param>
        public void UpdateData(Contact contact)
        {
            if (contact == null)
            {
                SurnameTextBox.Clear();
                NameTextBox.Clear();
                BurthdayDateTimePicker.Value = DateTime.Today;
                PhoneTextBox.Clear();
                EmailTextBox.Clear();
                VkcomTextBox.Clear();
                return;
            }
            SurnameTextBox.Text = contact.Surname; 
            NameTextBox.Text = contact.Name;
            BurthdayDateTimePicker.Value = contact.DateOfBirthday.Date;
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

        /// <summary>
        /// Подсказка для Surname, при изменении поля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.CheckSurname(SurnameTextBox.Text);
                SurnameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                var tooltip = new ToolTip();
                SurnameTextBox.BackColor = Color.FromArgb(255, 140, 105);
                tooltip.SetToolTip(this.SurnameTextBox, exception.Message);
            }
        }

        /// <summary>
        /// Подсказка для Name при изменении поля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.CheckName(NameTextBox.Text);
                NameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                var tooltip = new ToolTip();
                NameTextBox.BackColor = Color.FromArgb(255, 140, 105);
                tooltip.SetToolTip(this.NameTextBox, exception.Message);
            }
        }
    }
}