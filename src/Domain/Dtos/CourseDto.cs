using src.Domain.Models;

namespace src.Domain.Dtos;

public record CourseDto(Course course)
{

    public long? Id { get; set; } = course.Id;

    public string? Name { get; set; } = course.Name;


    public string? Description { get; set; } = course.Description;


    public string? Syllabus { get; set; } = course.Syllabus;

    public int? TotalHours { get; set; } = course.TotalHours;

    public int? GoalPoint { get; set; } = course.GoalPoint;
}
