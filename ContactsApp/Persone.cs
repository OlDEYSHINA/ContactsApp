using System;

namespace ContactsApp
{
    public class Person
    {
        private string _surname;
        private string _name;
        private int _age;
        private string _phone;
        private string _eMail;
        private string _vkPage;

        public string Surname
        {
            get { return _surname;}
            set
            {
                if (Surname == String.Empty)
                {
                    throw new ArgumentException("Заполните параметр Фамилия");
                }
                else
                {
                    _surname = Surname;
                }
            }
        }

        private string Name
        {
            get { return _name;}
            set
            {
                if (Name == String.Empty)
                {
                    throw new ArgumentException("Заполните параметр Имя");
                }
                else
                {
                    _name = Name;
                }
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {

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
            foreach (char c in input)
            {
                if (char.IsLetter(c))
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
                if (Phone == String.Empty)
                {
                    throw new ArgumentException("Заполните параметр Телефон");
                }
                else if(IsSymbolContains(Phone))
                {
                    throw new ArgumentException("Параметр Телефон должен содержать только цифры и знак +");
                }
                else
                {
                    _phone = Phone;
                }
            }
        }

        public string VkPage
        {
            get { return _vkPage;}
            set
            {
                if (Name == String.Empty)
                {
                    throw new ArgumentException("Заполните параметр vk.com");
                }
                else
                {
                    _name = Name;
                }
            }
        }

        

    }
}