using Microsoft.AspNetCore.Mvc;
using SlippiTrackerApi.Models;
using SlippiTrackerApi.Services;

namespace SlippiTrackerApi.Controllers;

[ApiController]
[Route("matches")]
public class MatchesController : ControllerBase
{
    private readonly MatchRepository _repository;

    public MatchesController(MatchRepository repository)
    {
        _repository = repository;
    }


    /// <summary>Get all matches, with optional filters for character and stage.</summary>
    /// <param name="character">Filter matches by character.</param>
    /// <param name="stage">Filter matches by stage.</param>
    /// <returns>A list of matches that match the specified filters.</returns>
    [HttpGet]
    public IActionResult GetAll([FromQuery] string? character, [FromQuery] string? stage)
    {
        // your logic here
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        // your logic here
    }
}