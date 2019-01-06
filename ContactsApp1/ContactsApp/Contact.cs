using System;
using System.ComponentModel;
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
        public static readonly Regex PhoneRegex = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");

        /// <summary>
        /// Регулярка для e-mail.
        /// </summary>
        public static readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _dateOfBirthday = DateTime.Now.AddYears(-16);

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
        [DefaultValue("2017-12-15T09:46:40.4157638+03:00")]
        public DateTime DateOfBirthday
        {
            get => _dateOfBirthday;
            set
            {
                    if (value.Date > DateTime.Now) 
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
                CheckName(value);

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
                CheckSurname(value);

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
                if (!EmailRegex.IsMatch(value) && value.Length>0)
                    throw new ArgumentException("Формат E-mail не соответствует формату");

                _email = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
            this.Email = "aleksandrr_nnn@gmail.com";
            Name = "Alex";
            Surname = "Chistozvonov";
            DateOfBirthday = DateTime.Now.AddYears(-2);
            Phone = "89039549459";
            this.VkId = "alex_chistozvonov";
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="burthday">День рождение.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="email">E-mail.</param>
        /// <param name="VkId">vk.com.</param>
        public Contact(string name, string surname, DateTime birthday,
            string phone, string email, string VkId)
        {
            this.Email = email;
            Name = name;
            Surname = surname;
            DateOfBirthday = birthday;
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

        /// <summary>
        /// Проверяет имя, в случае ошибки создает исключение.
        /// </summary>
        /// <param name="value">Имя.</param>
        public static void CheckName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Имя не может быть пустым");

            if (value.Length >= 20)
                throw new ArgumentException("Имя не может быть больше 20 символов");
        }

        /// <summary>
        /// Проверяет фамилию, в случае ошибки создает исключение.
        /// </summary>
        /// <param name="value">Фамилия.</param>
        public static void CheckSurname(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Фамилия не может быть пустой");

            if (value.Length >= 50)
                throw new ArgumentException("Фамилия не может быть больше 50 символов");
        }


    }
}