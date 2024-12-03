using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers;


[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly List<Book> _books = [new()
    {
        BookId = 1,
        BookName = "Life"
    },
    new ()
    {
        BookId = 2,
        BookName = "Lessons"
    },
    new ()
    {   BookId = 3,
        BookName = "Learned"
    }];

    public IEnumerable<Book> GetAll()
    {
        return _books;
    }
}
