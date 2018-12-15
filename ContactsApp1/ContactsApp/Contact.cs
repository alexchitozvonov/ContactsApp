using System;
using System.Text.RegularExpressions;

namespace ContactsApp
{
    /// <summary>
    /// Контакт.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Регулярка для телефона.
        /// </summary>
        private static readonly Regex PhoneRegex = new Regex(@"[+7|8]\d{10}");

        /// <summary>
        /// Регулярка для e-mail.
        /// </summary>
        private static readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _dateOfBirthday;

        /// <summary>
        /// E-mail.
        /// </summary>
        private string _email;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Id Вконтакте.
        /// </summary>
        public string VkId { get; set; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime DateOfBirthday
        {
            get => _dateOfBirthday;
            set
            {
                if (value.Date > DateTime.Now) //DateTime.Now
                    throw new ArgumentException("Дата не должна быть больше " + DateTime.Today.ToShortDateString());

                if (value.Date < DateTime.Now.AddYears(-120))
                    throw new ArgumentException("Дата не может быть меньше " + DateTime.Today.AddYears(-120));

                _dateOfBirthday = value;
            }
        }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя не может быть пустым");

                if (value.Length >= 20)
                    throw new ArgumentException("Имя не может быть больше 20 символов");

                _name = value;
            }
        }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Фамилия не может быть пустой");

                if (value.Length >= 40)
                    throw new ArgumentException("Фамилия не может быть больше 40 символов");

                _surname = value;
            }
        }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string Phone
        {
            get => _phone;
            set
            {
                if (!PhoneRegex.IsMatch(value))
                    throw new ArgumentException("Формат телефона не соответствует формату");

                _phone = value;
            }
        }

        /// <summary>
        /// E-mail.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (!EmailRegex.IsMatch(value))
                    throw new ArgumentException("Формат E-mail не соответствует формату");


                _email = value;
            }
        }
        public Contact(string name, string surname, DateTime burthday,
            string phone, string email, string VkId)
        {
            this.Email = email;
            Name = name;
            Surname = surname;
            DateOfBirthday = burthday;
            Phone = phone;
            this.VkId = VkId; 
        }

        /// <summary>
        /// Представляет объект в виде строки.
        /// </summary>
        /// <returns>Строка, представляющая объект.</returns>
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}