using src.Domain.Dtos;

namespace src.Domain.Models;

public class Profile(ProfileDto profileDto)
{
    public long Id { get; set; } = profileDto.Id ?? 0;

    public string Role { get; set; } = profileDto.Role ?? string.Empty;

    public void Update(ProfileDto profileDto)
    {
        if (profileDto.Role is not null)
        {
            Role = profileDto.Role;
        }
    }
}
