using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{

    class Transaction
    {
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime Date { get; set; }
    }
}