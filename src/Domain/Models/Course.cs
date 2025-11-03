using src.Domain.Dtos;

namespace src.Domain.Models;

public class Course(CourseDto courseDto)
{
    public long Id { get; set; } = courseDto.Id ?? 0;

    public string Name { get; set; } = courseDto.Name ?? string.Empty;
    
    public string Description { get; set; } = courseDto.Description ?? string.Empty;

    public string Syllabus { get; set; } = courseDto.Syllabus ?? string.Empty;

    public int TotalHours { get; set; } = courseDto.TotalHours ?? 0;

    public int GoalPoint { get; set; } = courseDto.GoalPoint ?? 0;

    public void Update(CourseDto courseDto)
    {
        if (courseDto.Name != null)
        {
            Name = courseDto.Name;
        }

        if (courseDto.Description != null)
        {
            Description = courseDto.Description;
        }

        if (courseDto.Syllabus != null)
        {
            Syllabus = courseDto.Syllabus;
        }

        if (courseDto.TotalHours.HasValue)
        {
            TotalHours = courseDto.TotalHours.Value;
        }

        if (courseDto.GoalPoint.HasValue)
        {
            GoalPoint = courseDto.GoalPoint.Value;
        }
    }
}
