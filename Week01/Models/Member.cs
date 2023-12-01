using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01.Models
{
    public class Member
    {
        private int _id;
        private string? _name;
        private string? _surname;
        private List<Book>? _books;

        public Member()
        {
            _books = new List<Book>();
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public List<Book> Books
        {
            get => _books;
            set => _books = value;
        }

    }
}
