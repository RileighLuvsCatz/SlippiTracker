class Match {
    int Id { get; set; }
    DateTime Date { get; set; }
    string Stage { get; set; }
    int DurationSeconds { get; set; }
    List<Player> Players { get; set; }
}