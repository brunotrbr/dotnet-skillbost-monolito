using Microsoft.AspNetCore.Mvc;
using src.Domain.Dtos;
using src.Domain.Models;
using src.Service.Interface;

namespace src.Controller.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(ICourseService courseService, ICourseActivityService courseActivityService) : ControllerBase
    {
        private readonly ICourseService _courseService = courseService ?? throw new ArgumentNullException(nameof(courseService));
        private readonly ICourseActivityService _courseActivityService = courseActivityService ?? throw new ArgumentNullException(nameof(courseActivityService));

        [HttpGet]
        [Route("{courseId:long}/activities")]
        public async Task<List<CourseActivity>> ListCourseActivities(long courseId)
        {
            return await _courseActivityService.ListByCourseId(courseId);
        }

        [HttpPost]
        [Route("{courseId:long}/activities")]
        public async Task<ActionResult<CourseActivity>> Create(long courseId, [FromBody] CourseActivityDto courseActivityDto)
        {
            var createdCourseActivity = await _courseActivityService.Create(courseId, courseActivityDto);
            return CreatedAtAction(nameof(Get), new { activityId = createdCourseActivity.Id  }, createdCourseActivity);
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Course>>> List()
        {
            return Ok(await _courseService.List());
        }

        [HttpGet]
        [Route("{courseId:long}")]
        public async Task<ActionResult<Course>> Get(long courseId)
        {
            return Ok(await _courseService.Get(courseId));
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Course>> Create([FromBody] CourseDto courseDto)
        {
            var createdCourse = await _courseService.Create(courseDto);
            return CreatedAtAction(nameof(Get), new { courseId = createdCourse.Id }, createdCourse);
        }

        [HttpPatch]
        [Route("{courseId:long}")]
        public async Task<ActionResult> Update(long courseId, [FromBody] CourseDto courseDto)
        {
            return Ok(await _courseService.Update(courseId, courseDto));
        }

        [HttpDelete]
        [Route("{courseId:long}")]
        public async Task<ActionResult> Delete(long courseId)
        {
            await _courseService.Delete(courseId);
            return NoContent();
        }
    }
}
