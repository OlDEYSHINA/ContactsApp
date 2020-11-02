using System;

namespace ContactsAppBLL
{
    public class Person
    {
        private string _surname;
        private string _name;
        private DateTime _birthday;
        private int _age;
        private string _phone;
        private string _eMail;
        private string _vkPage;
        public string Label;
        /// <summary>
        /// Проверяет строку на правильность регистра букв, создан для полей имени и фамилии
        /// </summary>
        /// <param name="_inComming">Входящая строка для проверки регистра</param>
        /// <returns>отправляет true если строка не подходит</returns>
        private bool UpperSymbolsUnCorrect(string _inComming)
        {
            if (_inComming != null)
            {
                for (var i = 0; i < _inComming.Length; i++)
                {
                    if (i == 0)
                    {
                        if (char.IsLower(_inComming[i]))
                        {
                            return true;
                        }
                    }

                    if (i >= 1)
                    {
                        if (char.IsUpper(_inComming[i]))
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
                    Label = "Заполните поле фамилия";
                    //throw new ArgumentException("Заполните параметр Фамилия");
                }
                else if (UpperSymbolsUnCorrect(value))
                {
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
                    Label = "Заполните поле Имя";
                    //  throw new ArgumentException("Заполните параметр Имя");
                }
                else if (UpperSymbolsUnCorrect(value))
                {
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
        public int Age
        {
            get { return _age; }
            set
            {
                Label = null;
                if (value < 0)
                {
                    throw new ArgumentException("Возраст должен быть больше 0, а был" + value);
                }
                else
                {
                    _age = value;
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
                    Label = "Заполните параметр Телефон";
                    // throw new ArgumentException("Заполните параметр Телефон");
                }
                else if (IsSymbolContains(value))
                {
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
                    Label = "Заполни параметр vk.com";
                    //throw new ArgumentException("Заполните параметр vk.com");
                }
                else
                {
                    _name = value;
                }
            }
        }
        /// <summary>
        /// Электронная почта
        /// </summary>
        public string EMail
        {
            get { return _eMail;}
            set
            {
                Label = null;
                if (value == String.Empty)
                {
                    Label = "Заполни параметр EMail";
                    //throw new ArgumentException("Заполните параметр Email");
                }
            }
        }

    }
}
