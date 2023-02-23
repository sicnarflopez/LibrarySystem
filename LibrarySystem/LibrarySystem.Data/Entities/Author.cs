using LibrarySystem.Logic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Entities
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public List<Book> Books { get; set; }
    }
}
