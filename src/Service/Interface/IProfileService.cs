using src.Domain.Dtos;
using src.Domain.Models;

namespace src.Service.Interface;

public interface IProfileService
{
    public abstract Task<Profile> Create(ProfileDto profileDto);

    public abstract Task<Profile> Get(long id);

    public abstract Task<List<Profile>> List();

    public abstract Task<Profile> Update(long id, ProfileDto profileDto);

    public abstract Task Delete(long id);
}
