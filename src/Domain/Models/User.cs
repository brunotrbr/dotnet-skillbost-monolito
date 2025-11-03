using src.Domain.Dtos;

namespace src.Domain.Models;

public class User(UserDto userDto)
{
    public long Id { get; set; } = userDto.Id ?? 0;

    public string Email { get; set; } = userDto.Email ?? string.Empty;

    public string Password { get; set; } = userDto.Password ?? string.Empty;

    public Profile? Profile { get; set; } = userDto.Profile != null ? new Profile(userDto.Profile) : null;
}
