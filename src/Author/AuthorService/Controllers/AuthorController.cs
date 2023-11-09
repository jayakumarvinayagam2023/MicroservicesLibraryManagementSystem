

using LibraryManagement.Application;
using LibraryManagement.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers;

[ApiController]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _AuthorRepository;

    public AuthorController(IAuthorService AuthorRepository)
    {
        _AuthorRepository = AuthorRepository;
    }

    [HttpGet]
    [Route("api/authors")]
    public async Task<IActionResult> GetAuthorAsync()
    {
        return Ok(await _AuthorRepository.GetAuthorAsync());
    }

    [HttpGet]   
    [Route("api/authors/{id}")]
    public async Task<IActionResult> GetAuthorAsync(Guid id)
    {
        return Ok(await _AuthorRepository.GetAuthorAsync(id));
    }

    [HttpPost]
    [Route("api/authors")]
    public async Task<IActionResult> CreateAuthorAsync([FromBody] Author Author)
    {
        return Ok(await _AuthorRepository.CreateAuthorAsync(Author));
    }

    [HttpPut]
    [Route("api/authors/{id}")]
    public async Task<IActionResult> CreateAuthorAsync(Guid id, [FromBody] Author Author)
    {
        return Ok(await _AuthorRepository.UpdateAuthorAsync(id, Author));
    }

    [HttpDelete]
    [Route("api/authors/{id}")]
    public async Task<IActionResult> RemoveAuthorAsync(Guid id)
    {
        return Ok(await _AuthorRepository.RemoveAuthorAsync(id));
    }
}