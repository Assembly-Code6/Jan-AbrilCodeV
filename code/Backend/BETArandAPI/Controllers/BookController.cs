using BETArandDomain;
using BETArandRepo;
using BETArandService;
using Microsoft.AspNetCore.Mvc;

namespace BETArandAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBooks")]
        public IEnumerable<User> Get()
        {
            return BookService.GetUsers();
        }
    }
}
