using System;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Тесты для Contact.
    /// </summary>
    [TestFixture]
    public class ContactTest
    {
        /// <summary>
        /// Тестовый контакт.
        /// </summary>
        private readonly Contact _contact = new Contact();

        /// <summary>
        /// Тестирование конструктора.
        /// </summary>
        [Test(Description = "Тестирование конструктора.")]
        public void TestConstructor()
        {
            var name = "Name";
            var surname = "Surname";
            var birthday = DateTime.Now.AddDays(-18);
            var phone = "+79961726188";
            var email = "ivanov@email.com";
            var vk = "id0";

            var contact = new Contact(name,surname,birthday, phone, email, vk);
            
            Assert.AreEqual(name, contact.Name, "Contact() Конструктор не присваивает Name.");
            Assert.AreEqual(surname, contact.Surname, "Contact() Конструктор не присваивает Surname.");
            Assert.AreEqual(birthday, contact.DateOfBirthday, "Contact() Конструктор не присваивает DateOfBirthday.");
            Assert.AreEqual(phone, contact.Phone, "Contact() Конструктор не присваивает Phone.");
            Assert.AreEqual(email, contact.Email, "Contact() Конструктор не присваивает Email.");
            Assert.AreEqual(vk, contact.VkId, "Contact() Конструктор не присваивает VkId.");
        }

        /// <summary>
        /// Тестирование метода ToString().
        /// </summary>
        [Test(Description = "Тестирование метода ToString().")]
        public void TestToString()
        {
            var name = "Name";
            var surname = "Surname";
            var expected = $"{name} {surname}";

            _contact.Name = name;
            _contact.Surname = surname;
            var actual = _contact.ToString();

            Assert.AreEqual(expected, actual, "Contact->ToString() возвращает неправильное значение.");
        }

        /// <summary>
        /// Присваивание верной DateOfBirthday.
        /// </summary>
        [Test(Description = "Присваивание верной DateOfBirthday.")]
        public void TestDateOfBirthday_CorrectValue()
        {
            var expected = new DateTime(1997, 05, 06);

            _contact.DateOfBirthday = expected;
            var actual = _contact.DateOfBirthday;

            Assert.AreEqual(expected,actual,"Contact->DateOfBirthday возвращает неправильное значение.");
        }

        /// <summary>
        /// Присваивание DateOfBirthday будущего времени.
        /// </summary>
        [Test(Description = "Присваивание DateOfBirthday будущего времени.")]
        public void TestDateOfBirthday_FutureValue()
        {
            var wrontDateTime = DateTime.Now.AddDays(1);

            Assert.Throws<ArgumentException>(() => { _contact.DateOfBirthday = wrontDateTime; },
                "Contact->DateOfBirthday не возвращает исключение при дате больше Now.");
        }

        /// <summary>
        /// Присваивание DateOfBirthday -121 год от текущей даты.
        /// </summary>
        [Test(Description = "Присваивание DateOfBirthday -121 год от текущей даты.")]
        public void TestDateOfBirthday_MinDate()
        {
            var wrontDateTime = DateTime.Now.AddYears(-121);

            Assert.Throws<ArgumentException>(() => { _contact.DateOfBirthday = wrontDateTime; },
                "Contact->DateOfBirthday не возвращает исключение при дате больше 120 года.");
        }

        /// <summary>
        /// Присваивание Name корректного значения.
        /// </summary>
        [Test(Description = "Присваивание Name корректного значения.")]
        public void TestName_CorrectValue()
        {
            var expected = "Александр";

            _contact.Name = expected;
            var actual = _contact.Name;

            Assert.AreEqual(expected, actual, "Contact->Name возвращает неправильное значение.");
        }

        /// <summary>
        /// Присваивание Name null значения.
        /// </summary>
        [Test(Description = "Присваивание Name null значения.")]
        public void TestName_NullValue()
        {
            Assert.Throws<ArgumentException>(() => { _contact.Name = null; },
                "Contact->Name не возвращает исключение при пустой строке.");
        }

        /// <summary>
        /// Присваивание Name пустого значения.
        /// </summary>
        [Test(Description = "Присваивание Name пустого значения.")]
        public void TestName_WhiteSpaceValue()
        {
            var whitespace = " ";

            Assert.Throws<ArgumentException>(() => { _contact.Name = whitespace; },
                "Contact->Name не возвращает исключение при пустой строке с пробелом.");
        }

        /// <summary>
        /// Присваивание Name слишком длинного значения.
        /// </summary>
        [Test(Description = "Присваивание Name слишком длинного значения.")]
        public void TestName_LongValue()
        {
            var longStr = "IvanInvanIvanIvanIvan";

            Assert.Throws<ArgumentException>(() => { _contact.Name = longStr; },
                "Contact->Name не возвращает исключение при длинной строке.");
        }

        /// <summary>
        /// Присваивание Surname корректного значения.
        /// </summary>
        [Test(Description = "Присваивание Surname корректного значения.")]
        public void TestSurname_CorrectValue()
        {
            var expected = "Петров";

            _contact.Surname = expected;
            var actual = _contact.Surname;

            Assert.AreEqual(expected, actual, "Contact->Surname возвращает неправильное значение.");
        }

        /// <summary>
        /// Присваивание Surname null значения.
        /// </summary>
        [Test(Description = "Присваивание Surname null значения.")]
        public void TestSurname_NullValue()
        {
            Assert.Throws<ArgumentException>(() => { _contact.Surname = null; },
                "Contact->Surname не возвращает исключение при пустой строке.");
        }

        /// <summary>
        /// Присваивание Surname пустого значения.
        /// </summary>
        [Test(Description = "Присваивание Surname пустого значения.")]
        public void TestSurname_WhiteSpaceValue()
        {
            var whitespace = " ";

            Assert.Throws<ArgumentException>(() => { _contact.Surname = whitespace; },
                "Contact->Surname не возвращает исключение при пустой строке с пробелом.");
        }

        /// <summary>
        /// Присваивание Surname длинного значения.
        /// </summary>
        [Test(Description = "Присваивание Surname длинного значения.")]
        public void TestSurname_LongValue()
        {
            var longStr = "IvanInvanIvanIvanIvanIvanInvanIvanIvanIvan";

            Assert.Throws<ArgumentException>(() => { _contact.Surname = longStr; },
                "Contact->Surname не возвращает исключение при длинной строке.");
        }

        /// <summary>
        /// Присваивание VkId корректного значения.
        /// </summary>
        [Test(Description = "Присваивание VkId корректного значения.")]
        public void TestVkId_CorrectValue()
        {
            var expected = "test_vk";

            _contact.VkId = expected;
            var actual = _contact.VkId;

            Assert.AreEqual(expected, actual, "Contact->VkId возвращает неправильное значение.");
        }

        /// <summary>
        /// Присваивание Phone корректного значения.
        /// </summary>
        [Test(Description = "Присваивание Phone корректного значения.")]
        public void TestPhone_CorrectValue()
        {
            var expected = "+79991234567";

            _contact.Phone = expected;
            var actual = _contact.Phone;

            Assert.AreEqual(expected, actual, "Contact->Phone возвращает неправильное значение.");
        }

        /// <summary>
        /// Присваивание Phone значения, где первый символ -.
        /// </summary>
        [Test(Description = "Присваивание Phone значения, где первый символ -.")]
        public void TestPhone_IncorrectFirst()
        {
            var num = "-19991234567";

            Assert.Throws<ArgumentException>(() => { _contact.Phone = num; },
                "Contact->Phone не возвращает исключение при первом символе в строке.");
        }

        /// <summary>
        /// Присваивание Phone значения с буквой.
        /// </summary>
        [Test(Description = "Присваивание Phone значения с буквой.")]
        public void TestPhone_IncorrectSymbol()
        {
            var num = "+799912E4567";

            Assert.Throws<ArgumentException>(() => { _contact.Phone = num; },
                "Contact->Phone не возвращает исключение при букве в строке.");
        }

        /// <summary>
        /// Присваивание Phone короткого значения.
        /// </summary>
        [Test(Description = "Присваивание Phone короткого значения.")]
        public void TestPhone_ShortLength()
        {
            var num = "+7996938";

            Assert.Throws<ArgumentException>(() => { _contact.Phone = num; },
                "Contact->Phone не возвращает исключение при вводе короткого номера.");
        }

        /// <summary>
        /// Присваивание Phone длинного значения.
        /// </summary>
        [Test(Description = "Присваивание Phone длинного значения.")]
        public void TestPhone_LongLength()
        {
            var num = "+799693811111111";

            Assert.Throws<ArgumentException>(() => { _contact.Phone = num; },
                "Contact->Phone не возвращает исключение при вводе длинного номера.");
        }

        /// <summary>
        /// Присваивание Email корректного значения.
        /// </summary>
        [Test(Description = "Присваивание Email корректного значения.")]
        public void TestEmail_CorrectValue()
        {
            var expected = "ivanov.i.i@mail.ru";

            _contact.Email = expected;
            var actual = _contact.Email;

            Assert.AreEqual(expected, actual, "Contact->Email возвращает неправильное значение.");
        }

        /// <summary>
        /// Присваивание Email значения с двумя @.
        /// </summary>
        [Test(Description = "Присваивание Email значения с двумя @.")]
        public void TestEmail_IncorrectA()
        {
            var email = "ivanov.i.i@@mail.ru";

            Assert.Throws<ArgumentException>(() => { _contact.Email = email; },
                "Contact->Email не возвращает исключение при присвоении email с двумя @.");
        }

        /// <summary>
        /// Присваивание Email значения без доменной зоны.
        /// </summary>
        [Test(Description = "Присваивание Email значения без доменной зоны.")]
        public void TestEmail_IncorrectDomainZone()
        {
            var email = "ivanov.i.i@mail";

            Assert.Throws<ArgumentException>(() => { _contact.Email = email; },
                "Contact->Email не возвращает исключение при присвоении email без доменной зоны.");
        }

        /// <summary>
        /// Присваивание Email значения без домена.
        /// </summary>
        [Test(Description = "Присваивание Email значения без домена.")]
        public void TestEmail_WithoutDomain()
        {
            var email = "ivanov.i.i@";

            Assert.Throws<ArgumentException>(() => { _contact.Email = email; },
                "Contact->Email не возвращает исключение при присвоении email без домена.");
        }

        /// <summary>
        /// Присваивание Email значения без логина.
        /// </summary>
        [Test(Description = "Присваивание Email значения без логина.")]
        public void TestEmail_WithoutLogin()
        {
            var email = "@mail.ru";

            Assert.Throws<ArgumentException>(() => { _contact.Email = email; },
                "Contact->Email не возвращает исключение при присвоении email без логина.");
        }
    }
}