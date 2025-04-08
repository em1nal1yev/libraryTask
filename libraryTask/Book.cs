using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryTask
{
    class Book
    {
        static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set;  }
        public Book(string name, string authorName, double price)
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorName;
            Price = price;
        }

        public string ShowInfo()
        {
            return $"idsi: {Id}, adi: {Name}, qiymeti: {Price}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
