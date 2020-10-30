using System;

namespace ContactsAppBLL
{
    public class Person
    {
        private string _surname;
        private string _name;
        private int _age;
        private string _phone;
        private string _eMail;
        private string _vkPage;
        public string Label;

        private bool UpperSymbolsCorrect(string _inComming)
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
                else if (UpperSymbolsCorrect(value))
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
                else if (UpperSymbolsCorrect(value))
                {
                    Label = "Заполните корректно поле имя";
                }
                else
                {
                    _name = value;
                }
            }
        }
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

        private Boolean IsSymbolContains(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {

                if (char.IsLetter(input[i]))
                {
                    return true;
                }

            }

            return false;
        }
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
