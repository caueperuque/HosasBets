using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Security.Claims;
using HosasBets.Odds.Repository;

namespace HosasBets.Odds.Controllers;

[ApiController]
[Route("[controller]")]
public class OddController : Controller
{
    private readonly IOddRepository _repository;
    public OddController(IOddRepository repository)
    {
        _repository = repository;
    }

    [HttpPatch("{MatchId:int}/{TeamId:int}/{BetValue}")]

    public IActionResult Patch(int MatchId, int TeamId, string BetValue)
    {
        try
        {
            return Ok(_repository.Patch(MatchId, TeamId, BetValue));
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}