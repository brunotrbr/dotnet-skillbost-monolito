using System.Text.Json.Serialization;

namespace src.Domain.Dtos;

public record UserDto
{

    public long? Id { get; set; }


    public string? Email { get; set; }


    [JsonIgnore]
    public string? Password { get; set; } //Aplicação para fins didáticos. Nunca lidar com senhas dessa forma!


    public long? ProfileId { get; set; }


    public ProfileDto? Profile { get; set; }

}
