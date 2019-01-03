﻿using System;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Тесты для Contact.
    /// </summary>
    [TestFixture]
    public class ContactTest
    {

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

        [Test(Description = "Тестирование метода ToString().")]
        public void TestToString()
        {
            var name = "Name";
            var surname = "Surname";
            var expected = $"{name} {surname}";

            var contact = new Contact();
            contact.Name = name;
            contact.Surname = surname;
            var actual = contact.ToString();

            Assert.AreEqual(expected, actual, "Contact->ToString() возвращает неправильное значение.");
        }

        [Test(Description = "Присваивание верной DateOfBirthday.")]
        public void TestDateOfBirthday_CorrectValue()
        {
            var expected = new DateTime(1997, 05, 06);
            
            var contact = new Contact();
            contact.DateOfBirthday = expected;
            var actual = contact.DateOfBirthday;

            Assert.AreEqual(expected,actual,"Contact->DateOfBirthday возвращает неправильное значение.");
        }

        [Test(Description = "Присваивание DateOfBirthday будущего времени.")]
        public void TestDateOfBirthday_FutureValue()
        {
            var wrontDateTime = DateTime.Now.AddDays(1);

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.DateOfBirthday = wrontDateTime; },
                "Contact->DateOfBirthday не возвращает исключение при дате больше Now.");
        }

        [Test(Description = "Присваивание DateOfBirthday -121 год от текущей даты.")]
        public void TestDateOfBirthday_MinDate()
        {
            var wrontDateTime = DateTime.Now.AddYears(-121);

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.DateOfBirthday = wrontDateTime; },
                "Contact->DateOfBirthday не возвращает исключение при дате больше 120 года.");
        }
        
        [Test(Description = "Присваивание Name корректного значения.")]
        public void TestName_CorrectValue()
        {
            var expected = "Александр";

            var contact = new Contact();
            contact.Name = expected;
            var actual = contact.Name;

            Assert.AreEqual(expected, actual, "Contact->Name возвращает неправильное значение.");
        }

        [Test(Description = "Присваивание Name null значения.")]
        public void TestName_NullValue()
        {
            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Name = null; },
                "Contact->Name не возвращает исключение при пустой строке.");
        }

        [Test(Description = "Присваивание Name пустого значения.")]
        public void TestName_WhiteSpaceValue()
        {
            var whitespace = " ";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Name = whitespace; },
                "Contact->Name не возвращает исключение при пустой строке с пробелом.");
        }

        [Test(Description = "Присваивание Name слишком длинного значения.")]
        public void TestName_LongValue()
        {
            var longStr = "IvanInvanIvanIvanIvan";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Name = longStr; },
                "Contact->Name не возвращает исключение при длинной строке.");
        }

        [Test(Description = "Присваивание Surname корректного значения.")]
        public void TestSurname_CorrectValue()
        {
            var expected = "Петров";

            var contact = new Contact();
            contact.Surname = expected;
            var actual = contact.Surname;

            Assert.AreEqual(expected, actual, "Contact->Surname возвращает неправильное значение.");
        }

        [Test(Description = "Присваивание Surname null значения.")]
        public void TestSurname_NullValue()
        {
            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Surname = null; },
                "Contact->Surname не возвращает исключение при пустой строке.");
        }

        [Test(Description = "Присваивание Surname пустого значения.")]
        public void TestSurname_WhiteSpaceValue()
        {
            var whitespace = " ";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Surname = whitespace; },
                "Contact->Surname не возвращает исключение при пустой строке с пробелом.");
        }

        [Test(Description = "Присваивание Surname длинного значения.")]
        public void TestSurname_LongValue()
        {
            var longStr = "IvanInvanIvanIvanIvanIvanInvanIvanIvanIvan";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Surname = longStr; },
                "Contact->Surname не возвращает исключение при длинной строке.");
        }

        [Test(Description = "Присваивание VkId корректного значения.")]
        public void TestVkId_CorrectValue()
        {
            var expected = "test_vk";

            var contact = new Contact();
            contact.VkId = expected;
            var actual = contact.VkId;

            Assert.AreEqual(expected, actual, "Contact->VkId возвращает неправильное значение.");
        }

        [Test(Description = "Присваивание Phone корректного значения.")]
        public void TestPhone_CorrectValue()
        {
            var expected = "+79991234567";

            var contact = new Contact();
            contact.Phone = expected;
            var actual = contact.Phone;

            Assert.AreEqual(expected, actual, "Contact->Phone возвращает неправильное значение.");
        }

        [Test(Description = "Присваивание Phone значения, где первый символ -.")]
        public void TestPhone_IncorrectFirst()
        {
            var num = "-19991234567";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Phone = num; },
                "Contact->Phone не возвращает исключение при первом символе в строке.");
        }

        [Test(Description = "Присваивание Phone значения с буквой.")]
        public void TestPhone_IncorrectSymbol()
        {
            var num = "+799912E4567";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Phone = num; },
                "Contact->Phone не возвращает исключение при букве в строке.");
        }

        [Test(Description = "Присваивание Phone короткого значения.")]
        public void TestPhone_ShortLength()
        {
            var num = "+7996938";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Phone = num; },
                "Contact->Phone не возвращает исключение при вводе короткого номера.");
        }

        [Test(Description = "Присваивание Phone длинного значения.")]
        public void TestPhone_LongLength()
        {
            var num = "+799693811111111";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Phone = num; },
                "Contact->Phone не возвращает исключение при вводе длинного номера.");
        }

        [Test(Description = "Присваивание Email корректного значения.")]
        public void TestEmail_CorrectValue()
        {
            var expected = "ivanov.i.i@mail.ru";

            var contact = new Contact();
            contact.Email = expected;
            var actual = contact.Email;

            Assert.AreEqual(expected, actual, "Contact->Email возвращает неправильное значение.");
        }

        [Test(Description = "Присваивание Email значения с двумя @.")]
        public void TestEmail_IncorrectA()
        {
            var email = "ivanov.i.i@@mail.ru";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Email = email; },
                "Contact->Email не возвращает исключение при присвоении email с двумя @.");
        }

        [Test(Description = "Присваивание Email значения без доменной зоны.")]
        public void TestEmail_IncorrectDomainZone()
        {
            var email = "ivanov.i.i@mail";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Email = email; },
                "Contact->Email не возвращает исключение при присвоении email без доменной зоны.");
        }

        [Test(Description = "Присваивание Email значения без домена.")]
        public void TestEmail_WithoutDomain()
        {
            var email = "ivanov.i.i@";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Email = email; },
                "Contact->Email не возвращает исключение при присвоении email без домена.");
        }

        [Test(Description = "Присваивание Email значения без логина.")]
        public void TestEmail_WithoutLogin()
        {
            var email = "@mail.ru";

            var contact = new Contact();

            Assert.Throws<ArgumentException>(() => { contact.Email = email; },
                "Contact->Email не возвращает исключение при присвоении email без логина.");
        }
    }
}