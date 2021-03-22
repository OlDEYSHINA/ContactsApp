using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppBLL
{
    public class PhoneNumber
    {
        private string _number;
        public PhoneNumber() {}
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Заполните параметр Номер телефона");
                }
                else if(IsSymbolContains(value))
                {
                    throw new ArgumentException("Параметр Номер телефона содержит буквы");
                }
                else if (value.Length==11)
                {
                    if (value[0] == '8' && value[1] == '9')
                    {
                        _number = value;
                    }
                    else throw new ArgumentException("Коректный формат Номера телефона 89...");
                }
                else if(value.Length==12)
                {
                    if (value[0] == '+' && value[1] == '7' && value[2] == '9')
                    {
                        _number = value;
                    }
                    else throw new ArgumentException("Коректный формат Номера телефона +79...");
                }
                else
                {
                    throw new ArgumentException("Номер телефона должен иметь длину 11 или 12 символов");
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
    }
}
