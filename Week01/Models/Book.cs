using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01.Models
{
    public class Book : WrittenWork
    {
        private string? pageCount;
        private string? language;
        private string? genre;

        public string PageCount
        {
            get => pageCount;
            set => pageCount = value;
        }

        public string Language
        {
            get => language;
            set => language = value;
        }

        public string Genre
        {
            get { return genre; }
            set => genre = value;
        }
    }
}
