using Microsoft.AspNetCore.Mvc;
using SlippiTrackerApi.Models;
using SlippiTrackerApi.Services;

namespace SlippiTrackerApi.Controllers;

[ApiController]
[Route("stats")]
public class StatsController : ControllerBase {
    private readonly MatchRepository _repository;

    public StatsController(MatchRepository repository) {
        _repository = repository;
    }

    
    
    
    [HttpGet("characters")]
    public IActionResult GetCharacterStats() {
        // your logic here
    }

    [HttpGet("stages")]
    public IActionResult GetStageStats() {
        // your logic here
    }

    
}