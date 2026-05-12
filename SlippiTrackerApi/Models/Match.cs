class Match {
    int Id { get; set; }
    DateTime Date { get; set; }
    string Stage { get; set; }
    int DurationSeconds { get; set; }
    bool Completed { get; set; }
    List<Player> Players { get; set; }
    List<StockEvent> StockEvents { get; set; }
}