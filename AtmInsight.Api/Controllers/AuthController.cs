using AtmInsight.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AtmInsight.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService) => _authService = authService;

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto login)
    {
        var token = await _authService.LoginAsync(login.Username, login.Password);

        if (token == null) return Unauthorized("Credenciales inválidas");

        return Ok(new { Token = token });
    }
}

public record LoginDto(string Username, string Password);