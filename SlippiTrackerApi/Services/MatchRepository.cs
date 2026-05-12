using System.Text.Json;


class MatchRepository {
    private readonly List<Match> _matches;

    public MatchRepository(IwebHostEnvironment env) {
        var path = Path.Combine(env.ContentRootPath, "Data", "replays.json");
        string jsonString = File.ReadAllText(path);
        _matches = JsonSerializer.Deserialize<List<Match>>(jsonString);
    }
        
    public List<Match> getAll() {
        return matches;
    }

    public List<Match> getCompletedMatches() {
        return matches.Where(m => m.Completed).ToList();
    }

    public Match getMatchByID(int id) {
        return matches.Where(m => m.Id == id).FirstOrDefault();
    }

    public List<Match> getMatchesByCharacter(string character) {
        if (character == null) {
            return null;
        }
        return matches.Where(m => m.Players.Any(p => p.Character == character)).ToList();
    }

    public List<Match> getMatchesByStage(string stage) {
        if (stage == null) {
            return null;
        }
        return matches.Where(m => m.Stage == stage).ToList();
    }
}