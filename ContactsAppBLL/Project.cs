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
        /// Список для контактов
        /// </summary>
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
