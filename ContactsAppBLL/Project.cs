using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppBLL
{
    public class Project
    {
        /// <summary>
        /// свойство для создания новых контактов
        /// </summary>
        public List<Contact> Persons { get; set; } = new List<Contact>();
    }
}
