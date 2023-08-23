using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibraryApp
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> CheckedOutBooks { get; set; } = new List<Book>();
    }
}