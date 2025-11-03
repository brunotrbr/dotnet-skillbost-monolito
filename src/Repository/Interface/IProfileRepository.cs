using System;
using src.Domain.Models;

namespace src.Repository.Interface;

public interface IProfileRepository
{
    public abstract Task<Profile> Create(Profile profile);

    public abstract Task<Profile> Get(long id);

    public abstract Task<List<Profile>> List();

    public abstract Task<Profile> Update(Profile profile);

    public abstract Task Delete(long id);
}
