using Microsoft.AspNetCore.Mvc;

namespace BorrowingService.Controllers;

[ApiController]
[Route("[controller]")]
public class BorrowingController : ControllerBase
{
    private readonly ILogger<BorrowingController> _logger;

    public BorrowingController(ILogger<BorrowingController> logger)
    {
        _logger = logger;
    }    
}
