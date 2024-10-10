using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Book
    {
        public string name;
        public string author;
        public int year;
        public void displayInfo(string _name, string _author, int _year)
        {
            name = _name;
            author = _author;
            year = _year;
            Console.WriteLine($"Name:{name}\nAuthor:{author}\nYear:{year}");
        }
    }
}
