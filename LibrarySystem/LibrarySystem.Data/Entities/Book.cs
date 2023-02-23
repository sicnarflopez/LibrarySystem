using LibrarySystem.Logic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Entities
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SubCategoryId { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
