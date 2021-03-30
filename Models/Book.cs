using System.Collections;
using System.Collections.Generic;

namespace OData_Demo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}