using System.Collections.Generic;

namespace OData_Demo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public ICollection<Book> Books { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}