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
    public IActionResult GetAll([FromQuery] string? character, [FromQuery] string? stage) {
        List<Match> matches;

        if (character != null && stage != null) { //filter by both character and stage
            matches = _repository.getMatchesByCharacter(character)
                .Where(m => m.Stage == stage)
                .ToList();
        }
        else if (character != null && stage == null) { //filter by character only
            matches = _repository.getMatchesByCharacter(character);
        } else if (stage != null && character == null) { //filter by stage only
            matches = _repository.getMatchesByStage(stage);
        } else { //no filters, return all matches
            matches = _repository.getAll();
        }

        var completedMatches = matches.Where(m => m.Completed).ToList();

        return Ok(completedMatches);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var match = _repository.getMatchByID(id);
        if (match == null || !match.Completed) {
            return NotFound();
        }
        return Ok(match);
    }
}