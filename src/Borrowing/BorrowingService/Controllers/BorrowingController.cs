using LibraryManagement.Application;
using LibraryManagementDomain.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BorrowingService.Controllers;

[ApiController]
public class BorrowingController : ControllerBase
{
    private readonly ILogger<BorrowingController> _logger;
    private readonly IBorrowingService _borrowingService;
    public BorrowingController(ILogger<BorrowingController> logger, IBorrowingService borrowingService)
    {
        _logger = logger;
        _borrowingService = borrowingService;
    } 
    [HttpGet]
    [Route("api/borrowing")]
    public async Task<IActionResult> GetBookAsync()
    {
        return Ok(await _borrowingService.GetBorrowingAsync());
    }

    [HttpGet]   
    [Route("api/borrowing/{id}")]
    public async Task<IActionResult> GetBookAsync(Guid id)
    {
        return Ok(await _borrowingService.GetBorrowingAsync(id));
    }   

    [HttpPost]
    [Route("api/borrowing")]
    public async Task<IActionResult> CreateBorrowing([FromBody] Borrowing borrowing)
    {
        return Ok(await _borrowingService.CreateBorrowingAsync(borrowing));
    }

    [HttpDelete]
    [Route("api/borrowing")]
    public async Task<IActionResult> UpdateBorrowing(Guid id)
    {
        return Ok(await _borrowingService.RemoveBorrowingAsync(id));
    }
}
