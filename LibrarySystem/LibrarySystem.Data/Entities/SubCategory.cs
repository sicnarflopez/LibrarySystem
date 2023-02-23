using LibrarySystem.Logic.Services.Interfaces;

namespace LibrarySystem.Data.Entities
{
    public class SubCategory : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
