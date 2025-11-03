using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using src.Domain.Dtos;
using src.Domain.Models;
using src.Service.Interface;

namespace src.Controller.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController(IProfileService profileService) : ControllerBase
    {
        private readonly IProfileService _profileService = profileService ?? throw new ArgumentNullException(nameof(profileService));
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Profile>>> List()
        {
            return Ok(await _profileService.List());
        }

        [HttpGet]
        [Route("profileId:long")]
        public async Task<ActionResult<Profile>> Get(long profileId)
        {
            return Ok(await _profileService.Get(profileId));
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Profile>> Create([FromBody] ProfileDto profileDto)
        {
            var createdProfile = await _profileService.Create(profileDto);
            return CreatedAtAction(nameof(Get), new { profileId = createdProfile.Id }, createdProfile);
        }

        // update
        [HttpPatch]
        [Route("{profileId:long}")]
        public async Task<ActionResult<Profile>> Update(long profileId, [FromBody] ProfileDto profileDto)
        {
            return Ok(await _profileService.Update(profileId, profileDto));
        }

        [HttpDelete]
        [Route("profileId:long")]
        public async Task<ActionResult> Delete(long profileId)
        {
            await _profileService.Delete(profileId);
            return NoContent();
        }
        
        // testar
        // banco de dados
    }
}
