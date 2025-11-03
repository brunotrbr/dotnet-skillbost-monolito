using src.Domain.Dtos;
using src.Domain.Models;
using src.Repository.Interface;
using src.Service.Interface;

namespace src.Service;

public class ProfileService(IProfileRepository profileRepository) : IProfileService
{
    private readonly IProfileRepository _profileRepository = profileRepository;

    public async Task<Profile> Create(ProfileDto profileDto)
    {
        var profile = new Profile(profileDto);
        return await _profileRepository.Create(profile);
    }

    public async Task Delete(long id)
    {
        await _profileRepository.Delete(id);
    }

    public async Task<Profile> Get(long id)
    {
        return await GetById(id);
    }

    public async Task<List<Profile>> List()
    {
        return await _profileRepository.List();
    }

    public async Task<Profile> Update(long id, ProfileDto profileDto)
    {
        var existingProfile = await GetById(id);
        existingProfile.Update(profileDto);
        return await _profileRepository.Update(existingProfile);
    }

    private async Task<Profile> GetById(long id)
    {
        return await _profileRepository.Get(id) ?? throw new KeyNotFoundException($"Profile with id {id} not found.");
    }
}
