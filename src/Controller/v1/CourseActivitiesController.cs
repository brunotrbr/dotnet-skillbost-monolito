using Microsoft.AspNetCore.Mvc;
using src.Domain.Dtos;
using src.Domain.Models;
using src.Service.Interface;

namespace src.Controller.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseActivitiesController(ICourseActivityService courseActivityService) : ControllerBase
    {
        private readonly ICourseActivityService _courseActivityService = courseActivityService ?? throw new ArgumentNullException(nameof(courseActivityService));

        [HttpGet]
        [Route("{activityId:long}")]
        public async Task<ActionResult<CourseActivity>> Get(long activityId)
        {
            return Ok(await _courseActivityService.Get(activityId));
        }

        [HttpPatch]
        [Route("{activityId:long}")]
        public async Task<ActionResult<CourseActivity>> Update(long activityId, [FromBody] CourseActivityDto courseActivityDto)
        {
            return Ok(await _courseActivityService.Update(activityId, courseActivityDto));
        }

        [HttpDelete]
        [Route("{activityId:long}")]
        public async Task<ActionResult> Delete(long activityId)
        {
            await _courseActivityService.Delete(activityId);
            return NoContent();
        }
    }
}
