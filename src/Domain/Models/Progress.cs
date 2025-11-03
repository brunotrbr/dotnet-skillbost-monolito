namespace src.Domain.Models;

public record Progress
{
    public long Id { get; set; }

    public string Status { get; set; } = string.Empty;

    public Course? Course { get; set; }

    public Professional? Professional { get; set; }

    public DateTime StatusDate { get; set; }
}
