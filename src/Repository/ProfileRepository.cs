using System;
using src.Domain.Models;
using src.Repository.Interface;

namespace src.Repository;

public class ProfileRepository : IProfileRepository
{
    public Task<Profile> Create(Profile profile)
    {
        throw new NotImplementedException();
    }

    public Task Delete(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Profile> Get(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Profile>> List()
    {
        throw new NotImplementedException();
    }

    public Task<Profile> Update(Profile profile)
    {
        throw new NotImplementedException();
    }
}
