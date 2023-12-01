using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01.Models
{
    public class WrittenWork
    {
        private int id;
        private string? name;
        private string? author;


        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }


    }
}
