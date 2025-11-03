namespace src.Domain.Dtos;

public record CourseActivityDto()
{
    public long? Id { get; set; }


    public int? Score { get; set; }


    public long? ActivityTypeId { get; set; }


    public long? ProfessionalId { get; set; }

    public CourseDto? Course { get; set; }

    public CourseActivityTypeDto? ActivityType { get; set; }


    public ProfessionalDto? Professional { get; set; }
}
