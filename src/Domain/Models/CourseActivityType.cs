using src.Domain.Dtos;

namespace src.Domain.Models;

public class CourseActivityType(CourseActivityTypeDto courseActivityTypeDto)
{
    public long Id { get; set; } = courseActivityTypeDto.Id ?? 0;


    public string Type { get; set; } = courseActivityTypeDto.Type ?? string.Empty;
}
