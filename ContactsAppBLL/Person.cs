using System;

namespace ContactsAppBLL
{
    /// <summary>
    /// Класс человека, хранит базовую инфомацию о контакте
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя
        /// </summary>
        private string _name;

        /// <summary>
        /// Дата рождения
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// Телефон
        /// </summary>
        private string _phone;

        /// <summary>
        /// Электронная почта
        /// </summary>
        private string _eMail;

        /// <summary>
        /// Страница в социальной сети
        /// </summary>
        private string _vkPage;

        /// <summary>
        /// Строка ошибки при вводе данных
        /// </summary>
        public string Label;

        public int CountError;
        /// <summary>
        /// Проверяет строку на правильность регистра букв, создан для полей имени и фамилии
        /// </summary>
        /// <param name="inComming">Входящая строка для проверки регистра</param>
        /// <returns>отправляет true если строка не подходит</returns>
        private bool UpperSymbolsUnCorrect(string inComming)
        {
            if (inComming != null)
            {
                for (var i = 0; i < inComming.Length; i++)
                {
                    if (i == 0)
                    {
                        if (char.IsLower(inComming[i]))
                        {
                            return true;
                        }
                    }

                    if (i >= 1)
                    {
                        if (char.IsUpper(inComming[i]))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                Label = null;
                if (value == String.Empty)
                {
                    CountError++;
                    Label = "Заполните поле фамилия";
                    //throw new ArgumentException("Заполните параметр Фамилия");
                }
                else if (UpperSymbolsUnCorrect(value))
                {
                    CountError++;
                    Label = "Заполните корректно поле фамилия";
                }
                else
                {
                    Label = null;
                    _surname = value;
                }
            }
        }
        /// <summary>
        /// имя
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Label = null;
                if (value == String.Empty)
                {
                    CountError++;
                    Label = "Заполните поле Имя";
                    //  throw new ArgumentException("Заполните параметр Имя");
                }
                else if (UpperSymbolsUnCorrect(value))
                {
                    CountError++;
                    Label = "Заполните корректно поле имя";
                }
                else
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDay
        {
            get { return _birthday; }
            set
            {
                if (DateTime.Today < value)
                {
                    CountError++;
                    Label = "Дата рождения не может быть в будущем";
                }
                else
                {
                    _birthday = value;
                }
            }
        }


        /// <summary>
        /// Метод проверки строки на наличие в ней букв
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private Boolean IsSymbolContains(string input)
        {
            if (input != null)
            {
                for (int i = 0; i < input.Length; i++)
                {

                    if (char.IsLetter(input[i]))
                    {
                        return true;
                    }

                }
            }

            return false;
        }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set
            {
                Label = null;
                if (value == String.Empty)
                {
                    CountError++;
                    Label = "Заполните параметр Телефон";
                    // throw new ArgumentException("Заполните параметр Телефон");
                }
                else if (IsSymbolContains(value))
                {
                    CountError++;
                    Label = "Параметр Телефон должен содержать только цифры и знак +";
                    //throw new ArgumentException("Параметр Телефон должен содержать только цифры и знак +");
                }
                else
                {
                    _phone = value;
                }
            }
        }
        /// <summary>
        /// страница в социальных сетях
        /// </summary>
        public string VkPage
        {
            get { return _vkPage; }
            set
            {
                Label = null;
                if (value == String.Empty)
                {
                    CountError++;
                    Label = "Заполни параметр vk.com";
                    //throw new ArgumentException("Заполните параметр vk.com");
                }
                else
                {
                    _vkPage = value;
                }
            }
        }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string EMail
        {
            get { return _eMail; }
            set
            {
                Label = null;
                if (value == String.Empty)
                {
                    CountError++;
                    Label = "Заполни параметр EMail";
                    //throw new ArgumentException("Заполните параметр Email");
                }

                _eMail = value;
            }
        }
    }
}
