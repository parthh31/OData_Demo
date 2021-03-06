using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData_Demo.Models;

namespace OData_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly DataContext _context;

        public TestController(DataContext context)
        {
            _context = context;
        }

        // GET: api/BookCategory
        [HttpGet]
        [CustomEnableQuery(PageSize = 2)]
        public IQueryable<BookCategory> GetBooks()
        {
            return _context.BookCategories;
        }

        [HttpGet("{id}")]
        [EnableQuery]
        public SingleResult<BookCategory> GetBook(int id)
        {
            IQueryable<BookCategory> result = _context.BookCategories.Where(x => x.Id == id);
            return SingleResult.Create(result);
        }
    }
}