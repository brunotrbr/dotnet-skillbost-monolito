using src.Domain.Dtos;

namespace src.Domain.Models;

public class Professional(ProfessionalDto professionalDto)
{
    public long Id { get; set; } = professionalDto.Id ?? 0;

    public string Name { get; set; } = professionalDto.Name ?? string.Empty;

    public string Email { get; set; } = professionalDto.Email ?? string.Empty;

    public string RegisterNumber { get; set; } = professionalDto.RegisterNumber ?? string.Empty;

    public User? User { get; set; } = professionalDto.User != null ? new User(professionalDto.User) : null;
}
