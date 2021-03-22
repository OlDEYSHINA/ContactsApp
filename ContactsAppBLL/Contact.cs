using System;

namespace ContactsAppBLL
{
    /// <summary>
    /// Класс человека, хранит базовую инфомацию о контакте
    /// </summary>
    public class Contact
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
        /// Электронная почта
        /// </summary>
        private string _eMail;

        /// <summary>
        /// Страница в социальной сети
        /// </summary>
        private string _vkPage;

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
        /// Возвращает и задает параметр Фамилия
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Заполните параметр Фамилия");
                }
                else if (UpperSymbolsUnCorrect(value))
                {
                    throw new ArgumentException("Заполните корректно поле фамилия");
                }
                else
                {
                    _surname = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает параметр имя
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Заполните параметр Имя");
                }
                else if (UpperSymbolsUnCorrect(value))
                {
                    throw new ArgumentException("Заполните корректно поле имя");
                }
                else
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает параметр Дата рождения
        /// </summary>
        public DateTime BirthDay
        {
            get { return _birthday; }
            set
            {
                if (DateTime.Today < value)
                {
                    throw new ArgumentException("Дата рождения не может быть в будущем");
                }
                else
                {
                    _birthday = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает параметр Телефон
        /// </summary>
        public PhoneNumber PhoneNumber { get; set; } = new PhoneNumber();

        /// <summary>
        /// Возвращает и задает параметр страница в социальных сетях
        /// </summary>
        public string VkPage
        {
            get { return _vkPage; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Заполните параметр vk.com");
                }
                else
                {
                    _vkPage = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает параметр Электронная почта
        /// </summary>
        public string EMail
        {
            get { return _eMail; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Заполните параметр Email");
                }
                else
                {
                    _eMail = value;
                }
            }
        }
    }
}
