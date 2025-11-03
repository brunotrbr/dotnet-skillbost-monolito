namespace src.Domain.Dtos;

public record ProfessionalDto
{

    public long? Id { get; set; }


    public string? Name { get; set; }


    public string? Email { get; set; }

    public string? RegisterNumber { get; set; }


    public long? UserId { get; set; }


    public UserDto? User { get; set; }
}
