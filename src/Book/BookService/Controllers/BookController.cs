using BookService.Domain;
using LibraryManagement.Application;
using Microsoft.AspNetCore.Mvc;

namespace BookService.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly ILogger<BookController> _logger;
    private readonly IBookService _bookRepository;
    public BookController(ILogger<BookController> logger, IBookService bookRepository)
    {
        _logger = logger;
        _bookRepository = bookRepository;
    }
    
    [HttpGet]
    [Route("api/books")]
    public async Task<IActionResult> GetBookAsync()
    {
        return Ok(await _bookRepository.GetBookAsync());
    }

    [HttpGet]   
    [Route("api/books/{id}")]
    public async Task<IActionResult> GetBookAsync(Guid id)
    {
        return Ok(await _bookRepository.GetBookAsync(id));
    }

    [HttpGet]   
    [Route("api/books/isbn/{isbn}")]
    public async Task<IActionResult> GetBookByISBNAsync(string isbn)
    {
        return Ok(await _bookRepository.GetUsersByISBN(isbn));
    }

    [HttpGet]   
    [Route("api/books/status/{statusId}")]
    public async Task<IActionResult> GetBookByStatusAsync(int statusId)
    {
        return Ok(await _bookRepository.GetUsersByStatus((BookStatus)statusId));
    }

    [HttpPost]
    [Route("api/books")]
    public async Task<IActionResult> CreateBookAsync([FromBody] Book book)
    {
        return Ok(await _bookRepository.CreateBookAsync(book));
    }

    [HttpPut]
    [Route("api/books/{id}")]
    public async Task<IActionResult> CreateBookAsync(Guid id, [FromBody] Book book)
    {
        return Ok(await _bookRepository.UpdateBookAsync(id, book));
    }

    [HttpDelete]
    [Route("api/books/{id}")]
    public async Task<IActionResult> RemoveBookAsync(Guid id)
    {
        return Ok(await _bookRepository.RemoveBookAsync(id));
    }

    [HttpPut]
    [Route("api/books/borrowing")]
    public async Task<IActionResult> BorrowingBookAsync(Guid id, [FromBody] Book book)
    {
        return Ok();
    }

    [HttpPut]
    [Route("api/books/returning")]
    public async Task<IActionResult> ReturningBookAsync(Guid id, [FromBody] Book book)
    {
        return Ok();
    }

}
