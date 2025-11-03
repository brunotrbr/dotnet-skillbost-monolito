namespace src.Domain.Models;

public class Ranking
{
    public long Id { get; set; }

    public int TotalScore { get; set; }

    public Professional? Professional { get; set; }
}
