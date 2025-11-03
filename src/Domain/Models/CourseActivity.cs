using src.Domain.Dtos;

namespace src.Domain.Models;

public class CourseActivity(CourseActivityDto courseActivityDto)
{
    public long Id { get; set; } = courseActivityDto.Id ?? 0;

    public int Score { get; set; } = courseActivityDto.Score ?? 0;

    public Course? Course { get; set; } = courseActivityDto.Course != null ? new Course(courseActivityDto.Course) : null;

    public CourseActivityType? ActivityType { get; set; } = courseActivityDto.ActivityType != null ? new CourseActivityType(courseActivityDto.ActivityType) : null;

    public Professional? Professional { get; set; } = courseActivityDto.Professional != null ? new Professional(courseActivityDto.Professional) : null;

    public void UpdateFromDto(CourseActivityDto courseActivityDto)
    {
        if (courseActivityDto.Score.HasValue)
        {
            Score = courseActivityDto.Score.Value;
        }

        if (courseActivityDto.Course != null)
        {
            Course = new Course(courseActivityDto.Course);
        }

        if (courseActivityDto.ActivityType != null)
        {
            ActivityType = new CourseActivityType(courseActivityDto.ActivityType);
        }

        if (courseActivityDto.Professional != null)
        {
            Professional = new Professional(courseActivityDto.Professional);
        }
    }
}
